Imports System.Runtime.InteropServices
Public Class FrmLogin
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = "user" And txtContraseña.Text = "password" Then
            Me.Hide()
            FrmMenu.Show()
            txtContraseña.Clear()
            txtUsuario.Clear()

        Else
            MsgBox("Contraseña y/o usuario incorrecto")

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)

    End Sub

#Region " mover forms"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles Titlebar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FrmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Customize Controls"
    Private Sub CustomizeComponents()
        txtUsuario.AutoSize = False

        txtUsuario.Size = New Size(192, 35)

        txtContraseña.AutoSize = False
        txtContraseña.Size = New Size(192, 35)

    End Sub

#End Region


    Private Sub btnAceptar_Paint(sender As Object, e As PaintEventArgs) Handles btnAceptar.Paint
        Dim buttonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myrectangle As Rectangle = btnAceptar.ClientRectangle
        myrectangle.Inflate(0, 15)
        buttonpath.AddEllipse(myrectangle)
        btnAceptar.Region = New Region(buttonpath)

    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub

#End Region





    Private Sub btnAceptar_MouseHover(sender As Object, e As EventArgs) Handles btnAceptar.MouseHover
        btnAceptar.Size = New Size(196, 37)
    End Sub

    Private Sub btnAceptar_MouseLeave(sender As Object, e As EventArgs) Handles btnAceptar.MouseLeave
        btnAceptar.Size = New Size(192, 33)
    End Sub

    Private Sub btncerrarN_MouseHover(sender As Object, e As EventArgs) Handles btncerrarN.MouseHover
        btncerrarN.BackgroundImage = My.Resources.rojo
        btncerrarN.Size = New Size(32, 22)
    End Sub

    Private Sub btncerrarN_MouseLeave(sender As Object, e As EventArgs) Handles btncerrarN.MouseLeave
        btncerrarN.BackgroundImage = My.Resources.cerrar_negro
        btncerrarN.Size = New Size(30, 20)
    End Sub

    Private Sub btncerrarN_Click(sender As Object, e As EventArgs) Handles btncerrarN.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size = New Size(32, 22)
        PictureBox1.BackgroundImage = My.Resources.minimizar_gris
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(30, 20)
        PictureBox1.BackgroundImage = My.Resources.MINIMIZAR_NEGRO
    End Sub
End Class