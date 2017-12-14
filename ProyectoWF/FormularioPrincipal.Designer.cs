namespace ProyectoWF {
    partial class FormularioPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.msOpcionesFormPrincipal = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbProveedores = new System.Windows.Forms.ToolStripButton();
            this.tsbProductos = new System.Windows.Forms.ToolStripButton();
            this.tsbEmpleados = new System.Windows.Forms.ToolStripButton();
            this.tsbPedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tssUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExpandir = new System.Windows.Forms.ToolStripButton();
            this.tsbRetraer = new System.Windows.Forms.ToolStripButton();
            this.splitter = new System.Windows.Forms.Splitter();
            this.tvSecciones = new System.Windows.Forms.TreeView();
            this.msOpcionesFormPrincipal.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOpcionesFormPrincipal
            // 
            this.msOpcionesFormPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.pedidosToolStripMenuItem,
            this.ventanasToolStripMenuItem});
            this.msOpcionesFormPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msOpcionesFormPrincipal.MdiWindowListItem = this.ventanasToolStripMenuItem;
            this.msOpcionesFormPrincipal.Name = "msOpcionesFormPrincipal";
            this.msOpcionesFormPrincipal.Size = new System.Drawing.Size(1429, 24);
            this.msOpcionesFormPrincipal.TabIndex = 0;
            this.msOpcionesFormPrincipal.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(62, 20);
            this.fileMenu.Text = "Maestro";
            this.fileMenu.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.empleadoToolStripMenuItem.Text = "Empleados";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.agenciasToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(69, 20);
            this.editMenu.Text = "Auxiliares";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // agenciasToolStripMenuItem
            // 
            this.agenciasToolStripMenuItem.Name = "agenciasToolStripMenuItem";
            this.agenciasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.agenciasToolStripMenuItem.Text = "Agencias";
            this.agenciasToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            this.ventanasToolStripMenuItem.Click += new System.EventHandler(this.msOpcionesFormPrincipal_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClientes,
            this.tsbProveedores,
            this.tsbProductos,
            this.tsbEmpleados,
            this.tsbPedidos,
            this.toolStripSeparator1,
            this.tsbSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1429, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsbClientes
            // 
            this.tsbClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClientes.Image = global::ProyectoWF.Properties.Resources.if_icon_person_stalker_211873__1_;
            this.tsbClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClientes.Name = "tsbClientes";
            this.tsbClientes.Size = new System.Drawing.Size(23, 22);
            this.tsbClientes.Text = "toolStripButton1";
            this.tsbClientes.ToolTipText = "Abrir clientes";
            this.tsbClientes.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbProveedores
            // 
            this.tsbProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProveedores.Image = global::ProyectoWF.Properties.Resources.if_074_ArchieveBox_183203__1_;
            this.tsbProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProveedores.Name = "tsbProveedores";
            this.tsbProveedores.Size = new System.Drawing.Size(23, 22);
            this.tsbProveedores.Text = "toolStripButton3";
            this.tsbProveedores.ToolTipText = "Abrir proveedores";
            this.tsbProveedores.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbProductos
            // 
            this.tsbProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProductos.Image = global::ProyectoWF.Properties.Resources.if__p_copy_2560347__1_;
            this.tsbProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductos.Name = "tsbProductos";
            this.tsbProductos.Size = new System.Drawing.Size(23, 22);
            this.tsbProductos.Text = "toolStripButton1";
            this.tsbProductos.ToolTipText = "Abrir productos";
            this.tsbProductos.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbEmpleados
            // 
            this.tsbEmpleados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmpleados.Image = global::ProyectoWF.Properties.Resources.if__e_2560315;
            this.tsbEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmpleados.Name = "tsbEmpleados";
            this.tsbEmpleados.Size = new System.Drawing.Size(23, 22);
            this.tsbEmpleados.Text = "toolStripButton2";
            this.tsbEmpleados.ToolTipText = "Abrir empleados";
            this.tsbEmpleados.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbPedidos
            // 
            this.tsbPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPedidos.Image = global::ProyectoWF.Properties.Resources.icons8_windows_8_finance_purchase_order_8;
            this.tsbPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPedidos.Name = "tsbPedidos";
            this.tsbPedidos.Size = new System.Drawing.Size(23, 22);
            this.tsbPedidos.Text = "toolStripButton1";
            this.tsbPedidos.ToolTipText = "Abrir pedidos";
            this.tsbPedidos.Click += new System.EventHandler(this.tsb_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::ProyectoWF.Properties.Resources.if_icons_exit2_1564506;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "toolStripButton4";
            this.tsbSalir.ToolTipText = "Salir del programa";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tssUsuario
            // 
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tssUsuario.Size = new System.Drawing.Size(134, 17);
            this.tssUsuario.Text = "Has iniciado sesión con ";
            this.tssUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUsuario,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 851);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1429, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "Cerrar sesión";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExpandir,
            this.tsbRetraer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(32, 802);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExpandir
            // 
            this.tsbExpandir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExpandir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExpandir.Image")));
            this.tsbExpandir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExpandir.Name = "tsbExpandir";
            this.tsbExpandir.Size = new System.Drawing.Size(29, 20);
            this.tsbExpandir.Text = "toolStripButton2";
            this.tsbExpandir.ToolTipText = "Expandir menú";
            this.tsbExpandir.Click += new System.EventHandler(this.tsbExpandir_Click);
            // 
            // tsbRetraer
            // 
            this.tsbRetraer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRetraer.Image = ((System.Drawing.Image)(resources.GetObject("tsbRetraer.Image")));
            this.tsbRetraer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRetraer.Name = "tsbRetraer";
            this.tsbRetraer.Size = new System.Drawing.Size(29, 20);
            this.tsbRetraer.Text = "toolStripButton3";
            this.tsbRetraer.ToolTipText = "Esconder menú";
            this.tsbRetraer.Click += new System.EventHandler(this.tsbRetraer_Click);
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(32, 49);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(132, 802);
            this.splitter.TabIndex = 10;
            this.splitter.TabStop = false;
            // 
            // tvSecciones
            // 
            this.tvSecciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvSecciones.Location = new System.Drawing.Point(24, 49);
            this.tvSecciones.Name = "tvSecciones";
            this.tvSecciones.Size = new System.Drawing.Size(121, 802);
            this.tvSecciones.TabIndex = 11;
            this.tvSecciones.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSecciones_NodeMouseDoubleClick);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 873);
            this.Controls.Add(this.tvSecciones);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.msOpcionesFormPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msOpcionesFormPrincipal;
            this.Name = "FormularioPrincipal";
            this.Text = "MDIParent1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrincipal_FormClosing);
            this.msOpcionesFormPrincipal.ResumeLayout(false);
            this.msOpcionesFormPrincipal.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip msOpcionesFormPrincipal;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuario;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExpandir;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.TreeView tvSecciones;
        private System.Windows.Forms.ToolStripButton tsbRetraer;
        private System.Windows.Forms.ToolStripButton tsbClientes;
        private System.Windows.Forms.ToolStripButton tsbPedidos;
        private System.Windows.Forms.ToolStripButton tsbProductos;
        private System.Windows.Forms.ToolStripButton tsbEmpleados;
        private System.Windows.Forms.ToolStripButton tsbProveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}



