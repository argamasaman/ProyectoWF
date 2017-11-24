namespace ProyectoWF
{
    partial class FrmListadoProductos
    {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butAñadir = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.butBorrar = new System.Windows.Forms.Button();
            this.butCerrar = new System.Windows.Forms.Button();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.busqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(884, 661);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda avanzada";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(87, 63);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(10);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(180, 20);
            this.txtCategoria.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.butAñadir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.butBorrar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.butCerrar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.listaProductos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.busqueda, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // butAñadir
            // 
            this.butAñadir.Image = global::ProyectoWF.Properties.Resources.nuevo;
            this.butAñadir.Location = new System.Drawing.Point(609, 10);
            this.butAñadir.Margin = new System.Windows.Forms.Padding(10);
            this.butAñadir.Name = "butAñadir";
            this.butAñadir.Size = new System.Drawing.Size(75, 32);
            this.butAñadir.TabIndex = 0;
            this.butAñadir.UseVisualStyleBackColor = true;
            // 
            // butEditar
            // 
            this.butEditar.Image = global::ProyectoWF.Properties.Resources.editar;
            this.butEditar.Location = new System.Drawing.Point(704, 10);
            this.butEditar.Margin = new System.Windows.Forms.Padding(10);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(75, 32);
            this.butEditar.TabIndex = 1;
            this.butEditar.UseVisualStyleBackColor = true;
            // 
            // butBorrar
            // 
            this.butBorrar.Image = global::ProyectoWF.Properties.Resources.eliminar;
            this.butBorrar.Location = new System.Drawing.Point(799, 10);
            this.butBorrar.Margin = new System.Windows.Forms.Padding(10);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(75, 32);
            this.butBorrar.TabIndex = 2;
            this.butBorrar.UseVisualStyleBackColor = true;
            this.butBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // butCerrar
            // 
            this.butCerrar.Location = new System.Drawing.Point(799, 505);
            this.butCerrar.Margin = new System.Windows.Forms.Padding(10);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(75, 23);
            this.butCerrar.TabIndex = 3;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.UseVisualStyleBackColor = true;
            // 
            // listaProductos
            // 
            this.listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.listaProductos, 4);
            this.listaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProductos.Location = new System.Drawing.Point(10, 62);
            this.listaProductos.Margin = new System.Windows.Forms.Padding(10);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProductos.Size = new System.Drawing.Size(864, 423);
            this.listaProductos.TabIndex = 4;
            // 
            // busqueda
            // 
            this.busqueda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.busqueda.Image = global::ProyectoWF.Properties.Resources.busqueda;
            this.busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.busqueda.Location = new System.Drawing.Point(10, 10);
            this.busqueda.Margin = new System.Windows.Forms.Padding(10);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(125, 32);
            this.busqueda.TabIndex = 0;
            this.busqueda.Text = "Abrir Busqueda";
            this.busqueda.UseVisualStyleBackColor = true;
            this.busqueda.Click += new System.EventHandler(this.busqueda_Click);
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmListadoProductos";
            this.Text = "Formulario de productos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butAñadir;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.Button butBorrar;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.DataGridView listaProductos;
        private System.Windows.Forms.Button busqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

