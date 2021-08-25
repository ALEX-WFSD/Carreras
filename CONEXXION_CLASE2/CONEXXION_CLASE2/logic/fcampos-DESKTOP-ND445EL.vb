Public Class fcampos
    Dim EDAD, IDPATROCINADOR, IDCORREDOR As Integer
    Dim estatura As Decimal

    Dim NOMBRE, APELLIDO As String
    Public Property gIDCORREDOR
        Get
            Return IDCORREDOR
        End Get
        Set(ByVal value)
            IDCORREDOR = value

        End Set
    End Property
    Public Property gNOMBRE
        Get
            Return NOMBRE
        End Get
        Set(ByVal value)
            NOMBRE = value

        End Set
    End Property


    Public Property gAPELLIDO
        Get
            Return APELLIDO
        End Get
        Set(ByVal value)
            APELLIDO = value

        End Set
    End Property
    Public Property gestatura
        Get
            Return estatura
        End Get
        Set(ByVal value)
            estatura = value

        End Set
    End Property
    Public Property gEDAD
        Get
            Return EDAD
        End Get
        Set(ByVal value)
            EDAD = value

        End Set
    End Property
    Public Property gIDPATROCINADOR
        Get
            Return IDPATROCINADOR
        End Get
        Set(ByVal value)
            IDPATROCINADOR = value

        End Set
    End Property


    Public Sub New()

    End Sub
    Public Sub New(ByVal IDCOREEDOR As Integer, ByVal NOMBRE As String, ByVal APELLIDO As String, ByVal ESTATURA As Decimal, ByVal EDAD As Integer, ByVal PATROCINADOR As Integer)

        gNOMBRE = NOMBRE
        gAPELLIDO = APELLIDO
        gestatura = ESTATURA
        gEDAD = EDAD
        gIDPATROCINADOR = PATROCINADOR
        gIDCORREDOR = IDCOREEDOR


    End Sub


End Class
