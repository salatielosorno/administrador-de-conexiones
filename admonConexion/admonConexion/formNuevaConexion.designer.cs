namespace app.videoclub
{
    partial class formNuevaConexion
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
            this.mBtnAceptar = new MetroFramework.Controls.MetroButton();
            this.mBtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mCmbMotor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtConexion = new MetroFramework.Controls.MetroTextBox();
            this.txtServidor = new MetroFramework.Controls.MetroTextBox();
            this.txtBD = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.cbAunWin = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mBtnAceptar
            // 
            this.mBtnAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mBtnAceptar.Location = new System.Drawing.Point(82, 352);
            this.mBtnAceptar.Name = "mBtnAceptar";
            this.mBtnAceptar.Size = new System.Drawing.Size(95, 33);
            this.mBtnAceptar.Style = MetroFramework.MetroColorStyle.Black;
            this.mBtnAceptar.TabIndex = 7;
            this.mBtnAceptar.Text = "Aceptar";
            this.mBtnAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnAceptar.UseCustomBackColor = true;
            this.mBtnAceptar.UseSelectable = true;
            this.mBtnAceptar.UseStyleColors = true;
            this.mBtnAceptar.Click += new System.EventHandler(this.mBtnAceptar_Click);
            // 
            // mBtnCancelar
            // 
            this.mBtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mBtnCancelar.Location = new System.Drawing.Point(206, 352);
            this.mBtnCancelar.Name = "mBtnCancelar";
            this.mBtnCancelar.Size = new System.Drawing.Size(95, 33);
            this.mBtnCancelar.Style = MetroFramework.MetroColorStyle.Black;
            this.mBtnCancelar.TabIndex = 8;
            this.mBtnCancelar.Text = "Cancelar";
            this.mBtnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnCancelar.UseCustomBackColor = true;
            this.mBtnCancelar.UseSelectable = true;
            this.mBtnCancelar.UseStyleColors = true;
            this.mBtnCancelar.Click += new System.EventHandler(this.mBtnCancelar_Click);
            // 
            // mCmbMotor
            // 
            this.mCmbMotor.BackColor = System.Drawing.Color.White;
            this.mCmbMotor.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mCmbMotor.FormattingEnabled = true;
            this.mCmbMotor.ItemHeight = 19;
            this.mCmbMotor.Items.AddRange(new object[] {
            "SQL Server"});
            this.mCmbMotor.Location = new System.Drawing.Point(123, 68);
            this.mCmbMotor.Name = "mCmbMotor";
            this.mCmbMotor.Size = new System.Drawing.Size(178, 25);
            this.mCmbMotor.TabIndex = 0;
            this.mCmbMotor.UseCustomBackColor = true;
            this.mCmbMotor.UseSelectable = true;
            this.mCmbMotor.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(22, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Motor:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Conexión:";
            // 
            // txtConexion
            // 
            this.txtConexion.BackColor = System.Drawing.Color.White;
            this.txtConexion.Lines = new string[0];
            this.txtConexion.Location = new System.Drawing.Point(123, 109);
            this.txtConexion.MaxLength = 255;
            this.txtConexion.Name = "txtConexion";
            this.txtConexion.PasswordChar = '\0';
            this.txtConexion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConexion.SelectedText = "";
            this.txtConexion.Size = new System.Drawing.Size(178, 25);
            this.txtConexion.TabIndex = 1;
            this.txtConexion.UseCustomBackColor = true;
            this.txtConexion.UseSelectable = true;
            this.txtConexion.UseStyleColors = true;
            // 
            // txtServidor
            // 
            this.txtServidor.BackColor = System.Drawing.Color.White;
            this.txtServidor.Lines = new string[0];
            this.txtServidor.Location = new System.Drawing.Point(123, 145);
            this.txtServidor.MaxLength = 255;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServidor.SelectedText = "";
            this.txtServidor.Size = new System.Drawing.Size(178, 25);
            this.txtServidor.TabIndex = 2;
            this.txtServidor.UseCustomBackColor = true;
            this.txtServidor.UseSelectable = true;
            this.txtServidor.UseStyleColors = true;
            // 
            // txtBD
            // 
            this.txtBD.BackColor = System.Drawing.Color.White;
            this.txtBD.Lines = new string[0];
            this.txtBD.Location = new System.Drawing.Point(123, 183);
            this.txtBD.MaxLength = 255;
            this.txtBD.Name = "txtBD";
            this.txtBD.PasswordChar = '\0';
            this.txtBD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBD.SelectedText = "";
            this.txtBD.Size = new System.Drawing.Size(178, 25);
            this.txtBD.TabIndex = 3;
            this.txtBD.UseCustomBackColor = true;
            this.txtBD.UseSelectable = true;
            this.txtBD.UseStyleColors = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(123, 257);
            this.txtUsuario.MaxLength = 255;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(178, 25);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.UseCustomBackColor = true;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.UseStyleColors = true;
            this.txtUsuario.EnabledChanged += new System.EventHandler(this.txtUsuario_EnabledChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(123, 291);
            this.txtContrasena.MaxLength = 255;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.Size = new System.Drawing.Size(178, 25);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.UseCustomBackColor = true;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.UseStyleColors = true;
            this.txtContrasena.EnabledChanged += new System.EventHandler(this.txtContrasena_EnabledChanged);
            // 
            // cbAunWin
            // 
            this.cbAunWin.AutoSize = true;
            this.cbAunWin.BackColor = System.Drawing.Color.White;
            this.cbAunWin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAunWin.Location = new System.Drawing.Point(127, 226);
            this.cbAunWin.Name = "cbAunWin";
            this.cbAunWin.Size = new System.Drawing.Size(170, 15);
            this.cbAunWin.TabIndex = 4;
            this.cbAunWin.Text = "Autentificación de windows";
            this.cbAunWin.UseSelectable = true;
            this.cbAunWin.CheckedChanged += new System.EventHandler(this.cbAunWin_CheckedChanged);
            this.cbAunWin.MouseEnter += new System.EventHandler(this.cbAunWin_MouseEnter);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Servidor:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Base de datos:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 256);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Usuario:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 291);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Contraseña:";
            // 
            // formNuevaConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 406);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbAunWin);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.txtConexion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mCmbMotor);
            this.Controls.Add(this.mBtnCancelar);
            this.Controls.Add(this.mBtnAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "formNuevaConexion";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Nueva Conexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnAceptar;
        private MetroFramework.Controls.MetroButton mBtnCancelar;
        private MetroFramework.Controls.MetroComboBox mCmbMotor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtConexion;
        private MetroFramework.Controls.MetroTextBox txtServidor;
        private MetroFramework.Controls.MetroTextBox txtBD;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroCheckBox cbAunWin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}