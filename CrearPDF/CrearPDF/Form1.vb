Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Form1

    Private Sub crearpdfbtn_Click(sender As Object, e As EventArgs) Handles crearpdfbtn.Click
        'Vamos a encontrar la ruta donde guardar el pdf
        'Muestro el SaveFileDialog y guardo el contenido del PDF
        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String
        With SaveFileDialog
            .Title = "Guardar"
            'Selecciono la ruta de generación por defecto
            'En todo los demás casos uso la ruta por defecto
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Archivos pdf (*.pdf|*.pdf"
            .FileName = "Archivo"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With

        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
            Exit Sub
        End If
        'Vamos a generar el pdf
        Try
            'Creamos un documento
            Dim document As New iTextSharp.text.Document(PageSize.A4)

            'ahora configuramos la hoja
            document.PageSize.Rotate()

            'ahora algunas propiedades
            document.AddTitle("Crear PDF")

            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New System.IO.FileStream(ruta, System.IO.FileMode.Create))
            'con esto conseguimos que el documento sea presentado como pagina simple
            writer.ViewerPreferences = PdfWriter.PageLayoutSinglePage
            'abrimos el documento para empezar a escribir
            document.Open()

            'empezamos definiendo el tipo de letra y vamos a añadir contenido
            Dim cb As PdfContentByte = writer.DirectContent
            Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
            cb.SetFontAndSize(bf, 10)
            cb.BeginText()

            'datos
            cb.SetTextMatrix(50, 700)
            cb.ShowText("Datos: " & Me.datostxt.Text)

            cb.EndText()
            'y lo cerramos
            document.Close()

        Catch ex As Exception
            MessageBox.Show("Error en la generación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

   

End Class
