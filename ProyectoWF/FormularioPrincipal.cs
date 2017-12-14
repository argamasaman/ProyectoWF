using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoWF
{
    public partial class FormularioPrincipal : Form
    {
        private int childFormNumber = 0;
        private Boolean esLogin;

        public bool EsLogin { get => esLogin; set => esLogin = value; }

        public FormularioPrincipal(String usuario)
        {
            InitializeComponent();
            this.EsLogin = false;
            tssUsuario.Text = "Has iniciado sesión con " + usuario;
            tsbExpandir.Visible = false;
            tssUsuario.Spring = true;
            tssUsuario.Alignment = ToolStripItemAlignment.Right;

            inicializarNodosDelTreeView();
        }

        /// <summary>
        /// Este método inicializa todos los nodos que queremos introducir en el treeView
        /// </summary>
        private void inicializarNodosDelTreeView()
        {
            TreeNode nodo = new TreeNode();
            nodo.Text = "Maestro";
            TreeNode nodoClientes = new TreeNode();
            nodoClientes.Text = "Clientes";
            TreeNode nodoProveedores = new TreeNode();
            nodoProveedores.Text = "Proveedores";
            TreeNode nodoProductos = new TreeNode();
            nodoProductos.Text = "Productos";
            TreeNode nodoEmpleados = new TreeNode();
            nodoEmpleados.Text = "Empleados";
            nodo.Nodes.Add(nodoClientes);
            nodo.Nodes.Add(nodoProveedores);
            nodo.Nodes.Add(nodoProductos);
            nodo.Nodes.Add(nodoEmpleados);
            tvSecciones.Nodes.Add(nodo);
            TreeNode nodoAuxiliares = new TreeNode();
            nodoAuxiliares.Text = "Auxiliares";
            TreeNode nodoCategorias = new TreeNode();
            nodoCategorias.Text = "Categorias";
            TreeNode nodoAgencias = new TreeNode();
            nodoAgencias.Text = "Agencias";
            nodoAuxiliares.Nodes.Add(nodoCategorias);
            nodoAuxiliares.Nodes.Add(nodoAgencias);
            tvSecciones.Nodes.Add(nodoAuxiliares);
            TreeNode nodoPedidos = new TreeNode();
            nodoPedidos.Text = "Pedidos";
            tvSecciones.Nodes.Add(nodoPedidos);
            tvSecciones.ExpandAll();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            splitter.Visible = true;
            tvSecciones.Visible = true;
        }

        /// <summary>
        /// Retrae el treeView haciendolo invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRetraer_Click(object sender, EventArgs e)
        {
            splitter.Visible = false;
            tvSecciones.Visible = false;
            tsbRetraer.Visible = false;
            tsbExpandir.Visible = true;
        }

        /// <summary>
        /// Pone visible el treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExpandir_Click(object sender, EventArgs e)
        {
            splitter.Visible = true;
            tvSecciones.Visible = true;
            tsbRetraer.Visible = true;
            tsbExpandir.Visible = false;
        }

        /// <summary>
        /// Cuando se hace doble click en un nodo del treeView se abre el formulario correspondiente al nodo pulsado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvSecciones_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            String nodoSeleccionado = tvSecciones.SelectedNode.Text;
            switch (tvSecciones.SelectedNode.Text)
            {
                case "Clientes":
                    abrirClientes();
                    Console.WriteLine(nodoSeleccionado);
                    break;

                case "Proveedores":
                    abrirProveedores();
                    Console.WriteLine(nodoSeleccionado);
                    break;

                case "Empleados":
                    abrirEmpleados();
                    Console.WriteLine(nodoSeleccionado);
                    break;

                case "Productos":
                    abrirProductos();
                    Console.WriteLine(nodoSeleccionado);
                    break;

                case "Agencias":
                    abrirAgencias();
                    Console.WriteLine(nodoSeleccionado);
                    break;

                case "Categorias":
                    abrirCategorias();
                    Console.WriteLine(nodoSeleccionado);
                    break;

                case "Pedidos":
                    abrirPedidos();
                    Console.WriteLine(nodoSeleccionado);
                    break;
            }
        }

        /// <summary>
        /// Cuando se hace  click en una opción del menu se abre el formulario correspondiente a la opción pulsada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msOpcionesFormPrincipal_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem opcionPulsada = (ToolStripMenuItem)sender;
            switch (opcionPulsada.Text)
            {
                case "Clientes":
                    abrirClientes();
                    Console.WriteLine(opcionPulsada);
                    break;

                case "Proveedores":
                    abrirProveedores();
                    Console.WriteLine(opcionPulsada.Text);
                    break;

                case "Empleados":
                    abrirEmpleados();
                    Console.WriteLine(opcionPulsada.Text);
                    break;

                case "Productos":
                    abrirProductos();
                    Console.WriteLine(opcionPulsada.Text);
                    break;

                case "Agencias":
                    abrirAgencias();
                    Console.WriteLine(opcionPulsada.Text);
                    break;

                case "Categorias":
                    abrirCategorias();
                    Console.WriteLine(opcionPulsada.Text);
                    break;

                case "Pedidos":
                    abrirPedidos();
                    Console.WriteLine(opcionPulsada.Text);
                    break;
            }
        }


        /// <summary>
        /// Este método cierra la "sesión" del usuario, poniendo el booleano estático a true(ese booleano sirve para que en vez de cerrarse el programa por completo se vuelva a abrir el login)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Program.esLogin = true;

            this.Close();
        }

        /// <summary>
        /// Cuando se hace  click en una opción de la barra de tareas se abre el formulario correspondiente a la opción pulsada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Click(object sender, EventArgs e)
        {
            ToolStripButton opcionPulsada = (ToolStripButton)sender;
            switch (opcionPulsada.Name)
            {
                case "tsbClientes":
                    abrirClientes();
                    Console.WriteLine(opcionPulsada.Name);
                    break;

                case "tsbProveedores":
                    abrirProveedores();
                    Console.WriteLine(opcionPulsada.Name);
                    break;

                case "tsbProductos":
                    abrirProductos();
                    Console.WriteLine(opcionPulsada.Name);
                    break;

                case "tsbEmpleados":
                    abrirEmpleados();
                    Console.WriteLine(opcionPulsada.Name);
                    break;

                case "tsbPedidos":
                    abrirPedidos();
                    Console.WriteLine(opcionPulsada.Name);
                    break;
            }
        }

        private void abrirCategorias()
        {
        }

        private void abrirPedidos()
        {
            FormularioPedidos formPedidos = new FormularioPedidos(1, 1);
            formPedidos.MdiParent = this;
            formPedidos.Show();
        }

        private void abrirClientes()
        {
        }

        private void abrirAgencias()
        {
        }

        private void abrirProveedores()
        {
        }

        private void abrirEmpleados()
        {
        }

        private void abrirProductos()
        {
        }

        private void tsbPedidos_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Pedidos");
        }

        /// <summary>
        /// Cuando se va a cerrar el formulario principal se comprueba si hay fomularios abiertos, el caso positivo se notifica a el usuario si quiere salir o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (MessageBox.Show("Hay formularios abiertos.\n¿Desea salir?", "Diálogo salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}