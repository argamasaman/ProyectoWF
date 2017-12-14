using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF
{
    public partial class Login : Form
    {

        private FormularioPrincipal formPrinc;
        public Login()
        {
            InitializeComponent();
            tbContrasena.PasswordChar = '*';
            lErrorUsu.Visible = false;
            lErrorCon.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Este método hace las comprobaciones necesarias para hacer el login correcto, en ese caso abre el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btIniciarSesion_Click(object sender, EventArgs e)
        {

            lErrorUsu.Visible = false;
            lErrorCon.Visible = false;
            SqlCommand command = new SqlCommand("select * from dbo.Empleados where Usuario=HASHBYTES('SHA2_512',@usuario)", Conexion.getConexion());
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tbUsuario.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Console.WriteLine(dataSet.Tables[0].Rows.Count);
           
            if (dataSet.Tables[0].Rows.Count == 1)
            {
                command = new SqlCommand("select * from dbo.Empleados where Usuario=HASHBYTES('SHA2_512',@usuario) and Password=HASHBYTES('SHA2_512',@password)", Conexion.getConexion());
                command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tbUsuario.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = tbContrasena.Text;
                using (adapter = new SqlDataAdapter(command))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    Console.WriteLine(dataSet.Tables[0].Rows.Count);
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        this.Hide();
                        tbContrasena.Dispose();
                        new FormularioPrincipal(tbUsuario.Text).ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("La contraseña introducida es incorrecta", "¡Error Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lErrorCon.Visible = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("El usuario introducido no existe", "¡Error Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lErrorUsu.Visible = true;
            }
            
        }

  

        private void tbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
