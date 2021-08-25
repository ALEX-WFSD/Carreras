Imports System.Data.SqlClient

Public Class CONEXION
    Protected cnn As New SqlConnection
    Public USUARIO As Integer


    Protected Function Conectado()

        Try
            cnn = New SqlConnection("Data Source=DESKTOP-ND445EL\SQLEXPRESS;Initial Catalog=CARRERAS;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else

                Return False

            End If
        Catch ex As Exception
            MsgBox("FALLO EN LA FUNCION DESCONECTADO")
            Return False
        End Try

    End Function


End Class
