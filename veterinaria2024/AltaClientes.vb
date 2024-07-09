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
End Class