using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace app.videoclub
{
    public partial class formNuevaConexion : MetroForm

    {
        //public cPrincipalVC principal;
        formPrincipalAdmonConexion admonCo;

        public formNuevaConexion()//cPrincipalVC principal)
        {
            InitializeComponent();
            //this.principal = principal;
            mCmbMotor.SelectedIndex = 0;
           
        }


        /// <summary>
        /// Boton de aceptar para realizar una nueva conexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion con = new conexion();

               
                string id = txtConexion.Text;
                string servidor = txtServidor.Text;
                string basedatos = txtBD.Text;
                bool aunW = cbAunWin.Checked;
                string usr = txtUsuario.Text;
                string pwd = txtContrasena.Text;

                manejador manejador = new manejador();

                if (manejador.agregarConexion(id, servidor, basedatos, aunW, usr, pwd))
                {
                    MessageBox.Show("se agrego la conexion correctamente");
                    DialogResult = DialogResult.OK;
                    admonCo = new formPrincipalAdmonConexion();
                    ((ListBox)admonCo.Controls["LbConexiones"]).DataSource = manejador.obtenerConexiones();

                    Close();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbAunWin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAunWin.Checked)
            {
               txtUsuario.Enabled = false;
               txtContrasena.Enabled = false;
            }
            else
            {
                
                txtUsuario.Enabled = true;
                txtContrasena.Enabled = true;
            }
        }
        /// <summary>
        /// Boton cancelar del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("¿Esta seguro que desea cancelar?", "Atención",
            //       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    DialogResult = DialogResult.Cancel;
            //}
            this.Close();
            
        }

       

        private void mBtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    validar();
                }
                catch (Exception ex) { mostrarAdvertencia(ex.Message); return; }

                conexion con = new conexion();


                string id = txtConexion.Text;
                string servidor = txtServidor.Text;
                string basedatos = txtBD.Text;
                bool aunW = cbAunWin.Checked;
                string usr = txtUsuario.Text;
                string pwd = txtContrasena.Text;

                manejador manejador = new manejador();

                if (manejador.agregarConexion(id, servidor, basedatos, aunW, usr, pwd))
                {
                    //MessageBox.Show("se agrego la conexion correctamente");
                    MetroMessageBox.Show(this, "Se agrego la conexión correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    admonCo = new formPrincipalAdmonConexion();
                    ((ListBox)admonCo.Controls["LbConexiones"]).DataSource = manejador.obtenerConexiones();

                    Close();
                }

            }
            catch (Exception ex) { mostrarError(ex.Message); }//MessageBox.Show(ex.Message); }
        }

        public void validar()
        {
            if (string.IsNullOrEmpty(txtConexion.Text))
                throw new Exception("Ingrese el nombre de la conexión.");
        }

        public void mostrarAdvertencia(string error)
        {
            MetroMessageBox.Show(this, error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void mostrarError(string error)
        {
            MetroMessageBox.Show(this, error, "Oops!! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtUsuario_EnabledChanged(object sender, EventArgs e)
        {
            if (!((MetroFramework.Controls.MetroTextBox)sender).Enabled)
                ((MetroFramework.Controls.MetroTextBox)sender).BackColor = System.Drawing.Color.Silver;
            else
                ((MetroFramework.Controls.MetroTextBox)sender).BackColor = System.Drawing.Color.White;
        }


        private void cbAunWin_MouseEnter(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroCheckBox)sender).ForeColor = System.Drawing.Color.Black;
        }

        private void txtContrasena_EnabledChanged(object sender, EventArgs e)
        {
            if (((MetroFramework.Controls.MetroTextBox)sender).Enabled)
                ((MetroFramework.Controls.MetroTextBox)sender).BackColor = Color.White;
            else
                ((MetroFramework.Controls.MetroTextBox)sender).BackColor = Color.Silver;
        }

       
    }
}
