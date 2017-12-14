namespace ProyectoWF
{
    partial class FormularioProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.tlPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosP = new System.Windows.Forms.GroupBox();
            this.tlPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.lbStock = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdProducto = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.gbDirección = new System.Windows.Forms.GroupBox();
            this.tlOtrosDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbBorrarFoto = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.btBuscarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btBorrarFoto = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbObligatorio = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tlPrincipal.SuspendLayout();
            this.gbDatosP.SuspendLayout();
            this.tlPersonales.SuspendLayout();
            this.gbDirección.SuspendLayout();
            this.tlOtrosDatos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPrincipal
            // 
            this.tlPrincipal.ColumnCount = 2;
            this.tlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPrincipal.Controls.Add(this.gbDatosP, 0, 0);
            this.tlPrincipal.Controls.Add(this.gbDirección, 1, 0);
            this.tlPrincipal.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tlPrincipal.Controls.Add(this.lbObligatorio, 0, 1);
            this.tlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlPrincipal.Name = "tlPrincipal";
            this.tlPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tlPrincipal.RowCount = 2;
            this.tlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlPrincipal.Size = new System.Drawing.Size(684, 281);
            this.tlPrincipal.TabIndex = 0;
            // 
            // gbDatosP
            // 
            this.gbDatosP.Controls.Add(this.tlPersonales);
            this.gbDatosP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDatosP.Location = new System.Drawing.Point(15, 15);
            this.gbDatosP.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.gbDatosP.Name = "gbDatosP";
            this.gbDatosP.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.gbDatosP.Size = new System.Drawing.Size(290, 226);
            this.gbDatosP.TabIndex = 0;
            this.gbDatosP.TabStop = false;
            this.gbDatosP.Text = "Datos del producto";
            // 
            // tlPersonales
            // 
            this.tlPersonales.ColumnCount = 3;
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlPersonales.Controls.Add(this.lbStock, 0, 3);
            this.tlPersonales.Controls.Add(this.tbCantidad, 1, 1);
            this.tlPersonales.Controls.Add(this.lbCantidad, 0, 1);
            this.tlPersonales.Controls.Add(this.tbNombre, 1, 0);
            this.tlPersonales.Controls.Add(this.label1, 2, 0);
            this.tlPersonales.Controls.Add(this.lbIdProducto, 0, 0);
            this.tlPersonales.Controls.Add(this.lbPrecio, 0, 2);
            this.tlPersonales.Controls.Add(this.tbPrecio, 1, 2);
            this.tlPersonales.Controls.Add(this.tbStock, 1, 3);
            this.tlPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersonales.Location = new System.Drawing.Point(10, 18);
            this.tlPersonales.Name = "tlPersonales";
            this.tlPersonales.RowCount = 4;
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonales.Size = new System.Drawing.Size(275, 198);
            this.tlPersonales.TabIndex = 0;
            // 
            // lbStock
            // 
            this.lbStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(3, 166);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(35, 13);
            this.lbStock.TabIndex = 10;
            this.lbStock.Text = "Stock";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCantidad.Location = new System.Drawing.Point(58, 63);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(186, 20);
            this.tbCantidad.TabIndex = 1;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(3, 67);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(40, 13);
            this.lbCantidad.TabIndex = 9;
            this.lbCantidad.Text = "Cant/u";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(58, 14);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(186, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(250, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIdProducto
            // 
            this.lbIdProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbIdProducto.AutoSize = true;
            this.lbIdProducto.Location = new System.Drawing.Point(3, 18);
            this.lbIdProducto.Name = "lbIdProducto";
            this.lbIdProducto.Size = new System.Drawing.Size(44, 13);
            this.lbIdProducto.TabIndex = 7;
            this.lbIdProducto.Text = "Nombre";
            // 
            // lbPrecio
            // 
            this.lbPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(3, 116);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 13);
            this.lbPrecio.TabIndex = 11;
            this.lbPrecio.Text = "Precio/u";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecio.Location = new System.Drawing.Point(58, 112);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(186, 20);
            this.tbPrecio.TabIndex = 2;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbStock
            // 
            this.tbStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStock.Location = new System.Drawing.Point(58, 162);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(186, 20);
            this.tbStock.TabIndex = 3;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // gbDirección
            // 
            this.gbDirección.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDirección.Controls.Add(this.tlOtrosDatos);
            this.gbDirección.Location = new System.Drawing.Point(320, 15);
            this.gbDirección.Margin = new System.Windows.Forms.Padding(15, 15, 6, 0);
            this.gbDirección.Name = "gbDirección";
            this.gbDirección.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.gbDirección.Size = new System.Drawing.Size(352, 226);
            this.gbDirección.TabIndex = 1;
            this.gbDirección.TabStop = false;
            this.gbDirección.Text = "Otros datos";
            // 
            // tlOtrosDatos
            // 
            this.tlOtrosDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlOtrosDatos.ColumnCount = 2;
            this.tlOtrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlOtrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlOtrosDatos.Controls.Add(this.lbProveedor, 0, 0);
            this.tlOtrosDatos.Controls.Add(this.cbProveedor, 1, 0);
            this.tlOtrosDatos.Controls.Add(this.lbCategoria, 0, 1);
            this.tlOtrosDatos.Controls.Add(this.cbCategoria, 1, 1);
            this.tlOtrosDatos.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlOtrosDatos.Location = new System.Drawing.Point(3, 18);
            this.tlOtrosDatos.Name = "tlOtrosDatos";
            this.tlOtrosDatos.RowCount = 3;
            this.tlOtrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlOtrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlOtrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlOtrosDatos.Size = new System.Drawing.Size(324, 195);
            this.tlOtrosDatos.TabIndex = 1;
            // 
            // lbProveedor
            // 
            this.lbProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(3, 17);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(56, 13);
            this.lbProveedor.TabIndex = 5;
            this.lbProveedor.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(67, 13);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(254, 21);
            this.cbProveedor.TabIndex = 4;
            // 
            // lbCategoria
            // 
            this.lbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(3, 65);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(54, 13);
            this.lbCategoria.TabIndex = 9;
            this.lbCategoria.Text = "Categoría";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(67, 61);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(254, 21);
            this.cbCategoria.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlOtrosDatos.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.18239F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.94969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.86793F));
            this.tableLayoutPanel1.Controls.Add(this.tbBorrarFoto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbFoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBuscarFoto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbFoto, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBorrarFoto, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 93);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tbBorrarFoto
            // 
            this.tbBorrarFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbBorrarFoto.AutoSize = true;
            this.tbBorrarFoto.Location = new System.Drawing.Point(3, 63);
            this.tbBorrarFoto.Name = "tbBorrarFoto";
            this.tbBorrarFoto.Size = new System.Drawing.Size(35, 13);
            this.tbBorrarFoto.TabIndex = 13;
            this.tbBorrarFoto.Text = "Borrar";
            // 
            // lbFoto
            // 
            this.lbFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(3, 16);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(28, 13);
            this.lbFoto.TabIndex = 10;
            this.lbFoto.Text = "Foto";
            // 
            // btBuscarFoto
            // 
            this.btBuscarFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBuscarFoto.Location = new System.Drawing.Point(63, 12);
            this.btBuscarFoto.Name = "btBuscarFoto";
            this.btBuscarFoto.Size = new System.Drawing.Size(25, 22);
            this.btBuscarFoto.TabIndex = 6;
            this.btBuscarFoto.Text = "...";
            this.btBuscarFoto.UseVisualStyleBackColor = true;
            this.btBuscarFoto.Click += new System.EventHandler(this.btBuscarFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(101, 3);
            this.pbFoto.Name = "pbFoto";
            this.tableLayoutPanel1.SetRowSpan(this.pbFoto, 2);
            this.pbFoto.Size = new System.Drawing.Size(214, 87);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // btBorrarFoto
            // 
            this.btBorrarFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBorrarFoto.BackgroundImage = global::ProyectoWF.Properties.Resources.eliminar_cancelar_icono_4935_128;
            this.btBorrarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBorrarFoto.Location = new System.Drawing.Point(63, 58);
            this.btBorrarFoto.Name = "btBorrarFoto";
            this.btBorrarFoto.Size = new System.Drawing.Size(25, 22);
            this.btBorrarFoto.TabIndex = 7;
            this.btBorrarFoto.UseVisualStyleBackColor = true;
            this.btBorrarFoto.Click += new System.EventHandler(this.btBorrarFoto_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btAceptar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btCancelar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(308, 244);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(289, 3);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 9;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(208, 3);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbObligatorio
            // 
            this.lbObligatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbObligatorio.AutoSize = true;
            this.lbObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lbObligatorio.Location = new System.Drawing.Point(25, 254);
            this.lbObligatorio.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.lbObligatorio.Name = "lbObligatorio";
            this.lbObligatorio.Size = new System.Drawing.Size(104, 13);
            this.lbObligatorio.TabIndex = 3;
            this.lbObligatorio.Text = "*   Campo obligatorio";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 

            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(684, 281);
            this.Controls.Add(this.tlPrincipal);
            this.Name = "FormularioProductos";
            this.Text = "Alta de Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioProductos_FormClosing);
            this.tlPrincipal.ResumeLayout(false);
            this.tlPrincipal.PerformLayout();
            this.gbDatosP.ResumeLayout(false);
            this.tlPersonales.ResumeLayout(false);
            this.tlPersonales.PerformLayout();
            this.gbDirección.ResumeLayout(false);
            this.tlOtrosDatos.ResumeLayout(false);
            this.tlOtrosDatos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPrincipal;
        private System.Windows.Forms.GroupBox gbDatosP;
        private System.Windows.Forms.Label lbObligatorio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TableLayoutPanel tlPersonales;
        private System.Windows.Forms.GroupBox gbDirección;
        private System.Windows.Forms.TableLayoutPanel tlOtrosDatos;
        private System.Windows.Forms.Label lbIdProducto;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Button btBuscarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label tbBorrarFoto;
        private System.Windows.Forms.Button btBorrarFoto;

    }
}