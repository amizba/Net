<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgendaPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendaPersonalToolStripMenuItem, Me.ListarRegistrosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(621, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgendaPersonalToolStripMenuItem
        '
        Me.AgendaPersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarRegistroToolStripMenuItem, Me.ModificarRegistroToolStripMenuItem, Me.EliminarRegistroToolStripMenuItem})
        Me.AgendaPersonalToolStripMenuItem.Name = "AgendaPersonalToolStripMenuItem"
        Me.AgendaPersonalToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.AgendaPersonalToolStripMenuItem.Text = "Agenda Personal"
        '
        'InsertarRegistroToolStripMenuItem
        '
        Me.InsertarRegistroToolStripMenuItem.Name = "InsertarRegistroToolStripMenuItem"
        Me.InsertarRegistroToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.InsertarRegistroToolStripMenuItem.Text = "Insertar Registro"
        '
        'ModificarRegistroToolStripMenuItem
        '
        Me.ModificarRegistroToolStripMenuItem.Name = "ModificarRegistroToolStripMenuItem"
        Me.ModificarRegistroToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModificarRegistroToolStripMenuItem.Text = "Modificar Registro"
        '
        'EliminarRegistroToolStripMenuItem
        '
        Me.EliminarRegistroToolStripMenuItem.Name = "EliminarRegistroToolStripMenuItem"
        Me.EliminarRegistroToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EliminarRegistroToolStripMenuItem.Text = "Eliminar Registro"
        '
        'ListarRegistrosToolStripMenuItem
        '
        Me.ListarRegistrosToolStripMenuItem.Name = "ListarRegistrosToolStripMenuItem"
        Me.ListarRegistrosToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ListarRegistrosToolStripMenuItem.Text = "Listar Registros"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Agenda Personal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgendaPersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarRegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
