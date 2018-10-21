using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;
using System.Data;

namespace app.videoclub
{
    /// <summary>
    /// Clase que provee la funcionalidad necesaria para manipular el archivo de conexiones.
    /// </summary>
    public class manejador
    {
        formPrincipalAdmonConexion formularioPadre;
        int tiempoHilo = 100;

        public manejador()
        {

        }
        public manejador(formPrincipalAdmonConexion bar)
        {
            this.formularioPadre = bar;
        }

        /// <summary>
        /// Permite agregar una conexión.
        /// </summary>
        /// <param name="id">Identificador de la conexión.</param>
        /// <param name="servidor">Servidor de base de datos.</param>
        /// <param name="baseDeDatos">Nombre de la base de datos.</param>
        /// <param name="autentificacionWindows">Autentificación de Windows</param>
        /// <param name="usuario">Usuario. En caso de requerirlo.</param>
        /// <param name="contrasenia">Contraseña. En caso de requerirlo.</param>
        /// <returns>True en caso de éxito. False en caso contrario.</returns>
        public bool agregarConexion(string id, string servidor, string baseDeDatos, bool autentificacionWindows, string usuario = "", string contrasenia = "")
        {
            try
            {
                if (!(System.IO.Directory.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft"))))
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft"));

                if (existeXMLConfiguracion())
                {
                    if (idRepetido(id))
                        throw new Exception("Nombre de conexión ya en uso.");

                    return agregarNuevaConexion(id, servidor, baseDeDatos, autentificacionWindows, usuario, contrasenia);
                }

                XmlDocument doc = new XmlDocument();

                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

                doc.AppendChild(dec);

                XmlElement raiz = doc.CreateElement("conexiones");

                XmlElement econexion = doc.CreateElement("conexion");

                econexion.SetAttribute("id", id);
                econexion.SetAttribute("servidor", servidor);
                econexion.SetAttribute("usuario", usuario);
                econexion.SetAttribute("contrasenia", contrasenia);
                econexion.SetAttribute("bd", baseDeDatos);
                econexion.SetAttribute("autWin", autentificacionWindows.ToString());

                raiz.AppendChild(econexion);

                doc.AppendChild(raiz);

                doc.Normalize();

                doc.Save(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"));
                return true;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>True en caso de existir. False en caso contrario.</returns>
        public bool existeXMLConfiguracion()
        {
            try
            {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")))
                    return true;
                return false;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Permite eliminar una conexión.
        /// </summary>
        /// <param name="id">Identificador de la conexión.</param>
        /// <returns>True en caso de éxito. False en caso contrario.</returns>
        public bool eliminarConexion(string id)
        {
            try
            {
                XmlDocument docVC = new XmlDocument();
                docVC.LoadXml(System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")));

                XmlElement raiz = docVC.DocumentElement;

                foreach (XmlNode nodo in raiz)
                {
                    XmlAttributeCollection atributos = nodo.Attributes;
                    if (atributos["id"].Value.Equals(id))
                    {
                        raiz.RemoveChild(nodo);
                        return guardarXML(docVC);
                    }
                }

                return false;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Permite obtener las conexiones configuradas.
        /// </summary>
        /// <returns>Conexiones existentes.</returns>
        public IEnumerable<string> obtenerConexiones()
        {
            try
            {
                if (!(System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"))))
                    throw new Exception("No existe un documento de configuración.");

                XmlDocument docVC = new XmlDocument();
                docVC.LoadXml(System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")));

                List<string> conexiones = new List<string>();

                foreach (XmlElement elemento in docVC.DocumentElement)
                {
                    conexiones.Add(elemento.GetAttribute("id"));
                }

                return conexiones;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Permite iniciar una conexión.
        /// </summary>
        /// <param name="id">identificador de la conexión.</param>
        /// <returns>Objeto IDbConnection con la conexión abierta.</returns>
        public IDbConnection iniciarConexion(string id)
        {
            try
            {
                return iniciarConexion(obtenerConexion(id));
            }
            catch (Exception) { throw; }

        }

        /// <summary>
        /// Permite agregar una nueva conexión.
        /// </summary>
        /// <param name="id">Identificador de la conexión.</param>
        /// <param name="servidor">Servidor de base de datos.</param>
        /// <param name="baseDeDatos">Nombre de la base de datos.</param>
        /// <param name="autentificacionWindows">Autentificación de Windows</param>
        /// <param name="usuario">Usuario.</param>
        /// <param name="contrasenia">Contraseña.</param>
        /// <returns>True en caso de éxito. False en caso contrario.</returns>
        private bool agregarNuevaConexion(string id, string servidor, string baseDeDatos, bool autentificacionWindows,string usuario, string contrasenia)
        {
            try
            {
                XmlDocument docVC = new XmlDocument();
                docVC.LoadXml(System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")));

                XmlElement raiz = docVC.DocumentElement;

                XmlElement econexion = docVC.CreateElement("conexion");

                econexion.SetAttribute("id", id);
                econexion.SetAttribute("servidor", servidor);
                econexion.SetAttribute("usuario", usuario);
                econexion.SetAttribute("contrasenia", contrasenia);
                econexion.SetAttribute("bd", baseDeDatos);
                econexion.SetAttribute("autWin", autentificacionWindows.ToString());

                raiz.AppendChild(econexion).Normalize();

                docVC.Normalize();

                return guardarXML(docVC);
            }
            catch (Exception) { throw; }
        } 

        /// <summary>
        /// Permite guardar un XML con las conexiones.
        /// </summary>
        /// <param name="documento">Documento XML a guardar o actualizar.</param>
        /// <returns>True en caso de éxito. False en caso contrario.</returns>
        private bool guardarXML(XmlDocument documento)
        {
            try
            {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml")))
                    System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml"));

                System.IO.File.Copy(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"),
                    System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml")
                    );

                System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"));

                documento.Save(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"));

                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml")))
                    System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml"));

                return true;
            }
            catch (Exception) {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")))
                    System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"));

                System.IO.File.Copy(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml"),
                    System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")
                    );

                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml")))
                    System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg_res.xml"));

                throw;
            }
        }

        /// <summary>
        /// Permite iniciar una conexión.
        /// </summary>
        /// <param name="oConexion">Objeto conexion. Contiene los datos de conexión y los utiliza para crear la base de datos cuando es la primera vez que se conecta.</param>
        /// <returns></returns>
        private IDbConnection iniciarConexion(conexion oConexion)
        {
            formularioPadre.metroLabel1.Text = "Estableciendo conexión con la base de datos!.....";
            formularioPadre.metroLabel1.Refresh();

            IDbConnection conexion;

            string cadenaConexion = "";

            if (oConexion.autWindows)
                cadenaConexion = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True", oConexion.server, oConexion.db);
            else
                cadenaConexion = string.Format("data source = {0}; initial catalog = {1}; user id = {2}; password = {3}", oConexion.server, oConexion.db, oConexion.user, oConexion.pwd);

            if (conectar(cadenaConexion))
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                formularioPadre.metroLabel1.Text = "Conexión establecida con éxito!...";
                formularioPadre.metroLabel1.Refresh();

                //progreso del 100%
                while (formularioPadre.metroProgressBar1.Value < 100)
                    formularioPadre.metroProgressBar1.PerformStep();
                //formularioPadre.metroProgressBar1.Increment((100 - formularioPadre.metroProgressBar1.Value)); 
                //formularioPadre.metroProgressBar1.PerformStep();

                return conexion ;
            }

            if (oConexion.autWindows)
                cadenaConexion = string.Format("Data Source = {0}; Initial Catalog = master; Integrated Security = True", oConexion.server);
            else
                cadenaConexion = string.Format("data source = {0}; initial catalog = master; user id = {1}; password = {2}", oConexion.server, oConexion.user, oConexion.pwd);

            conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            #region
            this.formularioPadre.metroLabel1.Text = "Conexión establecida con éxito!...";
            this.formularioPadre.metroLabel1.Refresh();
            //Progreso al 20%
            formularioPadre.metroProgressBar1.PerformStep();
            #endregion

            try
            {
                formularioPadre.metroLabel1.Text = "Preparando para el primer uso!...";
                formularioPadre.metroLabel1.Refresh();

                IDbCommand cmd = conexion.CreateCommand();
                cmd.CommandText = string.Format("CREATE DATABASE {0}", oConexion.db);

                formularioPadre.metroLabel1.Text = cmd.CommandText;
                formularioPadre.metroLabel1.Refresh();

                cmd.ExecuteNonQuery();

                //Progreso al 30%
                formularioPadre.metroProgressBar1.PerformStep();

                string[] script = System.IO.File.ReadAllLines(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "mssql.sql"));

                #region
                int cantidadLineas = script.Length;

                double porcentajeAumentar = (100 - formularioPadre.metroProgressBar1.Value) / cantidadLineas;

                porcentajeAumentar = porcentajeAumentar >= 1 ? porcentajeAumentar : 1;
                #endregion

                using (IDbTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        IDbCommand comando = conexion.CreateCommand();

                        comando.Transaction = transaccion;

                        //string[] script = System.IO.File.ReadAllLines(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "mssql.sql"));
                        
                        conexion.ChangeDatabase(oConexion.db);

                        foreach (string comand in script)
                        {
                            if (string.IsNullOrEmpty(comand))
                                continue;
                            comando.CommandText = comand;

                            formularioPadre.metroLabel1.Text = comando.CommandText;
                            formularioPadre.metroLabel1.Refresh();

                            comando.ExecuteNonQuery();

                            formularioPadre.metroProgressBar1.Increment(Convert.ToInt32(porcentajeAumentar));
                        }

                        transaccion.Commit();
                    }
                    catch (Exception ex) { transaccion.Rollback(); throw new Exception(string.Format("No se pudo crear la base de datos. {0}", ex.Message)); }
                }

                formularioPadre.metroProgressBar1.PerformStep();
                #region
                formularioPadre.metroLabel1.Text = "Listo!...";
                formularioPadre.metroLabel1.Refresh();                
                #endregion

                return conexion;
            }
            catch (Exception ex) {
                conexion.ChangeDatabase("master");
                IDbCommand comandoRollback = conexion.CreateCommand();
                comandoRollback.CommandText = string.Format("DROP DATABASE {0}", oConexion.db);
                comandoRollback.ExecuteNonQuery(); 
                throw new Exception(string.Format("Ocurrió un problema al iniciar la conexión. {0}", ex.Message));
            }
        }

        /// <summary>
        /// Enlazar la base de datos.
        /// </summary>
        /// <param name="cadenaConexion">Cadena con los datos de conexión</param>
        /// <returns>Retorna true en caso de éxito. Excepción ocurrida.</returns>
        private bool conectar(string cadenaConexion)
        {
            try
            {
                IDbConnection conexion;
                conexion = new SqlConnection(cadenaConexion);
                
                conexion.Open();

                conexion.Close();
                return true;
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Permite obtener un objeto conexion (admonConexion).
        /// </summary>
        /// <param name="id">Identificador de la conexión.</param>
        /// <returns>objeto conexion.</returns>
        private conexion obtenerConexion(string id)
        {
            try
            {
                formularioPadre.metroLabel1.Text = "Obteniendo datos de conexión...";
                formularioPadre.metroLabel1.Refresh();

                if (!(System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"))))
                    throw new Exception("No existe un documento de configuración.");

                XmlDocument docVC = new XmlDocument();
                docVC.LoadXml(System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")));

                //string cadenaConexion = "";
                conexion conexion = null;

                foreach (XmlElement elemento in docVC.DocumentElement)
                {
                    XmlAttributeCollection atributos = elemento.Attributes;

                    if (elemento.GetAttribute("id").Equals(id))
                    {
                        conexion = new conexion();
                        conexion.id = elemento.GetAttribute("id");
                        conexion.server = elemento.GetAttribute("servidor");
                        conexion.db = elemento.GetAttribute("bd");
                        conexion.user = elemento.GetAttribute("usuario");
                        conexion.pwd = elemento.GetAttribute("contrasenia");
                        conexion.autWindows = Convert.ToBoolean(elemento.GetAttribute("autWin"));
                    }
                }

                if (conexion == null)
                    throw new Exception("No se encontró la conexión.");

                formularioPadre.metroLabel1.Text = "Datos obtenidos exitosamente!...";
                formularioPadre.metroLabel1.Refresh();

                //progreso del 10%
                formularioPadre.metroProgressBar1.PerformStep();

                return conexion;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Determina si se ha creado una conexion con el id que esta por utilizar el usuario.
        /// </summary>
        /// <param name="id">Identificador de la conexión.</param>
        /// <returns>True en caso de estar repetido el identificador. False en caso contrario.</returns>
        private bool idRepetido(string id)
        {
            try
            {
                if (!(System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml"))))
                    throw new Exception("No existe un documento de configuración.");

                XmlDocument docVC = new XmlDocument();
                docVC.LoadXml(System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VCSoft", "VCfg.xml")));

                foreach (XmlElement elemento in docVC.DocumentElement)
                {
                    XmlAttributeCollection atributos = elemento.Attributes;

                    if (elemento.GetAttribute("id").Equals(id))
                        return true;
                }

                return false;
            }
            catch (Exception) { throw; }
        }
       
    }
}
