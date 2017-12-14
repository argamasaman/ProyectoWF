namespace ProyectoWF
{
    partial class FrmListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoClientes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPaís = new System.Windows.Forms.Label();
            this.lbCompañia = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbCP = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 673);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPaís);
            this.groupBox1.Controls.Add(this.lbCompañia);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.txtCompañia);
            this.groupBox1.Controls.Add(this.txtCP);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lbCP);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(124, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda avanzada";
            // 
            // lbPaís
            // 
            this.lbPaís.AutoSize = true;
            this.lbPaís.Location = new System.Drawing.Point(367, 81);
            this.lbPaís.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbPaís.Name = "lbPaís";
            this.lbPaís.Size = new System.Drawing.Size(35, 17);
            this.lbPaís.TabIndex = 19;
            this.lbPaís.Text = "País";
            this.lbPaís.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCompañia
            // 
            this.lbCompañia.AutoSize = true;
            this.lbCompañia.Location = new System.Drawing.Point(367, 32);
            this.lbCompañia.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbCompañia.Name = "lbCompañia";
            this.lbCompañia.Size = new System.Drawing.Size(71, 17);
            this.lbCompañia.TabIndex = 18;
            this.lbCompañia.Text = "Compañia";
            this.lbCompañia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(440, 78);
            this.txtPais.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(239, 22);
            this.txtPais.TabIndex = 17;
            this.txtPais.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // txtCompañia
            // 
            this.txtCompañia.Location = new System.Drawing.Point(440, 28);
            this.txtCompañia.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(239, 22);
            this.txtCompañia.TabIndex = 16;
            this.txtCompañia.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(84, 78);
            this.txtCP.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(239, 22);
            this.txtCP.TabIndex = 15;
            this.txtCP.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 22);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Location = new System.Drawing.Point(17, 81);
            this.lbCP.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(26, 17);
            this.lbCP.TabIndex = 13;
            this.lbCP.Text = "CP";
            this.lbCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(17, 32);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btNuevo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btModificar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBorrar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCerrar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btFiltrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btNuevo
            // 
            this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btNuevo.Image = global::ProyectoWF.Properties.Resources.nuevo;
            this.btNuevo.Location = new System.Drawing.Point(982, 16);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(30, 23);
            this.btNuevo.TabIndex = 0;
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btModificar.Image = global::ProyectoWF.Properties.Resources.editar;
            this.btModificar.Location = new System.Drawing.Point(1038, 16);
            this.btModificar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(30, 23);
            this.btModificar.TabIndex = 1;
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBorrar.Image = global::ProyectoWF.Properties.Resources.eliminar;
            this.btBorrar.Location = new System.Drawing.Point(1094, 16);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(30, 23);
            this.btBorrar.TabIndex = 2;
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(1094, 629);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 32);
            this.btCerrar.TabIndex = 3;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Location = new System.Drawing.Point(13, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 537);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btFiltrar.Image")));
            this.btFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFiltrar.Location = new System.Drawing.Point(13, 12);
            this.btFiltrar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(152, 32);
            this.btFiltrar.TabIndex = 0;
            this.btFiltrar.Text = "Abrir búsqueda";
            this.btFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "FrmListadoClientes";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPaís;
        private System.Windows.Forms.Label lbCompañia;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCompañia;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.Label lbNombre;
    }
}

