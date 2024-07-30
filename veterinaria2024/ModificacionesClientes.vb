Public Class ModificacionesClientes
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        veterinaria.Show()
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        TxtApellido.Enabled = True
        TxtNombre.Enabled = True
        TxtTelefono.Enabled = True
        TxtDireccion.Enabled = True
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        BtnCancelar.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtApellido.Enabled = False
        TxtApellido.Text = ""
        TxtNombre.Enabled = False
        TxtNombre.Text = ""
        TxtDni.Text = ""
        TxtTelefono.Enabled = False
        TxtTelefono.Text = ""
        TxtDireccion.Enabled = False
        TxtDireccion.Text = ""
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnCancelar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'modifico los datos del cliente seleccionado
        For Each clientemodificar As Clientes In veterinaria.clientes
            If clientemodificar.Dni = TxtDni.Text Then
                clientemodificar.Apellido = TxtApellido.Text
                clientemodificar.Nombre = TxtNombre.Text
                clientemodificar.Direccion = TxtDireccion.Text
                clientemodificar.Telefono = TxtTelefono.Text
            End If
        Next
        'limpio la grilla
        DgvClientes.Rows.Clear()
        'cargo los datos de la lista de clientes del formulario veterinaria en la grilla
        For Each cliente As Clientes In veterinaria.clientes
            DgvClientes.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre, cliente.Direccion, cliente.Telefono)
        Next
        'guardar los datos en el archivo de clientes.csv
        Dim sw As New System.IO.StreamWriter("clientes.csv")
        For Each clienteitem As Clientes In veterinaria.clientes
            sw.WriteLine(clienteitem.Dni & ";" & clienteitem.Apellido & ";" & clienteitem.Nombre & ";" & clienteitem.Direccion & ";" & clienteitem.Telefono)
        Next
        sw.Close()


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
        BtnModificar.Enabled = True
        BtnCancelar.Enabled = False
        MsgBox("los datos del cliente se agregaron correctamente")
    End Sub

    Private Sub ModificacionesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpio la grilla
        DgvClientes.Rows.Clear()
        'cargo los datos de la lista de clientes del formulario veterinaria en la grilla
        For Each cliente As Clientes In veterinaria.clientes
            DgvClientes.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre, cliente.Direccion, cliente.Telefono)
        Next

    End Sub

    Private Sub ModificacionesClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick
        'cargo los datos del cliente seleccionado en los textbox
        TxtDni.Text = DgvClientes.CurrentRow.Cells(0).Value
        TxtApellido.Text = DgvClientes.CurrentRow.Cells(1).Value
        TxtNombre.Text = DgvClientes.CurrentRow.Cells(2).Value
        TxtDireccion.Text = DgvClientes.CurrentRow.Cells(3).Value
        TxtTelefono.Text = DgvClientes.CurrentRow.Cells(4).Value

    End Sub

    Private Sub DgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellClick
        'cargo los datos del cliente seleccionado en los textbox
        TxtDni.Text = DgvClientes.CurrentRow.Cells(0).Value
        TxtApellido.Text = DgvClientes.CurrentRow.Cells(1).Value
        TxtNombre.Text = DgvClientes.CurrentRow.Cells(2).Value
        TxtDireccion.Text = DgvClientes.CurrentRow.Cells(3).Value
        TxtTelefono.Text = DgvClientes.CurrentRow.Cells(4).Value
    End Sub
End Class