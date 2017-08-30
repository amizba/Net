Imports System.Data.OleDb
Public Class ModificarRegistro

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ModificarRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Interface_Entrada()
    End Sub
    Private Sub Interface_Entrada()
        lblNombre.Enabled = False
        txtNombre.Enabled = False
        lblDireccion.Enabled = False
        txtDireccion.Enabled = False
        lblMovil.Enabled = False
        txtMovil.Enabled = False
        btnModificar.Enabled = False

    End Sub

    Private Sub Interface_Datos()
        lblNombre.Enabled = True
        txtNombre.Enabled = True
        lblDireccion.Enabled = True
        txtDireccion.Enabled = True
        lblMovil.Enabled = True
        txtMovil.Enabled = True
        btnModificar.Enabled = True

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Buscar_Registro(txtId.Text) = False Then

            MessageBox.Show("El registro no ya existe")
            txtId.Focus()

        Else
            Interface_Datos()
            txtNombre.Focus()

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Modificar_Registros(txtId.Text, txtNombre.Text, txtDireccion.Text, txtMovil.Text)
        Interface_Entrada()
        txtId.Focus()
        Limpiar_Formulario()
    End Sub
    Private Sub Limpiar_Formulario()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtMovil.Clear()
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
    Function Modificar_Registros(ByVal Id As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Movil As String) As Boolean
        'convertir String a integer

        Dim cod As Integer = Convert.ToInt32(Id)
        Dim mov As Integer = Convert.ToInt32(Movil)

        'conexión a la base de datos

        Dim Conexion As New OleDbConnection

        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Documents\ActividadesVB\Proyecto EjemploBBDD\Agenda.accdb; Persist Security Info=False"

        'instrucción SQL

        Dim CadenaSQL As String = "UPDATE Personas SET "
        CadenaSQL = CadenaSQL + " nombre = '" & Nombre & "',"
        CadenaSQL = CadenaSQL + " direccion = '" & Direccion & "',"
        CadenaSQL = CadenaSQL + " movil = " & mov & ""
        CadenaSQL = CadenaSQL + " WHERE id = " & cod

        'crear comando

        Dim Comando As OleDbCommand = Conexion.CreateCommand()
        Comando.CommandText = CadenaSQL

        'ejecutar la consulta de acción

        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
        Return True
    End Function

    
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class