using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoWF {
	/// <summary>
	/// CLASE: FormProveedores - Alta, modificación y vista de proveedores.
	/// AUTOR: Ángel González Sala
	/// TESTEADO: 24/11/2017
	/// </summary>
	public partial class FormProveedores : Form {
		private int modo = 0;
		private int pk;
		private SqlConnection conexion;

		/// <summary>
		/// Crea un objeto del tipo FormProveedores, en modo de alta (0),modificación (1), o vista de detalles(2). 
		/// 
		/// modo Alta (0): Este modo hace una inserción de los campos del formulario en la base de datos.
		/// 
		/// modo Modificación(1): Este modo abre el formulario permitiendo una actualización de los datos del proveedor en la base de datos, habiendo cargado
		/// al inicio los valores previos existentes.
		/// 
		/// modo vista de detalles(2): Este modo deshabilita los controles editables y carga en ellos los valores existentes en
		/// la base de datos.
		/// </summary>
		/// <param name="modo">Valores: 0 - modo alta de nuevo proveedor, 1 - modificación de proveedor existente, 2 - vista de detalles.</param>
		/// <param name="primaryKey">La clave primaria del proveedor que se va a cargar en el formulario. 
		/// Este parametro se lee solo cuando se abre en modo 1 y 2, si se usa el modo 0 este valor puede ser cualquier int.</param>
		public FormProveedores(int modo, int primaryKey) {
			InitializeComponent();
			this.modo = modo;
			this.pk = primaryKey;
			try {
				this.conexion = Conexion.getConexion();

				if (modo == 0) {
					this.Text = "Alta de proveedor";
				} else if (modo == 1) {
					this.Text = "Modificación de proveedor";
					SqlCommand consulta = new SqlCommand("SELECT * FROM dbo.Proveedores WHERE ProveedorID = @pk", conexion);
					consulta.Parameters.Add("@pk",SqlDbType.VarChar).Value = pk;
					SqlDataReader reader = consulta.ExecuteReader();

					while (reader.Read()) {

						tbNombre.Text = reader.GetString(1);
						tbContacto.Text = reader.GetString(2);
						cbTratamiento.Text = reader.GetString(3);
						tbDireccion.Text = reader.GetString(4);
						tbCiudad.Text = reader.GetString(5);
						tbRegion.Text = reader.GetString(6);
						tbCodPostal.Text = reader.GetString(7);
						tbPais.Text = reader.GetString(8);
						mtbTelefono.Text = reader.GetString(9);
						mtbFax.Text = reader.GetString(10);
						tbWeb.Text = reader.GetString(11);
						tbLogo.Text = "Cargado desde base de datos";
						if (reader.GetStream(12).ReadByte() != -1) {
							pbLogo.Image = Image.FromStream(reader.GetStream(12));
						}
						

					}
					reader.Close();

					if (tbNombre.Text == "") {
						MessageBox.Show("Clave primaria inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Close();
					}

				} else if (modo == 2) {
					this.Text = "Vista de datos proveedor";

					SqlCommand consulta = new SqlCommand("SELECT * FROM dbo.Proveedores WHERE ProveedorID = @pk", conexion);
					consulta.Parameters.Add("@pk", SqlDbType.VarChar).Value = pk;
					SqlDataReader reader = consulta.ExecuteReader();

					while (reader.Read()) {

						tbNombre.Enabled = false;
						tbNombre.Text = reader.GetString(1);
						tbContacto.Enabled = false;
						tbContacto.Text = reader.GetString(2);
						cbTratamiento.Enabled = false;
						cbTratamiento.Text = reader.GetString(3);
						tbDireccion.Enabled = false;
						tbDireccion.Text = reader.GetString(4);
						tbCiudad.Enabled = false;
						tbCiudad.Text = reader.GetString(5);
						tbRegion.Enabled = false;
						tbRegion.Text = reader.GetString(6);
						tbCodPostal.Enabled = false;
						tbCodPostal.Text = reader.GetString(7);
						tbPais.Enabled = false;
						tbPais.Text = reader.GetString(8);
						mtbTelefono.Enabled = false;
						mtbTelefono.Text = reader.GetString(9);
						mtbFax.Enabled = false;
						mtbFax.Text = reader.GetString(10);
						tbWeb.Enabled = false;
						tbWeb.Text = reader.GetString(11);
						btExaminar.Enabled = false;
						tbLogo.Text = "Cargado desde base de datos";
						if (reader.GetStream(12).ReadByte() != -1) {
							pbLogo.Image = Image.FromStream(reader.GetStream(12));
						}

					}
					reader.Close();

					if (tbNombre.Text == "") {
						MessageBox.Show("Clave primaria inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Close();
					}

				}
			} catch (SqlException ex) {
				MessageBox.Show("Error de base de datos." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}
		/// <summary>
		/// Evento del botón examinar. Abre un diálogo de selección de foto y la carga en un PictureBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btExaminar_Click(object sender, EventArgs e) {
			OpenFileDialog od = new OpenFileDialog();

			od.InitialDirectory = ".";
			od.Filter = "Imágenes de mapa de bits (*)|*.bmp;*.gif;*.jpg;";
			od.RestoreDirectory = true;

			if (od.ShowDialog() == DialogResult.OK) {
				try {
					tbLogo.Text = od.FileName;
					pbLogo.ImageLocation = tbLogo.Text;
				} catch (Exception ex) {
					MessageBox.Show("Error: No se ha podido leer el archivo.\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}
		/// <summary>
		/// Evento del botón aceptar. Dependiendo del modo previamente seleccionado en el constructor inserta o actualiza
		/// los campos en la base de datos. Comprueba que los campos obligatorios tengan valor y muestra un mensaje en caso
		/// contrario.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btAceptar_Click(object sender, EventArgs e) {
			try {
				if (modo == 0) {
					if (tbNombre.Text == "") {
						MessageBox.Show("El nombre de la compañía es obligatorio.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					} else {
						if (tbLogo.Text == "") {
							SqlCommand consulta = new SqlCommand("INSERT INTO dbo.Proveedores(NombreCompania,ContactNombre,ContactTitle,Direccion" +
							",Ciudad,Region,CodigoPostal,Pais,Telefono,Fax,HomePage) VALUES (@compania,@contacto,@contactitulo," +
							"@direccion,@ciudad,@region,@codpostal,@pais,@telefono,@fax,@web)", conexion);
							consulta.Parameters.Add("@compania", SqlDbType.VarChar).Value = tbNombre.Text;
							consulta.Parameters.Add("@contacto", SqlDbType.VarChar).Value = tbContacto.Text;
							consulta.Parameters.Add("@contactitulo", SqlDbType.VarChar).Value = cbTratamiento.Text;
							consulta.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tbDireccion.Text;
							consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = tbCiudad.Text;
							consulta.Parameters.Add("@region", SqlDbType.VarChar).Value = tbRegion.Text;
							consulta.Parameters.Add("@codpostal", SqlDbType.VarChar).Value = tbCodPostal.Text;
							consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = tbPais.Text;
							consulta.Parameters.Add("@telefono", SqlDbType.VarChar).Value = mtbTelefono.Text;
							consulta.Parameters.Add("@fax", SqlDbType.VarChar).Value = mtbFax.Text;
							consulta.Parameters.Add("@web", SqlDbType.VarChar).Value = tbWeb.Text;
							consulta.ExecuteNonQuery();
						} else {
							SqlCommand consulta = new SqlCommand("INSERT INTO dbo.Proveedores(NombreCompania,ContactNombre,ContactTitle,Direccion" +
							",Ciudad,Region,CodigoPostal,Pais,Telefono,Fax,HomePage,Logo) VALUES (@compania,@contacto,@contactitulo," +
							"@direccion,@ciudad,@region,@codpostal,@pais,@telefono,@fax,@web,@logo)", conexion);
							consulta.Parameters.Add("@compania", SqlDbType.VarChar).Value = tbNombre.Text;
							consulta.Parameters.Add("@contacto", SqlDbType.VarChar).Value = tbContacto.Text;
							consulta.Parameters.Add("@contactitulo", SqlDbType.VarChar).Value = cbTratamiento.Text;
							consulta.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tbDireccion.Text;
							consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = tbCiudad.Text;
							consulta.Parameters.Add("@region", SqlDbType.VarChar).Value = tbRegion.Text;
							consulta.Parameters.Add("@codpostal", SqlDbType.VarChar).Value = tbCodPostal.Text;
							consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = tbPais.Text;
							consulta.Parameters.Add("@telefono", SqlDbType.VarChar).Value = mtbTelefono.Text;
							consulta.Parameters.Add("@fax", SqlDbType.VarChar).Value = mtbFax.Text;
							consulta.Parameters.Add("@web", SqlDbType.VarChar).Value = tbWeb.Text;
							consulta.Parameters.Add("@logo", SqlDbType.Image).Value = File.ReadAllBytes(@tbLogo.Text);
							consulta.ExecuteNonQuery();
						}
						MessageBox.Show("Alta realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}


				} else if (modo == 1) {
					if (tbNombre.Text == "") {
						MessageBox.Show("El nombre de la compañía es obligatorio.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					} else {
						if (tbLogo.Text == "Cargado desde base de datos") {
							SqlCommand consulta = new SqlCommand("UPDATE dbo.Proveedores SET NombreCompania = @compania,ContactNombre = @contacto,ContactTitle = @contactitulo," +
							"Direccion = @direccion,Ciudad = @ciudad,Region = @region,CodigoPostal = @codpostal,Pais = @pais,Telefono = @telefono,Fax = @fax,HomePage = @web WHERE ProveedorID = @pk", conexion);
							consulta.Parameters.Add("@compania", SqlDbType.VarChar).Value = tbNombre.Text;
							consulta.Parameters.Add("@contacto", SqlDbType.VarChar).Value = tbContacto.Text;
							consulta.Parameters.Add("@contactitulo", SqlDbType.VarChar).Value = cbTratamiento.Text;
							consulta.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tbDireccion.Text;
							consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = tbCiudad.Text;
							consulta.Parameters.Add("@region", SqlDbType.VarChar).Value = tbRegion.Text;
							consulta.Parameters.Add("@codpostal", SqlDbType.VarChar).Value = tbCodPostal.Text;
							consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = tbPais.Text;
							consulta.Parameters.Add("@telefono", SqlDbType.VarChar).Value = mtbTelefono.Text;
							consulta.Parameters.Add("@fax", SqlDbType.VarChar).Value = mtbFax.Text;
							consulta.Parameters.Add("@web", SqlDbType.VarChar).Value = tbWeb.Text;
							consulta.Parameters.Add("@pk", SqlDbType.VarChar).Value = pk;
							consulta.ExecuteNonQuery();
						} else {
							SqlCommand consulta = new SqlCommand("UPDATE dbo.Proveedores SET NombreCompania = @compania,ContactNombre = @contacto,ContactTitle = @contactitulo," +
							"Direccion = @direccion,Ciudad = @ciudad,Region = @region,CodigoPostal = @codpostal,Pais = @pais,Telefono = @telefono,Fax = @fax,HomePage = @web, Logo = @logo WHERE ProveedorID = @pk", conexion);
							consulta.Parameters.Add("@compania", SqlDbType.VarChar).Value = tbNombre.Text;
							consulta.Parameters.Add("@contacto", SqlDbType.VarChar).Value = tbContacto.Text;
							consulta.Parameters.Add("@contactitulo", SqlDbType.VarChar).Value = cbTratamiento.Text;
							consulta.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tbDireccion.Text;
							consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = tbCiudad.Text;
							consulta.Parameters.Add("@region", SqlDbType.VarChar).Value = tbRegion.Text;
							consulta.Parameters.Add("@codpostal", SqlDbType.VarChar).Value = tbCodPostal.Text;
							consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = tbPais.Text;
							consulta.Parameters.Add("@telefono", SqlDbType.VarChar).Value = mtbTelefono.Text;
							consulta.Parameters.Add("@fax", SqlDbType.VarChar).Value = mtbFax.Text;
							consulta.Parameters.Add("@web", SqlDbType.VarChar).Value = tbWeb.Text;
							consulta.Parameters.Add("@logo", SqlDbType.Image).Value = File.ReadAllBytes(@tbLogo.Text);
							consulta.Parameters.Add("@pk", SqlDbType.VarChar).Value = pk;
							consulta.ExecuteNonQuery();
						}

						
						MessageBox.Show("Modificación realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}

				} else if (modo == 2) {
					Close();
				}
			} catch (SqlException ex) {
				MessageBox.Show("Error de base de datos." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}

		/// <summary>
		/// Cierra el formulario.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btCancelar_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
