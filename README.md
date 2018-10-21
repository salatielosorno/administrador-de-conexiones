# Administrador de conexiones
Este es un administrador de conexiones que fue realizado para ser utilizado por cualquier aplicación que requiera de un formulario para configurar la conexión a base de datos, se genera como DLL para ser referenciado en cualquier proyecto windows form. It made in 2015.

# Implementación

### Creamos un objeto del formulario principal del Administrador de conexiones
formPrincipalAdmonConexion admonConexion = new formPrincipalAdmonConexion();

### Lanzamos el formulario
admonConexion.ShowDialog();

### Esperamos la respuesta del cuadro de dialogo
if (admonConexion.DialogResult == DialogResult.OK)

### Si la respuesta es OK, el objeto tendrá en su propiedad "conexion" la cadena de conexion para la aplicación que la usará*/
  cPrincipalVC principal = new cPrincipalVC(admonConexion.conexion);

# Documentación
En la carpeta documentacion se encuentra un documento breve que describe como fue planeada la funcionalidad de esta DLL.

# Componentes de terceros
Este componente hace uso de MetroFramework: https://thielj.github.io/MetroFramework/
