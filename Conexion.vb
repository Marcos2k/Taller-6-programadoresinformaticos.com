Imports System.Data.OleDb
Public Class Conexion
    'Esta clase maneja la conexion entre la base de datos y el programa
    Protected Cadena As String = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=Gimnasio.mdb"
    Protected Conector As New OleDbConnection

    Public Function Conectar()
        Try
            Conector = New OleDbConnection(Cadena)
            Conector.Open() 'Abre y se conecta a la base de datos
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectar()
        Try
            If Conector.State = ConnectionState.Open Then 'Pregunta si la BD esta abierta, si lo esta la cierra
                Conector.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
