﻿using System;
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

namespace ProyectoWF
{
    //////////////////////////////
    //  Autor: Cristian de Gea Pintor
    //  Versión: 1.0 30/11/2017
    //////////////////////////////
    //        Métodos
    //////////////////////////////
    //  cargarOpciones()
    //  cargarProducto()
    //  cargarComboBox(SqlCommand cadena, ComboBox cb)
    //  buscarProveedor(int pk, String nombreCompania)
    //  buscarCategoria(int pk, String nombreCategoria)
    //  btBuscarFoto_Click()
    //  btBorrarFoto_Click()
    //  btCancelar_Click()
    //  btAceptar_Click()
    //  FormularioProductos_FormClosing()
    //  DatosObligatorios()
    public partial class FormularioProductos : Form
    {
        private int modo;
        private int pk;
        String imagen = "";
        private SqlCommand cadenaInsert, cadenaUpdate, cadenaCategorias, cadenaProveedores, cadenaSelect;

        public FormularioProductos()
        {
        }
        // @param modo: Recibimos el modo de inicio del formulario (0: Alta, 1: Modificación, 2: Vista)
        // @param primaryKey: ID del producto para modificar. Cargaremos todos los datos a partir de el.
        // getConexion(): Llamamos al método estático de la clase Conexion, iniciamos una conexión si no se ha hecho ya.
        // @var cadenaInsert: Insert preparada de los datos de los productos. Se le pasa la conexión.
        // @var cadenaUpdate: Modificación de los productos a partir de la PK recibida en la creación del formulario.
        // @var cadenaCategorias: Devuelve todas las categorías.
        // @var cadenaProveedores: Devuelve todos los proveedores.
        // @var cadenaSelect: Devuelve todos los datos de los productos a partir de la PK.
        public FormularioProductos(int modo, int primaryKey) {
            InitializeComponent();
            this.modo = modo;
            this.pk = primaryKey;

            Conexion.getConexion();

            cadenaInsert = new SqlCommand("insert into Productos (ProductoNombre, ProveedorID, CategoriaID, CantidadPorUnidad, PrecioUnidad, UnidadesEnExistencias, imagen) " +
                                  "values (@nombre, @proveedor, @categoria, @cantidad, @precio, @stock, @imagen)", Conexion.conexion);
            cadenaUpdate = new SqlCommand("UPDATE Productos SET ProductoNombre = @nombre, ProveedorID = @proveedor," +
                                          " CategoriaID = @categoria, CantidadPorUnidad = @cantidad, " +
                                          "PrecioUnidad = @precio, UnidadesEnExistencias = @stock, Imagen = @imagen " +
                                          "WHERE ProductoID = @id", Conexion.conexion);
            cadenaCategorias = new SqlCommand("SELECT nombreCategoria FROM Categorias", Conexion.conexion);
            cadenaProveedores = new SqlCommand("SELECT nombreCompania FROM Proveedores", Conexion.conexion);
            cadenaSelect = new SqlCommand("SELECT * FROM Productos WHERE @id = ProductoID", Conexion.conexion);
            cargarOpciones();
            

            
        }
        // Se añaden tooltips en los controles.
        // La opción de borrar foto se oculta por defecto.
        private void cargarOpciones() {
            toolTip1.SetToolTip(tbNombre, "Nombre del producto.");
            toolTip1.SetToolTip(tbCantidad, "Cantidad del producto.");
            toolTip1.SetToolTip(tbPrecio, "Precio unitario del producto.");
            toolTip1.SetToolTip(cbCategoria, "Categoría del producto.");
            toolTip1.SetToolTip(cbProveedor, "Proveedor del producto.");
            toolTip1.SetToolTip(tbStock, "Unidades en existencias.");
            toolTip1.SetToolTip(pbFoto, "Imagen del producto.");
            toolTip1.SetToolTip(btBuscarFoto, "Busca una foto en el equipo.");
            toolTip1.SetToolTip(btBorrarFoto, "Borra la foto mostrada.");
            tbBorrarFoto.Visible = false;
            btBorrarFoto.Visible = false;
            cargarComboBox(cadenaProveedores, cbProveedor);
            cargarComboBox(cadenaCategorias, cbCategoria);
            

            if (modo == 0)
            {
                this.Text = "Alta de producto";
            }
            else if (modo == 1)
            {
                this.Text = "Modificación de producto";
                cargarProducto();
                

            }
            else if (modo == 2)
            {
                this.Text = "Vista de datos de producto";
                tbNombre.Enabled = false;
                tbCantidad.Enabled = false;
                tbPrecio.Enabled = false;
                cbProveedor.Enabled = false;
                cbCategoria.Enabled = false;
                tbStock.Enabled = false;
                btCancelar.Enabled = false;
                btBuscarFoto.Enabled = false;
                cargarProducto();

            }
        }

