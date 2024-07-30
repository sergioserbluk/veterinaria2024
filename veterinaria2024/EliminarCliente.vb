Public Class EliminarCliente
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick


    End Sub

    Private Sub EliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpio la grilla
        DgvClientes.Rows.Clear()
        'cargo los datos de la lista de clientes del formulario veterinaria en la grilla
        For Each cliente As Clientes In veterinaria.clientes
            DgvClientes.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre, cliente.Direccion, cliente.Telefono)
        Next

    End Sub


    Private Sub DgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellClick
        'selecciono la fila y cargo los datos en los textbox
        Dim fila As Integer
        fila = DgvClientes.CurrentCell.RowIndex
        TxtDni.Text = DgvClientes(0, fila).Value
        TxtApellido.Text = DgvClientes(1, fila).Value
        TxtNombre.Text = DgvClientes(2, fila).Value
        TxtDireccion.Text = DgvClientes(3, fila).Value
        TxtTelefono.Text = DgvClientes(4, fila).Value
    End Sub

    Private Sub BtnEliminar_Click_1(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'pido confirmacion para eliminar el cliente
        If MsgBox("esta seguro que desea eliminar el cliente?", vbYesNo) = vbNo Then
            Exit Sub
        End If
        'elimino el cliente seleccionado de la lista de clientes del formulario veterinaria
        For Each cliente As Clientes In veterinaria.clientes
            If cliente.Dni = TxtDni.Text Then
                veterinaria.clientes.Remove(cliente)
                Exit For
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
        MsgBox("los datos del cliente se eliminaron correctamente")
        TxtDni.Clear()
        TxtApellido.Enabled = False
        TxtApellido.Clear()
        TxtNombre.Enabled = False
        TxtNombre.Clear()
        TxtTelefono.Enabled = False
        TxtTelefono.Clear()
        TxtDireccion.Enabled = False
        TxtDireccion.Clear()
        BtnEliminar.Enabled = False
    End Sub
End Class