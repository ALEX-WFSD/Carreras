Public Class FCAMPO_PATROCINADOR
    Dim KILOMETROS, IDPATROCINADOR As Integer

    Dim NOMBRE_PATROCINADOR As String

    Public Property gIDPATROCINADOR
        Get
            Return IDPATROCINADOR
        End Get
        Set(ByVal value)
            IDPATROCINADOR = value

        End Set
    End Property


    Public Property gNOMBRE_PATROCINADOR
        Get
            Return NOMBRE_PATROCINADOR
        End Get
        Set(ByVal value)
            NOMBRE_PATROCINADOR = value

        End Set
    End Property


    Public Property gKILOMETROS
        Get
            Return KILOMETROS
        End Get
        Set(ByVal value)
            KILOMETROS = value

        End Set

    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal IDPATROCINADOR As Integer, ByVal NOMBRE_PATROCINADOR As String, ByVal KILOMETROS As Integer)
        gIDPATROCINADOR = IDPATROCINADOR
        gNOMBRE_PATROCINADOR = NOMBRE_PATROCINADOR
        gKILOMETROS = KILOMETROS




    End Sub

End Class
