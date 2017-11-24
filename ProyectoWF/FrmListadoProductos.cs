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
    public partial class FrmListadoProductos : Form
    {


        SqlConnection con;
        BindingSource bs;

        DataTable table;
        SqlDataAdapter adapter;
        SqlCommand cmd;

        public FrmListadoProductos()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            con = Conexion.getConexion();
            bs = new BindingSource();
            cargar(listaProductos);

            //Ocultar
            listaProductos.Columns["ProductoID"].Visible = false;
            listaProductos.Columns["Imagen"].Visible = false;
            
        }

        

        public void cargar(DataGridView listaProductos)
        {
            try {
                table = new DataTable("Productos");
                adapter = new SqlDataAdapter("select * from Productos", con);
                adapter.Fill(table);

                listaProductos.DataSource = table;
                bs.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo rellenar la lista..");
            }
            
            
        }

        private void busqueda_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                busqueda.Text = "Cerrar";
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.SplitterDistance = 120;
            }
            else
            {
                busqueda.Text = "Abrir";
                splitContainer1.Panel1Collapsed = true;

            }

           
        }

        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int iEntro = 0;
            
            switch (((TextBox)sender).Name)
            {

                case "txtNombre":
                    iEntro = 1;
                    bs.Filter = "ProductoNombre LIKE '%" + txtNombre.Text + "%'";
                    break;
                case "txtCategoria":
                    iEntro = 2;
                    bs.Filter = "CategoriaID LIKE '%" + txtCategoria.Text + "%'";
                    break;
                
            }
            if ((iEntro != 1) && (txtNombre.Text != ""))
            {
                bs.Filter = bs.Filter + " AND ProductoNombre LIKE '%" + txtNombre.Text + "%'";
            }

            if ((iEntro != 2) && (txtCategoria.Text != ""))
            {
                bs.Filter = bs.Filter + " AND CategoriaID LIKE '%" + txtCategoria.Text + "%'";
            } 

            listaProductos.DataSource = bs;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            int count = 0;
            DataGridViewRow filaborrar;
            int id;
            DialogResult dr = MessageBox.Show("¿Esta seguro de borrar los datos seleccionados?", "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < listaProductos.Rows.Count; i++)
                {
                    filaborrar = listaProductos.Rows[i];
                    if (filaborrar.Selected == true)
                    {
                        id = (int)listaProductos.Rows[i].Cells["ProductoID"].Value;
                        try
                        {
                            con.OpenAsync();
                            cmd = new SqlCommand("DELETE FROM Productos WHERE ProductoID=" + id + "", con);
                            count += cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                MessageBox.Show(count + " filas borradas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar(listaProductos);
            }
        }

    }
}
