Public Class Principal

    Private Sub InsertarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarRegistroToolStripMenuItem.Click

        Dim FrmInsertar As New InsertarRegistro

        FrmInsertar.Show()

    End Sub

    Private Sub ModificarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarRegistroToolStripMenuItem.Click

        Dim FrmModificar As New ModificarRegistro

        FrmModificar.Show()

    End Sub

    Private Sub EliminarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRegistroToolStripMenuItem.Click

        Dim FrmEliminar As New EliminarRegistro

        FrmEliminar.Show()

    End Sub

    Private Sub ListarRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarRegistrosToolStripMenuItem.Click

        Dim FrmListar As New ListarRegistro

        FrmListar.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
