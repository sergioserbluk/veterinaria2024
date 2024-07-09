Public Class login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim usValido = "admin"
        Dim passValido = "admin"
        If TxtUs.Text = usValido And TxtPass.Text = passValido Then
            veterinaria.ClientesToolStripMenuItem.Enabled = True
            veterinaria.MascotasToolStripMenuItem.Enabled = True
            veterinaria.ProductosToolStripMenuItem.Enabled = True
            veterinaria.VentasToolStripMenuItem.Enabled = True
            veterinaria.LoginToolStripMenuItem.Text = "cerrar sesion"
            veterinaria.RegistrarseToolStripMenuItem.Enabled = False
            veterinaria.Show()
            Me.Close()
        Else
            MsgBox("Usuario o contraseña incorrectos")
            TxtPass.Clear()
            TxtUs.Clear()
            TxtUs.Focus()
        End If
    End Sub
End Class