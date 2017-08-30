<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gboxdatos = New System.Windows.Forms.GroupBox()
        Me.datoslbl = New System.Windows.Forms.Label()
        Me.datostxt = New System.Windows.Forms.TextBox()
        Me.crearpdfbtn = New System.Windows.Forms.Button()
        Me.gboxdatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxdatos
        '
        Me.gboxdatos.Controls.Add(Me.crearpdfbtn)
        Me.gboxdatos.Controls.Add(Me.datostxt)
        Me.gboxdatos.Controls.Add(Me.datoslbl)
        Me.gboxdatos.Location = New System.Drawing.Point(13, 13)
        Me.gboxdatos.Name = "gboxdatos"
        Me.gboxdatos.Size = New System.Drawing.Size(480, 126)
        Me.gboxdatos.TabIndex = 0
        Me.gboxdatos.TabStop = False
        Me.gboxdatos.Text = "Datos"
        '
        'datoslbl
        '
        Me.datoslbl.AutoSize = True
        Me.datoslbl.Location = New System.Drawing.Point(7, 20)
        Me.datoslbl.Name = "datoslbl"
        Me.datoslbl.Size = New System.Drawing.Size(38, 13)
        Me.datoslbl.TabIndex = 0
        Me.datoslbl.Text = "Datos:"
        '
        'datostxt
        '
        Me.datostxt.Location = New System.Drawing.Point(51, 20)
        Me.datostxt.Name = "datostxt"
        Me.datostxt.Size = New System.Drawing.Size(175, 20)
        Me.datostxt.TabIndex = 1
        '
        'crearpdfbtn
        '
        Me.crearpdfbtn.Location = New System.Drawing.Point(399, 54)
        Me.crearpdfbtn.Name = "crearpdfbtn"
        Me.crearpdfbtn.Size = New System.Drawing.Size(75, 23)
        Me.crearpdfbtn.TabIndex = 2
        Me.crearpdfbtn.Text = "Crear PDF"
        Me.crearpdfbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 193)
        Me.Controls.Add(Me.gboxdatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gboxdatos.ResumeLayout(False)
        Me.gboxdatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents crearpdfbtn As System.Windows.Forms.Button
    Friend WithEvents datostxt As System.Windows.Forms.TextBox
    Friend WithEvents datoslbl As System.Windows.Forms.Label

End Class
