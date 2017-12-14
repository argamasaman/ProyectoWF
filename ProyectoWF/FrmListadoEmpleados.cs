/*****************************************************************************************************************
 * NOMBRE:ProyectoWF
 * AUTOR:Guillermo Sevilla Mendez
 * 
 * CLASE: FrmListadoEmpleados
 * FUNCION: Mostrar relacion de empleados y gestion de los mismos
 * 
 * VERSION:1.0
 * 
 * ***************************************************************************************************************
 * METODOS
 * ********
 * --public FrmListadoEmpleados(int ancho)
 * --private void cargar(DataGridView dgv)
 * --private void buttonBusqueda_Click(object sender, EventArgs e)
 * --private void txtCampos_TextChanged(object sender, EventArgs e)
 * --private void btNuevo_Click(object sender, EventArgs e)
 * --private void btModificar_Click(object sender, EventArgs e)
 * --private void btBorrar_Click(object sender, EventArgs e)
 * --private void btCerrar_Click(object sender, EventArgs e)
 * --private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
 * --private void formAltaPrueba_FormClosed(object sender, FormClosedEventArgs e)
 * --public void ajustarFormulario(int anchoNuevoMdi)
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
    public partial class FrmListadoEmpleados : Form
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


        public FrmListadoEmpleados(int ancho)
        {
            InitializeComponent();
            cadena = ConfigurationManager.ConnectionStrings["ProyectoWF"].ConnectionString;//cadena de conexion en App.conf
            con = Conexion.getConexion();
            bs = new BindingSource();
            splitContainer1.IsSplitterFixed = true;
            cargar(dataGridView1);
            dataGridView1.Columns["EmpleadoID"].Visible = false;
            dataGridView1.Columns["Foto"].Visible = false;
            dataGridView1.Columns["FotoPath"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            ajustarFormulario(ancho);

        }

        private void cargar(DataGridView dgv)
        {
            try
            {
                //con.Open();//abrimos conexion//opcional
                dt = new DataTable();//creamos datatable
                da = new SqlDataAdapter("select * from Empleados", con);//creamos adapter con la consulta
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

        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            int iEntro = 0;
            switch (((TextBox)sender).Name) {

                    case "tbNombre":
                        iEntro = 1;
                        bs.Filter = "Nombre LIKE '%" + tbNombre.Text + "%'";
                        break;
                    case "tbApellidos":
                        iEntro = 2;
                        bs.Filter = "Apellidos LIKE '%" + tbApellidos.Text + "%'"; 
                        break;
                    case "tbCP":
                        iEntro = 3;
                        bs.Filter = "CodigoPostal LIKE '%" + tbCP.Text + "%'";
                        break;
                    case "tbPais":
                        iEntro = 4;
                        bs.Filter = "Pais LIKE '%" + tbPais.Text + "%'";
                        break;
                }
            if ((iEntro!=1) && (tbNombre.Text != ""))
            {
                bs.Filter = bs.Filter + " AND Nombre LIKE '%" + tbNombre.Text + "%'";
            }

            if ((iEntro != 2) && (tbApellidos.Text != ""))
            {
                bs.Filter = bs.Filter + " AND Apellidos LIKE '%" + tbApellidos.Text + "%'";
            }

            if ((iEntro != 3) && (tbCP.Text != ""))
            {
                bs.Filter = bs.Filter + " AND CodigoPostal LIKE '%" + tbCP.Text + "%'";
            }

            if ((iEntro != 4) && (tbPais.Text != ""))
            {
                bs.Filter = bs.Filter + " AND Pais LIKE '%" + tbPais.Text + "%'";
            }

            if (tbNombre.Text=="" && tbApellidos.Text=="" && tbCP.Text=="" && tbPais.Text=="")
            {
                bs.Filter = "";
            }

            dataGridView1.DataSource = bs;
        }

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
                        id = (int)dataGridView1.Rows[i].Cells["EmpleadoID"].Value;
                        try
                        {
                            con.OpenAsync();
                            cmd = new SqlCommand("DELETE FROM Clientes WHERE EmpleadoID=" + id + "", con);
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

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            modo=0;
            int clave= 0;
           
                FormularioEmpleados f = new FormularioEmpleados(modo, clave);
                f.FormClosed += new FormClosedEventHandler(formAltaPrueba_FormClosed);
                f.ShowDialog();
        }

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
                clave = (int)fila.Cells["EmpleadoID"].Value;

                //otra manera
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    fila = dataGridView1.Rows[i];
                //    if (fila.Selected == true)
                //    {
                //        clave = (int)fila.Cells["ClienteID"].Value;
                //    }
                FormularioEmpleados f = new FormularioEmpleados(modo,clave);
                f.ShowDialog();
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modo = 2;
            int clave = 0;
            int indice;
            indice = dataGridView1.SelectedCells[0].RowIndex;
            clave = (int)dataGridView1.Rows[indice].Cells["EmpleadoID"].Value;

            FormularioEmpleados f = new FormularioEmpleados(modo, clave);
            f.ShowDialog();
        }


        private void formAltaPrueba_FormClosed(object sender, FormClosedEventArgs e) {
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
            else
            {
                this.Width = anchoMinimo;
                this.Height = altoMinimo;
            }

        }
    }
}
