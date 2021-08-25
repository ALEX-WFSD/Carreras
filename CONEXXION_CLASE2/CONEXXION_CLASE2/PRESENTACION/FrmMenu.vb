Imports System.Runtime.InteropServices
Public Class FrmMenu
    Private Sub btnpat_Click(sender As Object, e As EventArgs) Handles btnpat.Click
        Me.Hide()
        FrmPatrocinador.Show()
    End Sub

    Private Sub Btncorr_Click(sender As Object, e As EventArgs) Handles Btncorr.Click
        Me.Hide()
        frmclientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub btnCerrar_menu_Click(sender As Object, e As EventArgs) Handles btnCerrar_menu.Click
        Application.Exit()
    End Sub

    Private Sub btnCerrar_menu_MouseHover(sender As Object, e As EventArgs) Handles btnCerrar_menu.MouseHover
        btnCerrar_menu.Size = New Size(33, 23)
        btnCerrar_menu.BackgroundImage = My.Resources.cerrar_rojo
    End Sub

    Private Sub btnCerrar_menu_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar_menu.MouseLeave
        btnCerrar_menu.Size = New Size(30, 20)
        btnCerrar_menu.BackgroundImage = My.Resources.cerrar_negro
    End Sub

    Private Sub btnMinimizarMenu_Click(sender As Object, e As EventArgs) Handles btnMinimizarMenu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMinimizarMenu_MouseHover(sender As Object, e As EventArgs) Handles btnMinimizarMenu.MouseHover
        btnMinimizarMenu.Size = New Size(33, 23)
        btnMinimizarMenu.BackgroundImage = My.Resources.minimizar_gris
    End Sub

    Private Sub btnMinimizarMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimizarMenu.MouseLeave
        btnMinimizarMenu.Size = New Size(30, 20)
        btnMinimizarMenu.BackgroundImage = My.Resources.MINIMIZAR_NEGRO
    End Sub

    Private Sub Btncorr_MouseHover(sender As Object, e As EventArgs) Handles Btncorr.MouseHover
        Btncorr.Size = New Size(117, 113)
        Label1.Visible = True
    End Sub

    Private Sub Btncorr_MouseLeave(sender As Object, e As EventArgs) Handles Btncorr.MouseLeave
        Btncorr.Size = New Size(115, 110)
        Label1.Visible = False
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

    Private Sub FrmMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnpat_MouseHover(sender As Object, e As EventArgs) Handles btnpat.MouseHover
        btnpat.Size = New Size(120, 115)
        Label2.Visible = True
    End Sub

    Private Sub btnpat_MouseLeave(sender As Object, e As EventArgs) Handles btnpat.MouseLeave
        btnpat.Size = New Size(115, 110)
        Label2.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        FrmLogin.Show()
    End Sub
#End Region
End Class