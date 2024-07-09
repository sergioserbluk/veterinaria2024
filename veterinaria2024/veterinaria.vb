Public Class veterinaria
    Private Sub veterinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.ShowDialog()
    End Sub

    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        AltaClientes.ShowDialog()
    End Sub
End Class
