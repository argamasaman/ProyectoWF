namespace ProyectoWF
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalir = new System.Windows.Forms.Button();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lErrorUsu = new System.Windows.Forms.Label();
            this.lErrorCon = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // tbSalir
            // 
            this.tbSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tbSalir.Location = new System.Drawing.Point(239, 128);
            this.tbSalir.Name = "tbSalir";
            this.tbSalir.Size = new System.Drawing.Size(75, 23);
            this.tbSalir.TabIndex = 2;
            this.tbSalir.Text = "Salir";
            this.tbSalir.UseVisualStyleBackColor = true;
            this.tbSalir.Click += new System.EventHandler(this.tbSalir_Click);
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.Location = new System.Drawing.Point(140, 128);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(93, 23);
            this.btIniciarSesion.TabIndex = 3;
            this.btIniciarSesion.Text = "Iniciar Sesión";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(118, 52);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(196, 20);
            this.tbUsuario.TabIndex = 4;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(118, 91);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(196, 20);
            this.tbContrasena.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN DE EMPLEADO";
            // 
            // lErrorUsu
            // 
            this.lErrorUsu.AutoSize = true;
            this.lErrorUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorUsu.ForeColor = System.Drawing.Color.Red;
            this.lErrorUsu.Location = new System.Drawing.Point(321, 59);
            this.lErrorUsu.Name = "lErrorUsu";
            this.lErrorUsu.Size = new System.Drawing.Size(13, 16);
            this.lErrorUsu.TabIndex = 7;
            this.lErrorUsu.Text = "*";
            // 
            // lErrorCon
            // 
            this.lErrorCon.AutoSize = true;
            this.lErrorCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorCon.ForeColor = System.Drawing.Color.Red;
            this.lErrorCon.Location = new System.Drawing.Point(320, 98);
            this.lErrorCon.Name = "lErrorCon";
            this.lErrorCon.Size = new System.Drawing.Size(13, 16);
            this.lErrorCon.TabIndex = 8;
            this.lErrorCon.Text = "*";
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(44, 138);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 13);
            this.lError.TabIndex = 9;
            this.lError.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tbSalir;
            this.ClientSize = new System.Drawing.Size(338, 163);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.lErrorCon);
            this.Controls.Add(this.lErrorUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btIniciarSesion);
            this.Controls.Add(this.tbSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbSalir;
        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lErrorUsu;
        private System.Windows.Forms.Label lErrorCon;
        private System.Windows.Forms.Label lError;
    }
}