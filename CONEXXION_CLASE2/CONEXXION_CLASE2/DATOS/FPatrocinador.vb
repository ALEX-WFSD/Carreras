Imports System.Data.SqlClient

Public Class FPatrocinador



    Inherits CONEXION
    Dim DOSE As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            Conectado()
            DOSE = New SqlCommand("buscar_PATROCINADORES")
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

    Public Function Insertar(ByVal dts As FCAMPO_PATROCINADOR) As Boolean
        Try
            Conectado()
            DOSE = New SqlCommand("insertar_Patrocinador")
            DOSE.CommandType = CommandType.StoredProcedure
            DOSE.Connection = cnn
            DOSE.Parameters.AddWithValue("@NOMBRE_PATROCINADOR", dts.gNOMBRE_PATROCINADOR)
            DOSE.Parameters.AddWithValue("@KILOMETROS", dts.gKILOMETROS)

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
    Public Function eliminar(ByVal dts As FCAMPO_PATROCINADOR) As Boolean
        Try
            Conectado()
            DOSE = New SqlCommand("Eliminar_Patrocinador")
            DOSE.CommandType = CommandType.StoredProcedure
            DOSE.Connection = cnn
            DOSE.Parameters.AddWithValue("@IDPATROCINADOR", dts.gIDPATROCINADOR)



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
    Public Function EDITAR(ByVal dts As FCAMPO_PATROCINADOR) As Boolean
        Try
            Conectado()
            DOSE = New SqlCommand("EDITAR_PATROCINADOR")
            DOSE.CommandType = CommandType.StoredProcedure
            DOSE.Connection = cnn
            DOSE.Parameters.AddWithValue("@IDPATROCINADOR", dts.gIDPATROCINADOR)
            DOSE.Parameters.AddWithValue("@NOMBRE_PATROCINADOR", dts.gNOMBRE_PATROCINADOR)
            DOSE.Parameters.AddWithValue("@KILOMETROS", dts.gKILOMETROS)

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
