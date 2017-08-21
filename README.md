# Practica de Programación C# con Visual Studio

Realice los siguientes ejercicios de forma auto-guiada:

## PARTE 1 - Correr el proyecto desde Visual Studio 
1. Navegar a la direccion web del proyecto [desde GitHub haciendo click aquí.](https://github.com/stvansolano/PrograII-DotNet/tree/practica)
2. Descargar el codigo de la aplicacion en formato ZIP (Clone or Download -> DOWNLOAD ZIP)
3. Descomprimir el archivo ZIP en el escritorio de Windows.
4. Ubicar el archivo de solucion WindowsApps y abrir desde Visual Studio
5. Establecer el proyecto DesarrolloWindows.CSharp como proyecto de inicio (click derecho en DesarrolloWindows.CSharp y dar click en "Establecer como proyecto de arranque")
6. Click en "Run", "Iniciar" para correr el proyecto

## PARTE 2 - Implementar formularios de Clientes y Productos en el proyecto C#
1. Utilizar la plantilla de Visual Studio de Windows Forms (Click derecho en DesarrolloWindows.CSharp -> Agregar nuevo elemento -> Windows Form)
2. Agregar 2 nuevos formularios de Windows llamados FormularioProductos.cs y FormularioClientes.cs
3. Completar ambos formularios haciendo uso del control *DataGridView* desde la Caja de herramientas en Visual Studio y un control de tipo *boton (Button)* que se encargará de traer la información de la base de datos.
4. Hacer click en el boton *(Button)* del paso anterior y cambiar la propiedad Texto a *"Conectar"* en la ventana de *Propiedades* (click derecho al control -> *Propiedades* -> *Texto*)
4. Hacer click en el *DataGridView* y nombrarlo como *DataGridFormulario* desde la ventana de Propiedades (click derecho al control -> Propiedades -> Nombre).
5. Desde el *FormularioPrincipal.cs* invoque los formularios desde el Menu->Clientes (*MenuStrip* en el Diseñador) como en el ejemplo a continuación:

`var ventana = new FormularioClientes();`

`ventana.MdiParent = this;`

`ventana.Show();`

5. Realice lo anterior para invocar el FormularioProductos desde el FormularioPrincipal         

## PARTE 3 - Conexión a base de datos remota
1. Desde el formulario de Clientes, declare un miembro de la clase DataTable llamado *"_dataTable"* con el modificador de acceso *private*.
3. En la clase FormularioClientes, añada la referencias a los paquetes *System.Data* de la siguiente manera, justo antes del *namespace*:

`using System.Data;`

`using System.Data.SqlClient;`

`// Justo antes de `

`//namespace DesarrolloWindows.CSharp {...`

4. Desde la vista de Diseño del formulario de Clientes, haga doble-click en el botón de "Conectar" introducido anteriormente e incluya el código a continuación en el evento Click (generado con el doble-click): 

`var cadena = "Server=tcp:sqlprogra2azure.database.windows.net,1433;Initial Catalog=SQLprogra2Azure;Persist Security Info=False;User ID=sqladmin;Password=12345abC;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";`

`var conexion = new SqlConnection(cadena);`

`var comando = conexion.CreateCommand();`

`comando.CommandText = "SELECT Nombre, PrimerApellido, SegundoApellido, Telefono FROM Clientes";`

`conexion.Open();`

`var adaptador = new SqlDataAdapter(comando);`

`// Llenado offline con DataTable para uso posterior en 1 sola llamada`

`_dataTable = new DataTable();`

`adaptador.Fill(_dataTable);`

`conexion.Close();`

`DataGridFormulario.DataSource = _dataTable;`

5. Realice el mismo paso para el Formulario de Productos e implemente la consulta para la tabla "Productos"

## PARTE 4 - Inserción de Datos

Realice una insercion de Datos para la tabla *Cliente* utilizando el SQL a continuación desde el formulario correspondiente:

`INSERT INTO Clientes (Nombre, PrimerApellido, SegundoApellido, Telefono) VALUES ('Gustavo', 'Meneses', 'Cespedes', '555-5555');`

1. Añada etiquetas para los siguientes campos:

- Nombre
- Primer Apellido
- Segundo Apellido

2. Añada controles *TextBox* en el formulario de Clientes y nombrelos de la siguiente manera:

- textBoxNombre
- textBoxPrimerApellido
- textBoxSegundoApellido
- textBoxTelefono

3. Añada un boton de "Guardar" al formulario. Haga doble-click en el boton e implemente la siguiente concatenación:

`var sql = "INSERT INTO Clientes (Nombre, PrimerApellido, SegundoApellido, Telefono) VALUES ";`

`sql += "('" + textBoxNombre.Text + "',";`

`sql += "'" + textBoxPrimerApellido.Text + "',";`

`sql += "'" + textBoxSegundoApellido.Text + "',";`

`sql += "'" + textBoxTelefono.Text + "')";`

4. Posterior a la concatenación realice los siguientes llamados como parte del click de guardado:

`comando.CommandText = sql;`

`conexion.Open();`

`comando.ExecuteScalar();`

`conexion.Close();`

5. Realice lo anterior para la tabla de Productos considerando los siguientes campos:

## PARTE 5 - Borrado de datos

1. Investigue la sentencia *DELETE FROM* de SQL e implemente un boton que permita borrar registros segun el Id las tablas *Cliente* y *Producto*. Tenga en cuenta que ambas tablas contienen un campo-identificador llamado "Id" (único, auto-numérico)