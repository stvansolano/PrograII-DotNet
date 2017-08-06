Imports System.Data.SqlClient

Public Class FormularioPrincipal

    Public Sub ConectarBaseDeDatos()
        Dim cadena As String = "Server=tcp:sqlprogra2azure.database.windows.net,1433;Initial Catalog=SQLprogra2Azure;Persist Security Info=False;User ID=sqladmin;Password=12345abC;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

        Dim conexion = New SqlConnection(cadena)

        Dim comando = conexion.CreateCommand
        comando.CommandText = "SELECT Nombre, PrimerApellido FROM Clientes"

        'Open the connection.
        conexion.Open()

        Dim myReader = comando.ExecuteReader()

        Do While myReader.Read()
            Dim resultado = myReader.GetString(0) & " " & myReader.GetString(1) & vbLf

            Console.WriteLine(resultado)
        Loop

        myReader.Close()
        conexion.Close()

    End Sub

    Private Sub botonConectar_Click(sender As Object, e As EventArgs) Handles botonConectar.Click
        ConectarBaseDeDatos()
    End Sub
End Class
