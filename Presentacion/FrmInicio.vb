Public Class FrmInicio

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AgregarSociosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarSociosToolStripMenuItem.Click
        FrmIndexar_socios.ShowDialog()
    End Sub
End Class
