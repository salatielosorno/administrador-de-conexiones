using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.videoclub
{
    /// <summary>
    /// Clase que representa los datos necesarios para crear una cadena de conexión.
    /// </summary>
    public class conexion
    {
        /// <summary>
        /// Identificador de la conexión.
        /// </summary>
        public string id{ get; set; }
        
        /// <summary>
        /// Nombre de la base de datos.
        /// </summary>
        public string db { get; set; }

        /// <summary>
        /// Usuario.
        /// </summary>
        public string user { get; set; }

        /// <summary>
        /// Contraseña.
        /// </summary>
        public string pwd { get; set; }

        /// <summary>
        /// Servidor de base de datos.
        /// </summary>
        public string server { get; set; }

        /// <summary>
        /// Autentificación de windows
        /// </summary>
        public bool autWindows { get; set; }
    }
}
