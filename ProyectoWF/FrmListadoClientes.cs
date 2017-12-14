/*****************************************************************************************************************
 * NOMBRE:ProyectoWF
 * AUTOR:Francisco Lopez Puerta
 * 
 * CLASE: FrmListadoClientes 
 * FUNCION: Mostrar relacion de clientes y gestion de los mismos
 * 
 * VERSION:1.0
 * 
 * ***************************************************************************************************************
 * METODOS
 * ********
 * --public FrmListadoClientes()
 * --private void cargar(DataGridView dgv)
 * --private void buttonBusqueda_Click(object sender, EventArgs e)
 * --private void txtCampos_TextChanged(object sender, EventArgs e)
 * --private void btNuevo_Click(object sender, EventArgs e)
 * --private void btModificar_Click(object sender, EventArgs e)
 * --private void btBorrar_Click(object sender, EventArgs e)
 * --private void btCerrar_Click(object sender, EventArgs e)
 * 
 * 
 * ****************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProyectoWF
{
    public partial class FrmListadoClientes : Form
    {

        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        String cadena;
        BindingSource bs;
        SqlCommand cmd;
        int modo;
        private int anchoMdi = 1200;

        private int anchoMinimo = 600;
        private int altoMinimo = 400;
        

        public FrmListadoClientes(int ancho)
        {
            
            InitializeComponent();
            cadena = ConfigurationManager.ConnectionStrings["ProyectoWF"].ConnectionString;//cadena de conexion en App.conf
            con = Conexion.getConexion();
            bs = new BindingSource();
            splitContainer1.IsSplitterFixed = true;
            cargar(dataGridView1);
            dataGridView1.Columns["ClienteID"].Visible = false;
            dataGridView1.Columns["Logo"].Visible = false;
            ajustarFormulario(ancho);
        }

        private void cargar(DataGridView dgv)
        {
            try
            {
                //con.Open();//abrimos conexion//opcional
                dt = new DataTable();//creamos datatable
                da = new SqlDataAdapter("select * from Clientes", con);//creamos adapter con la consulta
                da.Fill(dt);//cargamos el datatable con el adapter
                dgv.DataSource = dt;//cargamos el datagridview con datatable
                bs.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("no se pudo llenar el datagridview" + e.ToString());
            }
        }


        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                btFiltrar.Text = "Cerrar";
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.SplitterDistance = 120;
            }
            else
            {
                btFiltrar.Text = "Abrir";
                splitContainer1.Panel1Collapsed = true;

            }
        }

        //Filtrado de busqueda
        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            int iEntro = 0;
            switch (((TextBox)sender).Name) {

                    case "txtNombre":
                        iEntro = 1;
                        bs.Filter = "ContactoNombre LIKE '%" + txtNombre.Text + "%'";
                        break;
                    case "txtCompañia":
                        iEntro = 2;
                        bs.Filter = "NombreCompania LIKE '%" + txtCompañia.Text + "%'"; 
                        break;
                    case "txtCP":
                        iEntro = 3;
                        bs.Filter = "CodigoPostal LIKE '%" + txtCP.Text + "%'";
                        break;
                    case "txtPais":
                        iEntro = 4;
                        bs.Filter = "Pais LIKE '%" + txtPais.Text + "%'";
                        break;
                }
            if ((iEntro!=1) && (txtNombre.Text != ""))
            {
                bs.Filter = bs.Filter + " AND ContactoNombre LIKE '%" + txtNombre.Text + "%'";
            }

            if ((iEntro != 2) && (txtCompañia.Text != ""))
            {
                bs.Filter = bs.Filter + " AND NombreCompania LIKE '%" + txtCompañia.Text + "%'";
            }

            if ((iEntro != 3) && (txtCP.Text != ""))
            {
                bs.Filter = bs.Filter + " AND CodigoPostal LIKE '%" + txtCP.Text + "%'";
            }

            if ((iEntro != 4) && (txtPais.Text != ""))
            {
                bs.Filter = bs.Filter + " AND Pais LIKE '%" + txtPais.Text + "%'";
            }

            if (txtNombre.Text=="" && txtCompañia.Text=="" && txtCP.Text=="" && txtPais.Text=="")
            {
                bs.Filter = "";
            }

            dataGridView1.DataSource = bs;
        }

        //Borrar
        private void btBorrar_Click(object sender, EventArgs e)
        {
            int count=0;
            DataGridViewRow filaborrar;
            int id;
            DialogResult dr=MessageBox.Show("¿Esta seguro de borrar los datos seleccionados?", "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr==DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    filaborrar = dataGridView1.Rows[i];
                    if (filaborrar.Selected == true)
                    {
                        id = (int)dataGridView1.Rows[i].Cells["ClienteID"].Value;
                        try
                        {
                            con.OpenAsync();
                            cmd = new SqlCommand("DELETE FROM Clientes WHERE ClienteID=" + id + "", con);
                            count += cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                MessageBox.Show(count + " filas borradas", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar(dataGridView1);
            }
        }

        //boton de cerrar
        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Boton de crear nuevo
        private void btNuevo_Click(object sender, EventArgs e)
        {
            modo = 0;
            int clave = 0;
            FormCliente f = new FormCliente(modo, clave);
            f.FormClosed += new FormClosedEventHandler(formCliente_FormClosed);
            f.ShowDialog();
        }

        //boton de modificar
        private void btModificar_Click(object sender, EventArgs e)
        {
            modo = 1;
            int clave = 0;
            DataGridViewRow fila;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un campo a modificar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo campo a modificar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                fila=dataGridView1.SelectedRows[0];
                clave = (int)fila.Cells["ClienteID"].Value;

                //otra manera
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    fila = dataGridView1.Rows[i];
                //    if (fila.Selected == true)
                //    {
                //        clave = (int)fila.Cells["ClienteID"].Value;
                //    }
                FormCliente f = new FormCliente(modo,clave);
                f.FormClosed += new FormClosedEventHandler(formCliente_FormClosed);
                f.ShowDialog();
            }
            
        }

        //detalles
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modo = 2;
            int clave = 0;
            int indice;
            indice = dataGridView1.SelectedCells[0].RowIndex;
            clave = (int)dataGridView1.Rows[indice].Cells["ClienteID"].Value;

            FormCliente f = new FormCliente(modo, clave);
            f.ShowDialog();
        }

        //comportamiento al cierre
        private void formCliente_FormClosed(object sender, FormClosedEventArgs e) {
            cargar(dataGridView1);
        }

        //ajustar tamaño del formulario al mdi container
        public void ajustarFormulario(int anchoNuevoMdi)
        {
            splitContainer1.Panel1Collapsed = true;
            double porcentaje = (double)anchoNuevoMdi / (double)anchoMdi;
            anchoMdi = anchoNuevoMdi;
            

            int ancho = (int)(this.Width * porcentaje);
            int alto = (int)(this.Height * porcentaje);

            if (ancho > this.anchoMinimo && alto > this.altoMinimo)
            {
                
                this.Width = ancho;
                this.Height = alto;
            }
            else {
                this.Width = anchoMinimo;
                this.Height = altoMinimo;
            }

        }
    }
}
