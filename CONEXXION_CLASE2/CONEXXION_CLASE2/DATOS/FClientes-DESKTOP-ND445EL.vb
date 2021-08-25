Imports System.Data.SqlClient

Public Class fCLIENTES
    Inherits CONEXION
    Dim DOSE As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            Conectado()
            DOSE = New SqlCommand("mostrar_CORREDOR")
            DOSE.CommandType = CommandType.StoredProcedure
            DOSE.Connection = cnn
            If DOSE.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(DOSE)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
            desconectado()
        End Try


    End Function

    Public Function Insertar(ByVal dts As fcampos) As Boolean
        Try
            Conectado()
            DOSE = New SqlCommand("insertar_corredor")
            DOSE.CommandType = CommandType.StoredProcedure
            DOSE.Connection = cnn

            DOSE.Parameters.AddWithValue("@NOMBRE", dts.gNOMBRE)
            DOSE.Parameters.AddWithValue("@APELLIDO", dts.gAPELLIDO)
            DOSE.Parameters.AddWithValue("@ESTATURA", Convert.ToDecimal(dts.gestatura))
            DOSE.Parameters.AddWithValue("@EDAD", Int32.Parse(dts.gEDAD))
            DOSE.Parameters.AddWithValue("@IDPATROCINADOR", Int32.Parse(dts.gIDPATROCINADOR))

            If DOSE.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function
    Public Function editar(ByVal dts As fcampos) As Boolean
        Try
            Conectado()
            DOSE = New SqlCommand("editar_corredor")
            DOSE.CommandType = CommandType.StoredProcedure
            DOSE.Connection = cnn
            DOSE.Parameters.AddWithValue("@IDCORREDOR", Int32.Parse(dts.gIDCORREDOR))
            DOSE.Parameters.AddWithValue("@NOMBRE", dts.gNOMBRE)
            DOSE.Parameters.AddWithValue("@APELLIDO", dts.gAPELLIDO)
            DOSE.Parameters.AddWithValue("@ESTATURA", Convert.ToDecimal(dts.gestatura))
            DOSE.Parameters.AddWithValue("@EDAD", Int32.Parse(dts.gEDAD))
            DOSE.Parameters.AddWithValue("@IDPATROCINADOR", Int32.Parse(dts.gIDPATROCINADOR))

            If DOSE.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try

    End Function








End Class
