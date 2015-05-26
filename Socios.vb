Imports System.Data.OleDb
Public Class Socios
    Inherits Conexion 'Hereda la clase conexion

    Dim Comando As New OleDbCommand
    Dim Adaptador As New OleDbDataAdapter(Comando)
    Dim Transact As OleDbTransaction

    Public Sub Llenar_sexo(CBSexo As ComboBox)
        CBSexo.Items.Clear()
        CBSexo.Items.Add("Hombre")
        CBSexo.Items.Add("Mujer")
        CBSexo.Text = "<Seleccione>"
    End Sub

    Public Sub Llenar_acceso(CBAcceso As ComboBox)
        CBAcceso.Items.Clear()
        CBAcceso.Items.Add("3 veces por semana")
        CBAcceso.Items.Add("Pase libre")
        CBAcceso.Text = "<Selecione uno>"
    End Sub

    Public Function Agregar_socio(Nombre As String, Apellido As String, Dni As String, Sexo As String, Acceso As String, Precio As Decimal)

        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Insert Into Socios(Nombre,Apellido,Dni,Sexo,Acceso,Precio) values('" & Nombre & "','" & Apellido & "','" & Dni & "','" & Sexo & "','" & Acceso & "','" & Precio & "')"
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted) 'Establecemos la clausula  "Begin" de SQL

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector 'Establecemos conexion
            Comando.Transaction = Transaccion 'Establecemos transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback() 'Si falla hacemos Rollback
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Editar_socio(ID As Integer, Nombre As String, Apellido As String, Dni As String, Sexo As String, Acceso As String, Precio As Decimal)

        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Socios set Nombre='" & Nombre & "', Apellido='" & Apellido & "', Dni='" & Dni & "', Sexo='" & Sexo & "', Acceso='" & Acceso & "', Precio='" & Precio & "' Where ID=" & ID
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted) 'Establecemos la clausula  "Begin" de SQL

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector 'Establecemos conexion
            Comando.Transaction = Transaccion 'Establecemos transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback() 'Si falla hacemos Rollback
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Mostrar_socios(Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select *from Socios"

        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("ID"), DR("Nombre"), DR("Apellido"), DR("Dni"), DR("Sexo"), DR("Acceso"), DR("Precio"))
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar_socio(ID As Integer)
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Delete from Socios Where ID=" & ID
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted)

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            Comando.Transaction = Transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
