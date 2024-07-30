Public Class AltaClientes
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtApellido.Enabled = True
        TxtNombre.Enabled = True
        TxtDni.Enabled = True
        TxtTelefono.Enabled = True
        TxtDireccion.Enabled = True
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
        BtnCancelar.Enabled = True

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtApellido.Enabled = False
        TxtApellido.Text = ""
        TxtNombre.Enabled = False
        TxtNombre.Text = ""
        TxtDni.Enabled = False
        TxtDni.Text = ""
        TxtTelefono.Enabled = False
        TxtTelefono.Text = ""
        TxtDireccion.Enabled = False
        TxtDireccion.Text = ""
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        BtnCancelar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'agrego un nuevo cliente a la lista de clientes del formulario veterinaria
        Dim cliente As New Clientes
        cliente.Dni = TxtDni.Text
        cliente.Apellido = TxtApellido.Text
        cliente.Nombre = TxtNombre.Text
        cliente.Direccion = TxtDireccion.Text
        cliente.Telefono = TxtTelefono.Text
        veterinaria.clientes.Add(cliente)
        'agrego el cliente a la grilla
        DgvClientes.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre, cliente.Direccion, cliente.Telefono)
        'guardar los datos en el archivo de clientes.csv
        Dim sw As New System.IO.StreamWriter("clientes.csv")
        For Each clienteitem As Clientes In veterinaria.clientes
            sw.WriteLine(clienteitem.Dni & ";" & clienteitem.Apellido & ";" & clienteitem.Nombre & ";" & clienteitem.Direccion & ";" & clienteitem.Telefono)
        Next
        sw.Close()



        MsgBox("los datos del cliente se agregaron correctamente")
        TxtDni.Enabled = False
        TxtDni.Clear()
        TxtApellido.Enabled = False
        TxtApellido.Clear()
        TxtNombre.Enabled = False
        TxtNombre.Clear()
        TxtTelefono.Enabled = False
        TxtTelefono.Clear()
        TxtDireccion.Enabled = False
        TxtDireccion.Clear()
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        BtnCancelar.Enabled = False


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        veterinaria.Show()
        Me.Close()

    End Sub

    Private Sub AltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpio la grilla
        DgvClientes.Rows.Clear()
        'cargo los datos de la lista de clientes del formulario veterinaria en la grilla
        For Each cliente As Clientes In veterinaria.clientes
            DgvClientes.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre, cliente.Direccion, cliente.Telefono)
        Next
    End Sub

End Class