namespace app.videoclub
{
    partial class formPrincipalAdmonConexion
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
            this.LbConexiones = new System.Windows.Forms.ListBox();
            this.mBtnIniciar = new MetroFramework.Controls.MetroButton();
            this.mBtnNueva = new MetroFramework.Controls.MetroButton();
            this.mBtnEliminar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LbConexiones
            // 
            this.LbConexiones.FormattingEnabled = true;
            this.LbConexiones.Location = new System.Drawing.Point(206, 64);
            this.LbConexiones.Name = "LbConexiones";
            this.LbConexiones.Size = new System.Drawing.Size(220, 173);
            this.LbConexiones.TabIndex = 3;
            // 
            // mBtnIniciar
            // 
            this.mBtnIniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mBtnIniciar.Location = new System.Drawing.Point(437, 64);
            this.mBtnIniciar.Name = "mBtnIniciar";
            this.mBtnIniciar.Size = new System.Drawing.Size(140, 44);
            this.mBtnIniciar.Style = MetroFramework.MetroColorStyle.Black;
            this.mBtnIniciar.TabIndex = 4;
            this.mBtnIniciar.Text = "Iniciar conexión";
            this.mBtnIniciar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnIniciar.UseCustomBackColor = true;
            this.mBtnIniciar.UseSelectable = true;
            this.mBtnIniciar.UseStyleColors = true;
            this.mBtnIniciar.Click += new System.EventHandler(this.mBtnIniciar_Click);
            // 
            // mBtnNueva
            // 
            this.mBtnNueva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mBtnNueva.Location = new System.Drawing.Point(437, 129);
            this.mBtnNueva.Name = "mBtnNueva";
            this.mBtnNueva.Size = new System.Drawing.Size(140, 44);
            this.mBtnNueva.Style = MetroFramework.MetroColorStyle.Black;
            this.mBtnNueva.TabIndex = 5;
            this.mBtnNueva.Text = "Nueva conexión";
            this.mBtnNueva.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnNueva.UseCustomBackColor = true;
            this.mBtnNueva.UseSelectable = true;
            this.mBtnNueva.UseStyleColors = true;
            this.mBtnNueva.Click += new System.EventHandler(this.mBtnNueva_Click);
            // 
            // mBtnEliminar
            // 
            this.mBtnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mBtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mBtnEliminar.Location = new System.Drawing.Point(437, 193);
            this.mBtnEliminar.Name = "mBtnEliminar";
            this.mBtnEliminar.Size = new System.Drawing.Size(140, 44);
            this.mBtnEliminar.Style = MetroFramework.MetroColorStyle.Black;
            this.mBtnEliminar.TabIndex = 6;
            this.mBtnEliminar.Text = "Eliminar conexión";
            this.mBtnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnEliminar.UseCustomBackColor = true;
            this.mBtnEliminar.UseSelectable = true;
            this.mBtnEliminar.UseStyleColors = true;
            this.mBtnEliminar.Click += new System.EventHandler(this.mBtnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::app.videoclub.Properties.Resources.config;
            this.pictureBox1.Location = new System.Drawing.Point(25, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::app.videoclub.Properties.Resources.config;
            this.pictureBox2.Location = new System.Drawing.Point(103, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::app.videoclub.Properties.Resources.config;
            this.pictureBox3.Location = new System.Drawing.Point(51, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 270);
            this.metroLabel1.MaximumSize = new System.Drawing.Size(552, 23);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(552, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(552, 13);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "label1";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(25, 244);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(552, 23);
            this.metroProgressBar1.TabIndex = 14;
            // 
            // formPrincipalAdmonConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 289);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mBtnEliminar);
            this.Controls.Add(this.mBtnNueva);
            this.Controls.Add(this.mBtnIniciar);
            this.Controls.Add(this.LbConexiones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "formPrincipalAdmonConexion";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Administrador de conexiones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPrincipalAdmonConexion_FormClosed);
            this.Load += new System.EventHandler(this.formPrincipalAdmonConexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbConexiones;
        private MetroFramework.Controls.MetroButton mBtnIniciar;
        private MetroFramework.Controls.MetroButton mBtnNueva;
        private MetroFramework.Controls.MetroButton mBtnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label metroLabel1;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}