        private void cargarProducto() {
            cadenaSelect.Parameters.Clear();
            cadenaSelect.Parameters.AddWithValue("id", pk);
            SqlDataReader dr = cadenaSelect.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    tbNombre.Text = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        cbProveedor.Text = buscarProveedor(dr.GetInt32(2),"");
                    if (!dr.IsDBNull(3))
                        cbCategoria.Text = buscarCategoria(dr.GetInt32(3), "");
                    if (!dr.IsDBNull(4))
                        tbCantidad.Text = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        tbPrecio.Text = dr.GetSqlMoney(5).ToString();
                    if (!dr.IsDBNull(6))
                        tbStock.Text = dr.GetInt16(6).ToString();
                    if (!dr.IsDBNull(7))
                    {
                        byte[] imageData;
                        imageData = (byte[])dr[7];
                        pbFoto.Image = Image.FromStream(new MemoryStream(imageData));
                    }
                    if (pbFoto.Image != null) {
                        tbBorrarFoto.Visible = true;
                        btBorrarFoto.Visible = true;
                    }

                }

            }
            dr.Close();
        }
        private void cargarComboBox(SqlCommand cadena, ComboBox cb) {
            
            SqlDataReader dr = cadena.ExecuteReader();
            cb.Items.Add("");
            while (dr.Read()) {
                cb.Items.Add(dr[0]);
            }
            dr.Close();
            
        }

        private String buscarProveedor(int pk, String nombreCompania) {
            SqlCommand cadena = new SqlCommand("SELECT ProveedorID, nombreCompania FROM Proveedores WHERE @id = ProveedorID OR @nombreCompania = nombreCompania", Conexion.conexion);
            cadena.Parameters.Clear();
            if (pk != 0)
                cadena.Parameters.AddWithValue("id",pk);
            else
                cadena.Parameters.AddWithValue("id", "");
            cadena.Parameters.AddWithValue("nombreCompania", nombreCompania);
            SqlDataReader dr = cadena.ExecuteReader();
            String nombre, primaryKey;

            if (nombreCompania.Equals(""))
            {
                if (dr.Read())
                {
                    nombre = dr.GetString(1);
                    dr.Close();
                    return nombre;
                }
            }
            else {
                if (dr.Read())
                {
                    primaryKey = dr.GetInt32(0).ToString();
                    dr.Close();
                    return primaryKey;
                }

            }

            dr.Close();
            return "";
        }

        private String buscarCategoria(int pk, String nombreCategoria)
        {
            SqlCommand cadena = new SqlCommand("SELECT CategoriaID, NombreCategoria FROM Categorias WHERE @id = CategoriaID OR @nombreCategoria = nombreCategoria", Conexion.conexion);
            cadena.Parameters.Clear();
            if (pk != 0)
                cadena.Parameters.AddWithValue("id", pk);
            else
                cadena.Parameters.AddWithValue("id", "");
            cadena.Parameters.AddWithValue("nombreCategoria", nombreCategoria);
            SqlDataReader dr = cadena.ExecuteReader();
            String nombre, primaryKey;
            if (nombreCategoria.Equals(""))
            {
                if (dr.Read())
                {
                    nombre = dr.GetString(1);
                    dr.Close();
                    return nombre;
                }
            }
            else
            {
                if (dr.Read())
                {
                    primaryKey = dr.GetInt32(0).ToString();
                    dr.Close();
                    return primaryKey;
                }

            }

            dr.Close();
            return "";
        }

        private void btBuscarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                imagen = openFileDialog1.FileName;
                pbFoto.Image = new Bitmap(openFileDialog1.FileName);
                tbBorrarFoto.Visible = true;
                btBorrarFoto.Visible = true;
            }
        }

        private void btBorrarFoto_Click(object sender, EventArgs e)
        {
            pbFoto.Image = null;
            tbBorrarFoto.Visible = false;
            btBorrarFoto.Visible = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Conexion.cerrarConexion();
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                if (!DatosObligatorios())
                {
                    MessageBox.Show("Faltan datos obligatorios.","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    cadenaInsert.Parameters.Clear();
                    cadenaInsert.Parameters.AddWithValue("nombre", tbNombre.Text);
                    if (!cbProveedor.Text.Equals(""))
                    {
                        cadenaInsert.Parameters.AddWithValue("proveedor", buscarProveedor(0, cbProveedor.Text));
                    }
                    else {
                        cadenaInsert.Parameters.AddWithValue("proveedor", DBNull.Value);
                    }
                    if (!cbCategoria.Text.Equals(""))
                        cadenaInsert.Parameters.AddWithValue("categoria", buscarCategoria(0, cbCategoria.Text));
                    else
                    {
                        cadenaInsert.Parameters.AddWithValue("categoria", DBNull.Value);
                    }
                    if (!tbCantidad.Text.Equals(""))
                        cadenaInsert.Parameters.AddWithValue("cantidad", tbCantidad.Text);
                    else
                        cadenaInsert.Parameters.AddWithValue("cantidad", DBNull.Value);

                    cadenaInsert.Parameters.AddWithValue("precio", tbPrecio.Text);
                    cadenaInsert.Parameters.AddWithValue("stock", tbStock.Text);
                    byte[] imageData;
                    imageData = File.ReadAllBytes(@imagen);
                    cadenaInsert.Parameters.Add("imagen", SqlDbType.Image).Value = imageData;
                    int res = cadenaInsert.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Datos almacenados.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (modo == 1)
            {
                if (!DatosObligatorios())
                {
                    MessageBox.Show("Faltan datos obligatorios.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cadenaUpdate.Parameters.Clear();
                    cadenaUpdate.Parameters.AddWithValue("nombre", tbNombre.Text);
                    if (!cbProveedor.Text.Equals(""))
                    {
                        cadenaUpdate.Parameters.AddWithValue("proveedor", buscarProveedor(0, cbProveedor.Text));
                    }
                    else
                    {
                        cadenaUpdate.Parameters.AddWithValue("proveedor", DBNull.Value);
                    }
                    if (!cbCategoria.Text.Equals(""))
                        cadenaUpdate.Parameters.AddWithValue("categoria", buscarCategoria(0, cbCategoria.Text));
                    else
                    {
                        cadenaUpdate.Parameters.AddWithValue("categoria", DBNull.Value);
                    }
                    if (!tbCantidad.Text.Equals(""))
                        cadenaUpdate.Parameters.AddWithValue("cantidad", tbCantidad.Text);
                    else
                        cadenaUpdate.Parameters.AddWithValue("cantidad", DBNull.Value);

                    cadenaUpdate.Parameters.AddWithValue("precio", tbPrecio.Text);
                    cadenaUpdate.Parameters.AddWithValue("stock", tbStock.Text);
                    cadenaUpdate.Parameters.AddWithValue("id", pk);
                    if (pbFoto.Image != null)
                    {
                        byte[] imageData;
                        imageData = File.ReadAllBytes(@imagen);
                        cadenaUpdate.Parameters.Add("imagen", SqlDbType.Image).Value = imageData;
                    }
                    else
                    {
                        
                        cadenaUpdate.Parameters.Add("imagen", SqlDbType.Image).Value = DBNull.Value;
                    }
                    int res = cadenaUpdate.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Producto modificado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (modo == 2)
            {
                Dispose();
            }
        }

        private void FormularioProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexion.cerrarConexion();
            Dispose();
        }

        private Boolean DatosObligatorios() {
            if (!tbNombre.Text.Equals("")) {
                return true;
            }
            return false;
        }
    }
}
