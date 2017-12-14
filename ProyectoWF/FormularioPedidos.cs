using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoWF
{
    public partial class FormularioPedidos : Form
    {
        private ArrayList idClienteSegunPosicion;
        private ArrayList idCAgenciaSegunPosicion;
        private ArrayList idProductoSegunPosicion;
        private int primaryKey;
        private int modo;

        private int numeroFilaSeleccionado;
        private double precioFinal;

        public FormularioPedidos(int modo, int primaryKey)
        {
            InitializeComponent();
            this.primaryKey = primaryKey;
            this.modo = modo;
            mtbPrecioFinal.Enabled = false;

            if (modo == 0)
            {
                //Modo Alta
                cargarDatosCbClientes();
                cargarDatosCbAgencias();
                dgProductos.Rows.Insert(0);
                cargarProductosCbDataGridView();
            }
            else if (modo == 1)
            {
                //Modo modificación
                cargarDatosCbClientes();
                cargarDatosCbAgencias();
                cargarFormularioConIdPedido(true);
                btDarAlta.Text = "Actualizar pedido";
                btEditar.Visible = false;
                btMas.Visible = false;
                btMenos.Visible = false;
                cargarLVConIdPedido(this.primaryKey);
                dgProductos.Columns[1].ReadOnly = true;
            }
            else if (modo == 2)
            {
                //Modo vista bloqueada
                cargarFormularioConIdPedido(false);

                cbViasEnvio.Enabled = false;
                dtFechaPedido.Enabled = false;
                dtFechaEntrega.Enabled = false;
                dtFechaRequerida.Enabled = false;
                tbNombreCliente.Enabled = false;
                btEditar.Visible = false;
                btMas.Visible = false;
                btMenos.Visible = false;
                dgProductos.Enabled = false;
                mtbPrecioFinal.Enabled = false;

                cargarLVConIdPedido(this.primaryKey);

                btCancelar.Text = "Atrás";
                btDarAlta.Visible = false;
            }
        }

        /// <summary>
        /// Carga los datos disponibles de las agencias en el comboBox de vias de agencias
        /// </summary>
        private void cargarDatosCbAgencias()
        {
            string comando = "Select AgenciaID,NombreCompania from dbo.Agencias";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            idCAgenciaSegunPosicion = new ArrayList();
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                idCAgenciaSegunPosicion.Add(cuenta.Tables[0].Rows[i]["AgenciaID"].ToString());
                cbViasEnvio.Items.Add(cuenta.Tables[0].Rows[i]["NombreCompania"].ToString());
            }
        }

        /// <summary>
        /// Carga los datos disponibles de las agencias en el comboBox de clientes
        /// </summary>
        private void cargarDatosCbClientes()
        {
            string comando = "Select ContactoNombre,ClienteID from dbo.Clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            idClienteSegunPosicion = new ArrayList();
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                idClienteSegunPosicion.Add(cuenta.Tables[0].Rows[i]["ClienteID"].ToString());
                tbNombreCliente.Items.Add(cuenta.Tables[0].Rows[i]["ContactoNombre"].ToString());
            }
        }

        /// <summary>
        /// Cuando se selecciona un cliente en el comboBox de clientes este método carga todo los datos en los tb relacionados con el cliente(Si es edición o vista detalles).
        /// </summary>
        /// <param name="isEdicion"></param>
        private void cargarFormularioConIdPedido(bool isEdicion)
        {
            SqlCommand sqlComando = new SqlCommand("Select p.ShipVia,a.NombreCompania,PedidoFecha,FechaEntregado,RequiredFecha,ContactoNombre,c.Telefono,p.CiudadEntrega,p.DireccionEntrega,p.RegionEntrega,p.CodigoPostalEntrega,p.PaisEntrega from dbo.Pedidos p inner join dbo.Clientes c on c.ClienteId=p.ClienteID inner join dbo.Agencias a  on p.ShipVia=a.AgenciaID where PedidoID=@idPedido", Conexion.getConexion());
            sqlComando.Parameters.Add("@idPedido", SqlDbType.Int).Value = this.primaryKey;
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlComando))
            {
                DataSet cuenta = new DataSet();
                adapter.Fill(cuenta);

                dtFechaPedido.Value = Convert.ToDateTime(cuenta.Tables[0].Rows[0]["PedidoFecha"].ToString());
                dtFechaEntrega.Value = Convert.ToDateTime(cuenta.Tables[0].Rows[0]["FechaEntregado"].ToString());
                dtFechaRequerida.Value = Convert.ToDateTime(cuenta.Tables[0].Rows[0]["RequiredFecha"].ToString());
                tbNombreCliente.Text = cuenta.Tables[0].Rows[0]["ContactoNombre"].ToString();
                tbTelefono.Text = cuenta.Tables[0].Rows[0]["Telefono"].ToString();
                tbCiudad.Text = cuenta.Tables[0].Rows[0]["CiudadEntrega"].ToString();
                tbDireccion.Text = cuenta.Tables[0].Rows[0]["DireccionEntrega"].ToString();
                tbRegion.Text = cuenta.Tables[0].Rows[0]["RegionEntrega"].ToString();
                tbCodigoPostal.Text = cuenta.Tables[0].Rows[0]["CodigoPostalEntrega"].ToString();
                tbPais.Text = cuenta.Tables[0].Rows[0]["PaisEntrega"].ToString();
                if (isEdicion)
                {
                    for (int i = 0; i < idCAgenciaSegunPosicion.Count; i++)
                    {
                        Convert.ToInt16(cuenta.Tables[0].Rows[0]["ShipVia"].ToString());
                        if (Convert.ToInt16(idCAgenciaSegunPosicion[i]) == Convert.ToInt16(cuenta.Tables[0].Rows[0]["ShipVia"]))
                        {
                            cbViasEnvio.SelectedIndex = i;
                        }
                    }
                }
                else
                {
                    cbViasEnvio.Text = cuenta.Tables[0].Rows[0]["NombreCompania"].ToString();
                }
            }
        }

        /// <summary>
        /// Cuando en el Combo box de productos se selecciona uno este método carga en esa fila todos los datos relacionados con el producto y hace llamada a el método que calcula el precio final
        /// </summary>
        /// <param name="idPedido"></param>
        private void cargarLVConIdPedido(int idPedido)
        {
            SqlCommand sqlComando = new SqlCommand("Select pd.ProductoID,ProductoNombre,Cantidad,Descuento,pd.PrecioUnidad from dbo.PedidoDetalles pd inner join dbo.Productos p on p.ProductoID = pd.ProductoID where PedidoID =@idPedido", Conexion.getConexion());
            sqlComando.Parameters.Add("@idPedido", SqlDbType.Int).Value = idPedido;
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlComando))
            {
                DataSet cuenta = new DataSet();
                adapter.Fill(cuenta);
                for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
                {
                    dgProductos.Rows.Insert(0);
                    ((DataGridViewComboBoxCell)dgProductos.Rows[0].Cells["nombreProd"]).Items.Add(cuenta.Tables[0].Rows[i]["ProductoNombre"].ToString());
                    ((DataGridViewComboBoxCell)dgProductos.Rows[0].Cells["nombreProd"]).Value = ((DataGridViewComboBoxCell)dgProductos.Rows[0].Cells["nombreProd"]).Items[0];
                    dgProductos.Rows[0].Cells["idProducto"].Value = cuenta.Tables[0].Rows[i]["ProductoID"].ToString();
                    dgProductos.Rows[0].Cells["cantidad"].Value = cuenta.Tables[0].Rows[i]["Cantidad"].ToString();
                    dgProductos.Rows[0].Cells["descuento"].Value = cuenta.Tables[0].Rows[i]["Descuento"].ToString();
                    dgProductos.Rows[0].Cells["precioUnidad"].Value = cuenta.Tables[0].Rows[i]["PrecioUnidad"];
                    double precio = Double.Parse(dgProductos.Rows[0].Cells["cantidad"].Value.ToString()) * Double.Parse(dgProductos.Rows[0].Cells["precioUnidad"].Value.ToString());
                    dgProductos.Rows[0].Cells["precio"].Value = precio - ((precio * Double.Parse(dgProductos.Rows[0].Cells["descuento"].Value.ToString()) / 100));
                }
                calcularPrecioFinal();
            }
        }

        private void cbNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            borrarDatosCliente();
        }

        /// <summary>
        /// Carga los datos de los clientes cuando uno es seleccionado en el combo box
        /// </summary>
        private void colocarDatosCliente()
        {
            if (tbNombreCliente.SelectedItem != null)
            {
                string comando = String.Format("Select * from dbo.Clientes where ClienteID=" + idClienteSegunPosicion[tbNombreCliente.SelectedIndex]);
                using (SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion()))
                {
                    DataSet cuenta = new DataSet();
                    adapter.Fill(cuenta);
                    tbDireccion.Text = cuenta.Tables[0].Rows[0]["Direccion"].ToString();
                    tbCiudad.Text = cuenta.Tables[0].Rows[0]["Ciudad"].ToString();
                    tbRegion.Text = cuenta.Tables[0].Rows[0]["Region"].ToString();
                    tbPais.Text = cuenta.Tables[0].Rows[0]["Pais"].ToString();
                    tbCodigoPostal.Text = cuenta.Tables[0].Rows[0]["CodigoPostal"].ToString();
                    tbTelefono.Text = cuenta.Tables[0].Rows[0]["Telefono"].ToString();
                }
            }
        }

        private void cbNombreCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                borrarDatosCliente();
            }
        }

        /// <summary>
        /// Este método limpiar todas las cajas de texto en el caso de que el item seleccionado del combo box sea nulo(este método solo se llama cuando el combo box pasa de tener un item seleccionado a no tener ninguno)
        /// </summary>
        private void borrarDatosCliente()
        {
            if (tbNombreCliente.SelectedItem == null)
            {
                tbDireccion.Text = "";
                tbCiudad.Text = "";
                tbRegion.Text = "";
                tbPais.Text = "";
                tbCodigoPostal.Text = "";
                tbTelefono.Text = "";
            }
        }

        /// <summary>
        /// Cuando se hace click en el botón más se añade una fila al DataGridView y pone de solo lectura los campos que se podian editar de la fila anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMas_Click(object sender, EventArgs e)
        {
            dgProductos.Rows.Insert(0);
            for (int i = 0; i < dgProductos.Rows.Count; i++)
            {
                dgProductos.Rows[1].Cells["cantidad"].ReadOnly = true;
                dgProductos.Rows[1].Cells["nombreProd"].ReadOnly = true;
            }
        }

        /// <summary>
        /// Cuando se cambia la posición del item seleccionado del combo box de clientes este método llama al método que recarga lo datos de los textBox de los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            colocarDatosCliente();
        }

        /// <summary>
        /// Carga todos los productos disponibles en el comboBox de productos del DataGridView;
        /// </summary>
        public void cargarProductosCbDataGridView()
        {
            string comando = "select ProductoID,ProductoNombre from dbo.Productos order by ProductoID";
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion()))
            {
                DataSet cuenta = new DataSet();
                adapter.Fill(cuenta);
                idProductoSegunPosicion = new ArrayList();
                for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
                {
                    idProductoSegunPosicion.Add(cuenta.Tables[0].Rows[i]["ProductoID"].ToString());
                    ((DataGridViewComboBoxColumn)dgProductos.Columns[1]).Items.Add(cuenta.Tables[0].Rows[i]["ProductoNombre"].ToString());
                }
            }
        }

        /// <summary>
        /// Cuando cambia el item seleccionado del comboBox de productos del DataGridView lanza una consulta a la base de datos que se trae el precio por unidad,posteriormente llama a un método que calcula el precio de cada producto y el precio final.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comando = "select PrecioUnidad from dbo.Productos where ProductoID=" + idProductoSegunPosicion[((ComboBox)sender).SelectedIndex];
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion()))
            {
                DataSet cuenta = new DataSet();
                adapter.Fill(cuenta);
                dgProductos.CurrentRow.Cells["idProducto"].Value = idProductoSegunPosicion[((ComboBox)sender).SelectedIndex];
                dgProductos.CurrentRow.Cells["precioUnidad"].Value = cuenta.Tables[0].Rows[0]["PrecioUnidad"].ToString();
                dgProductos.CurrentRow.Cells["idProducto"].Value = idProductoSegunPosicion[((ComboBox)sender).SelectedIndex];
                calculoCeldaPrecio();
            }
        }

        /// <summary>
        /// Cuando se valida una celda se vuelve a calcula el precio final y el precio de esa fila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Validating(object sender, EventArgs e)
        {
            calculoCeldaPrecio();
        }

        /// <summary>
        /// Este método calcula el precio de  la celda seleccionada y después llama a el método que calcula el precio final
        /// </summary>
        public void calculoCeldaPrecio()
        {
            if (dgProductos.CurrentRow.Cells["cantidad"].Value != null)
            {
                double descuento = ((Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value) > 0 || dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value != null) ? Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["cantidad"].Value) * (Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value) / 100) : 0);
                double precioConDescuentoAplicado = (Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["cantidad"].Value) - descuento) * Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["precioUnidad"].Value);
                dgProductos.CurrentRow.Cells["precio"].Value = precioConDescuentoAplicado;
                calcularPrecioFinal();
            }
        }

        /// <summary>
        /// Este método calcula el precio final sumando todas las celdas "precio" disponibles
        /// </summary>
        public void calcularPrecioFinal()
        {
            precioFinal = 0;
            for (int i = 0; i < dgProductos.Rows.Count; i++)
            {
                precioFinal += Convert.ToDouble(dgProductos.Rows[i].Cells["precio"].Value);
            }

            mtbPrecioFinal.Text = precioFinal.ToString("C", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void dgProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[3].DisplayIndex)
            {
                TextBox tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.LostFocus -= new EventHandler(tb_Validating);
                    tb.LostFocus += new EventHandler(tb_Validating);
                }
            }
            else if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[2].DisplayIndex)
            {
                TextBox tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.LostFocus -= new EventHandler(tb_Validating);
                    tb.LostFocus += new EventHandler(tb_Validating);
                }
            }
            else if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[1].DisplayIndex)
            {
                ComboBox cb = (ComboBox)e.Control;
                if (cb != null)
                {
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
                    cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
                }
            }
        }

        /// <summary>
        /// Cuando se le da a el botón de editar se activa la edición de las celdas de descuento y de cantidad , posteriormente se pone de color de fondo de la fila el gris claro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditar_MouseClick(object sender, MouseEventArgs e)
        {
            numeroFilaSeleccionado = dgProductos.CurrentRow.Index;
            if (numeroFilaSeleccionado > 0)
            {
                dgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.LightGray;
                dgProductos.CurrentRow.Cells["descuento"].ReadOnly = false;
                dgProductos.CurrentRow.Cells["cantidad"].ReadOnly = false;
                numeroFilaSeleccionado = dgProductos.CurrentRow.Index;
            }
        }

        /// <summary>
        /// Cuando se deja el foco de una fila este método vuelve a poner solo lectura la celda descuento y la celda cantidad,posteriormente pone el color del vacío.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgProductos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (numeroFilaSeleccionado > 0)
            {
                dgProductos.Rows[numeroFilaSeleccionado].Cells["descuento"].ReadOnly = true;
                dgProductos.Rows[numeroFilaSeleccionado].Cells["cantidad"].ReadOnly = true;
                dgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        /// <summary>
        /// Cuando se da click en el botón de alta se da de alta en la base de datos todos los datos de el pedido y todas las filas del data gridView, si se abre en modo edicion en vez de dar de alta se actualiarán los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDarAlta_Click(object sender, EventArgs e)

        {
            if (tbNombreCliente.SelectedItem != null && cbViasEnvio.SelectedItem != null)
            {
                if (modo == 0)
                {
                    actualizarPrecioAntesDeOperar();
                    using (SqlCommand sqlCommand = new SqlCommand("insert into dbo.Pedidos(ClienteID,EmpleadoID,PedidoFecha,RequiredFecha,FechaEntregado,ShipVia,Freight,NombreEntrega,DireccionEntrega,CiudadEntrega,RegionEntrega,CodigoPostalEntrega,PaisEntrega) values(@idCliente,@idEmpleado,@join_date,@join_date2,@join_date3,@idAgencia," +
                        "@precioFinal,@nombreCliente,@direccionCliente,@ciudadCliente,@regionCliente,@cpCliente,@paisCliente)", Conexion.getConexion()))
                    {
                        sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = idClienteSegunPosicion[tbNombreCliente.SelectedIndex];
                        sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = primaryKey;
                        sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                        sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = precioFinal;
                        sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;
                        sqlCommand.Parameters.Add("@direccionCliente", SqlDbType.VarChar).Value = tbDireccion.Text;
                        sqlCommand.Parameters.Add("@ciudadCliente", SqlDbType.VarChar).Value = tbCiudad.Text;
                        sqlCommand.Parameters.Add("@regionCliente", SqlDbType.VarChar).Value = tbRegion.Text;
                        sqlCommand.Parameters.Add("@cpCliente", SqlDbType.VarChar).Value = tbCodigoPostal.Text;
                        sqlCommand.Parameters.Add("@paisCliente", SqlDbType.VarChar).Value = tbPais.Text;
                        sqlCommand.Parameters.Add("@join_date", SqlDbType.Date).Value = DateTime.Now;
                        sqlCommand.Parameters.Add("@join_date2", SqlDbType.Date).Value = dtFechaRequerida.Value;
                        sqlCommand.Parameters.Add("@join_date3", SqlDbType.Date).Value = dtFechaEntrega.Value;

                        sqlCommand.ExecuteNonQuery();
                    }
                    for (int i = 0; i < dgProductos.RowCount; i++)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("insert into"))
                        {
                            sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = dgProductos.Rows[i].Cells["idProducto"].Value; ;
                            sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = primaryKey;
                            sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                            sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = precioFinal;
                            sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;
                        }
                    }

                }
                else
                {
                    actualizarPedido();
                }
            }
        }

        /// <summary>
        /// Cuando le das click al botón de menos se eliminan del DataGrivView todas las celdas seleccionadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMenos_Click(object sender, EventArgs e)
        {
            if (dgProductos.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgProductos.SelectedRows)
                {
                    dgProductos.Rows.Remove(row);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Este método actualiza en la base de datos los campos modificados, este método se llama en el botón de de alta en caso de que se edición
        /// </summary>
        private void actualizarPedido()
        {
            actualizarPrecioAntesDeOperar();

            SqlTransaction transaction;

            transaction = Conexion.getConexion().BeginTransaction("SampleTransaction");
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("update dbo.Pedidos set ClienteID=@idCliente,RequiredFecha=@join_date2,FechaEntregado=@join_date3,ShipVia=@idAgencia,Freight=@precioFinal,NombreEntrega=@nombreCliente,DireccionEntrega=@direccionCliente,CiudadEntrega=@ciudadCliente,RegionEntrega=@regionCliente,CodigoPostalEntrega=@cpCliente,PaisEntrega=@paisCliente where PedidoID=@idPedido", Conexion.getConexion()))
                {
                    sqlCommand.Transaction = transaction;
                    Console.WriteLine(cbViasEnvio.SelectedIndex);
                    Console.WriteLine(idCAgenciaSegunPosicion.Count);
                    sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = idClienteSegunPosicion[tbNombreCliente.SelectedIndex];
                    sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = primaryKey;
                    sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                    sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = precioFinal;
                    sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;
                    sqlCommand.Parameters.Add("@direccionCliente", SqlDbType.VarChar).Value = tbDireccion.Text;
                    sqlCommand.Parameters.Add("@ciudadCliente", SqlDbType.VarChar).Value = tbCiudad.Text;
                    sqlCommand.Parameters.Add("@regionCliente", SqlDbType.VarChar).Value = tbRegion.Text;
                    sqlCommand.Parameters.Add("@cpCliente", SqlDbType.VarChar).Value = tbCodigoPostal.Text;
                    sqlCommand.Parameters.Add("@paisCliente", SqlDbType.VarChar).Value = tbPais.Text;
                    sqlCommand.Parameters.Add("@join_date", SqlDbType.Date).Value = DateTime.Now;
                    sqlCommand.Parameters.Add("@join_date2", SqlDbType.Date).Value = dtFechaRequerida.Value;
                    sqlCommand.Parameters.Add("@join_date3", SqlDbType.Date).Value = dtFechaEntrega.Value;
                    sqlCommand.Parameters.Add("@idPedido", SqlDbType.Int).Value = this.primaryKey;
                    sqlCommand.ExecuteNonQuery();
                }

                for (int i = 0; i < dgProductos.RowCount; i++)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("update dbo.PedidoDetalles set Cantidad=@cantidad,Descuento=@descuento where PedidoID=@idPedido and ProductoID=@idProducto", Conexion.getConexion()))
                    {
                        sqlCommand.Transaction = transaction;
                        sqlCommand.Parameters.Add("@idProducto", SqlDbType.Int).Value = dgProductos.Rows[i].Cells["idProducto"].Value;
                        sqlCommand.Parameters.Add("@cantidad", SqlDbType.Int).Value = dgProductos.Rows[i].Cells["cantidad"].Value;
                        sqlCommand.Parameters.Add("@descuento", SqlDbType.Decimal).Value = dgProductos.Rows[i].Cells["descuento"].Value;
                        sqlCommand.Parameters.Add("@idPedido", SqlDbType.Int).Value = this.primaryKey;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("Pedido actualizado correctamente", "Actualización de pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (SqlException)
            {
                transaction.Rollback();
                MessageBox.Show("Error al actualizar el pedido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Como no siempre se pierde el foco en el DataGrdView antes de darle al botón de dar de alta este método asegura que los precio estan bien calculados antes de darlos de alta o de actualizarlos
        /// </summary>
        private void actualizarPrecioAntesDeOperar()
        {
            for (int i = 0; i < dgProductos.RowCount; i++)
            {
                double descuento = ((Convert.ToDouble(dgProductos.Rows[i].Cells["descuento"].Value) > 0 || dgProductos.Rows[i].Cells["descuento"].Value != null) ? Convert.ToDouble(dgProductos.Rows[i].Cells["cantidad"].Value) * (Convert.ToDouble(dgProductos.Rows[i].Cells["descuento"].Value) / 100) : 0);
                double precioConDescuentoAplicado = (Convert.ToDouble(dgProductos.Rows[i].Cells["cantidad"].Value) - descuento) * Convert.ToDouble(dgProductos.Rows[i].Cells["precioUnidad"].Value);
                dgProductos.Rows[i].Cells["precio"].Value = precioConDescuentoAplicado;
                calcularPrecioFinal();
            }
        }
    }
}