Public Class veterinaria
    'creo una lista de clientes, con los clientes cargados en un archivo de texto
    Public clientes As New List(Of Clientes)

    Private Sub veterinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'abro el archivo de clientes.csv y cargo los datos en la lista de clientes(si el archivo no existe lo creo vacio)
        If System.IO.File.Exists("clientes.csv") = False Then
            Dim sw As New System.IO.StreamWriter("clientes.csv")
            sw.Close()
        End If
        Dim sr As New System.IO.StreamReader("clientes.csv")
        Do While sr.Peek() >= 0
            Dim linea As String = sr.ReadLine()
            Dim datos() As String = linea.Split(";")
            Dim cliente As New Clientes
            cliente.Dni = datos(0)
            cliente.Apellido = datos(1)
            cliente.Nombre = datos(2)
            cliente.Direccion = datos(3)
            cliente.Telefono = datos(4)
            clientes.Add(cliente)
        Loop
        sr.Close()
    End Sub


    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.ShowDialog()
    End Sub

    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        AltaClientes.ShowDialog()
    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionesToolStripMenuItem.Click
        ModificacionesClientes.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'salgo de la aplicacion
        Me.Close()

    End Sub

    Private Sub BajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasToolStripMenuItem.Click
        EliminarCliente.ShowDialog()

    End Sub
End Class
