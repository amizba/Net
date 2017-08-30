Imports System.Data.OleDb
Public Class EliminarRegistro

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub EliminarRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Interface_Entrada()
    End Sub
    Private Sub Interface_Entrada()

        lblNombre.Enabled = False
        txtNombre.Enabled = False
        lblDireccion.Enabled = False
        txtDireccion.Enabled = False
        lblMovil.Enabled = False
        txtMovil.Enabled = False


    End Sub
  

    Private Sub Limpiar_Formulario()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtMovil.Clear()
    End Sub

    Private Sub Interface_Datos()
        lblNombre.Enabled = True
        txtNombre.Enabled = True
        lblDireccion.Enabled = True
        txtDireccion.Enabled = True
        lblMovil.Enabled = True
        txtMovil.Enabled = True


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Buscar_Registro(txtId.Text) = True Then

            Dim Respuesta As DialogResult = MessageBox.Show("¿Esta seguro que desea eliminar este Registro?", "Eliminar", MessageBoxButtons.YesNo)

            If Respuesta = Windows.Forms.DialogResult.Yes Then
                Eliminar_Registros(txtId.Text)
                Limpiar_Formulario()
                txtId.Focus()

            Else
                Limpiar_Formulario()
                txtId.Focus()
            End If

        Else
            MessageBox.Show("El registro no existe")
            txtId.Focus()
        End If

    End Sub

 
    Function Buscar_Registro(ByVal xId As String) As Boolean

        'Paso 1: Convertir cadena a numérico

        Dim Id As Double
        Id = Convert.ToInt32(xId)

        'Paso 2: Conexión

        Dim Conexion As New OleDbConnection

        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Documents\ActividadesVB\Proyecto EjemploBBDD\Agenda.accdb; Persist Security Info=False"


        'Paso 3: Cadena SQL

        Dim CadenaSQL As String = "SELECT * FROM Personas WHERE id = " & Id

        'Paso 4: Adaptador

        Dim Adaptador As New OleDbDataAdapter(CadenaSQL, Conexion)

        'Paso 5: Data set

        Dim Ds As New DataSet

        'Paso 6: Rellenar el Data set

        Conexion.Open()
        Adaptador.Fill(Ds)
        Conexion.Close()


        'Paso 7: Contar registro

        If (Ds.Tables(0).Rows.Count = 0) Then

            Return False

        Else
            txtNombre.Text = Ds.Tables(0).Rows(0)("Nombre").ToString()
            txtDireccion.Text = Ds.Tables(0).Rows(0)("Direccion").ToString()
            txtMovil.Text = Ds.Tables(0).Rows(0)("Movil").ToString()
            Ds.Dispose()

            Return True
        End If
    End Function
    Function Eliminar_Registros(ByVal Id As String) As Boolean
        'convertir String a integer

        Dim cod As Integer = Convert.ToInt32(Id)


        'conexión a la base de datos

        Dim Conexion As New OleDbConnection

        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Documents\ActividadesVB\Proyecto EjemploBBDD\Agenda.accdb; Persist Security Info=False"

        'instrucción SQL

        Dim CadenaSQL As String = "DELETE FROM personas WHERE id = " & cod
        

        'crear comando

        Dim Comando As OleDbCommand = Conexion.CreateCommand()
        Comando.CommandText = CadenaSQL

        'ejecutar la consulta de acción

        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class