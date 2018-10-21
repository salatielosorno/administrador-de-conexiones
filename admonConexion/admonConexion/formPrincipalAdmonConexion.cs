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
    public partial class formPrincipalAdmonConexion : MetroForm
    {
        private IDbConnection con;

        public IDbConnection conexion
        {
            get { return con; }
        }
        //public cPrincipalVC principal;
        //formLogin formLogin;
        formNuevaConexion formNC;
        //region de la progress bar

        
        public formPrincipalAdmonConexion()
        {
            InitializeComponent();
            metroProgressBar1.Visible = false;
            metroProgressBar1.Maximum = 100;
            metroProgressBar1.Step = 10;
            metroProgressBar1.Value = 0;
            metroLabel1.Text = string.Empty;
        }

        private void btnNuevaConexion_Click(object sender, EventArgs e)
        {
            formNC = new formNuevaConexion();//principal);
            formNC.ShowDialog();           
        }
        
        private void formPrincipalAdmonConexion_Load(object sender, EventArgs e)
        {
            manejador oManejador = new manejador();


            if (oManejador.existeXMLConfiguracion())
                LbConexiones.DataSource = oManejador.obtenerConexiones();
        }
        /// <summary>
        /// Boton para eliminar una conexión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                string id = LbConexiones.SelectedItem.ToString();

                if (id == "")
                {
                    MessageBox.Show("seleccione una conexión");
                }
                else
                {
                   // DialogResult result = MessageBox.Show("¿Esta seguro de eliminar la conexión?", "Atención",
                    //MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    DialogResult result = MetroMessageBox.Show(this, "¿Esta seguro de eliminar la conexión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        manejador omanejador = new manejador();
                        omanejador.eliminarConexion(id);
                        //MessageBox.Show("la conexón se elimino correctamente");
                        MetroMessageBox.Show(this, "La conexión fue eliminada exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        omanejador.obtenerConexiones();
                    }
                }
            }
            catch (Exception ex) { mostrarError(ex.Message); }
        }

        private void mBtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = LbConexiones.SelectedItem.ToString();
                if (id == "")
                {
                }
                else
                {
                    metroProgressBar1.Visible = true;

                    metroLabel1.Text = "Preparando para uso";
                    metroLabel1.Refresh();

                    manejador manejador = new manejador(this);
                    con = manejador.iniciarConexion(id);
                    //principal = new cPrincipalVC(con);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }


            }
            catch (Exception ex)
            {
                metroProgressBar1.Visible = false;
                metroProgressBar1.Maximum = 100;
                metroProgressBar1.Step = 10;
                metroProgressBar1.Value = 0;
                metroLabel1.Text = string.Empty;
                metroLabel1.Refresh();
                mostrarError(ex.Message);
            }
        }

        private void mBtnNueva_Click(object sender, EventArgs e)
        {
            formNC = new formNuevaConexion();//principal);
            formNC.ShowDialog();
            manejador omanejador = new manejador();
            LbConexiones.DataSource = omanejador.obtenerConexiones();
        }

        private void mBtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = LbConexiones.SelectedItem.ToString();

                if (id == "")
                {
                   // MessageBox.Show("seleccione una conexión");
                }
                else
                {
                    DialogResult result = MetroMessageBox.Show(this, "¿Esta seguro de eliminar la conexión?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //MessageBox.Show("¿Esta seguro de eliminar la conexión?", "Atención",
                    //MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        manejador omanejador = new manejador();
                        omanejador.eliminarConexion(id);
                       // MessageBox.Show("la conexón se elimino correctamente");
                        MetroMessageBox.Show(this, "La conexión se elimino correctamente", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //omanejador.obtenerConexiones();
                        LbConexiones.DataSource = omanejador.obtenerConexiones();
                    }
                }
            }
            catch (Exception ex) { mostrarError(ex.Message); }
        }

        public void mostrarAdvertencia(string error)
        {
            MetroMessageBox.Show(this, error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void mostrarError(string error)
        {
            MetroMessageBox.Show(this, error, "Oops!! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void formPrincipalAdmonConexion_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    var backgroundWorker1 = sender as BackgroundWorker;
        //    while(pProgreso < 100)
        //    {
        //        System.Threading.Thread.Sleep(100);
        //        backgroundWorker1.ReportProgress(progreso);
        //    }
        //}

        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    metroProgressBar1.Value = e.ProgressPercentage;
        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    metroProgressBar1.Value = pProgreso;
        //}
    }
}
