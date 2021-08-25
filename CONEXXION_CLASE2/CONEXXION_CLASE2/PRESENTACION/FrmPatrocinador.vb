Imports System.ComponentModel

Public Class FrmPatrocinador
    Private dt As New DataTable
    Private Sub FrmPatrocinador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub
    Private Sub Mostrar()
        Try

            Dim func As New FPatrocinador
            dt = func.Mostrar
            Datapatrocinador.Columns.Item("eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                Datapatrocinador.DataSource = dt
                txtBuscar.Enabled = True
                Datapatrocinador.ColumnHeadersVisible = True
            Else
                Datapatrocinador.DataSource = Nothing
                txtBuscar.Enabled = False
                Datapatrocinador.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox("*****" + ex.Message + "*****" + "aqui")
        End Try

    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim datvi As New DataView(ds.Tables(0))
            datvi.RowFilter = cboBUSCAR.Text & " like '" & txtBuscar.Text & "%'"
            If datvi.Count <> 0 Then
                Datapatrocinador.DataSource = datvi
            Else
                Datapatrocinador.DataSource = Nothing
                ocultar_columnas()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        Try
            Datapatrocinador.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub
    Public Sub Limpiar()
        txtIDpatrocinador.Clear()
        txtMarca.Clear()
        txtKilometros.Clear()

        btnEditar.Visible = False
        btnGuardar.Visible = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Me.ValidateChildren = True And txtIDpatrocinador.Text <> "" And txtMarca.Text <> "" And txtKilometros.Text <> "" Then
            Try
                Dim dts As New FCAMPO_PATROCINADOR
                Dim func As New FPatrocinador
                dts.gIDPATROCINADOR = txtIDpatrocinador.Text
                dts.gNOMBRE_PATROCINADOR = txtMarca.Text
                dts.gKILOMETROS = txtKilometros.Text

                If func.EDITAR(dts) Then
                    MessageBox.Show("corredor EDITADO correctamente", "guardando datos del cliente ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("corredor no se pudo EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtIDpatrocinador_TextChanged(sender As Object, e As EventArgs) Handles txtIDpatrocinador.TextChanged

    End Sub

    Private Sub txtIDpatrocinador_Validated(sender As Object, e As EventArgs) Handles txtIDpatrocinador.Validated
        If DirectCast(sender, TextBox).Text.Length < 0 Then
            Me.ErrorProvider1.SetError(sender, "NO SE LLENO EL NOMBRE")
        Else
            Me.ErrorProvider1.SetError(sender, "CORRECTO")
        End If

    End Sub

    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged

    End Sub

    Private Sub txtMarca_Validated(sender As Object, e As EventArgs) Handles txtMarca.Validated
        If DirectCast(sender, TextBox).Text.Length < 0 Then
            Me.ErrorProvider1.SetError(sender, "NO SE LLENO EL NOMBRE")
        Else
            Me.ErrorProvider1.SetError(sender, "CORRECTO")
        End If
    End Sub

    Private Sub txtKilometros_TextChanged(sender As Object, e As EventArgs) Handles txtKilometros.TextChanged

    End Sub

    Private Sub txtKilometros_Validated(sender As Object, e As EventArgs) Handles txtKilometros.Validated
        If DirectCast(sender, TextBox).Text.Length < 0 Then
            Me.ErrorProvider1.SetError(sender, "NO SE LLENO EL NOMBRE")
        Else
            Me.ErrorProvider1.SetError(sender, "CORRECTO")
        End If
    End Sub

    Private Sub txtNuevo_Click(sender As Object, e As EventArgs) Handles txtNuevo.Click
        Limpiar()
        Mostrar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtMarca.Text <> "" And txtKilometros.Text <> "" Then
            Try
                Dim dts As New FCAMPO_PATROCINADOR
                Dim func As New FPatrocinador
                dts.gNOMBRE_PATROCINADOR = txtMarca.Text
                dts.gKILOMETROS = txtKilometros.Text

                If func.Insertar(dts) Then
                    MessageBox.Show("corredor agregado correctamente", "guardando datos del cliente ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("corredor no se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Me.ValidateChildren = True And txtIDpatrocinador.Text <> "" Then
            Try
                Dim dts As New FCAMPO_PATROCINADOR
                Dim func As New FPatrocinador
                dts.gIDPATROCINADOR = txtIDpatrocinador.Text

                If func.eliminar(dts) Then
                    MsgBox(" ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("EL CORREDOR NO SE ÚDO ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Datapatrocinador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datapatrocinador.CellClick
        btnEditar.Visible = True
        btnGuardar.Visible = False
        If Datapatrocinador.CurrentRow Is Nothing Then
            Return
        End If
        Dim ro As DataGridViewRow = Datapatrocinador.CurrentRow
        txtIDpatrocinador.Text = Datapatrocinador.SelectedCells.Item(1).Value
        txtMarca.Text = Datapatrocinador.SelectedCells.Item(2).Value
        txtKilometros.Text = Datapatrocinador.SelectedCells.Item(3).Value
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Size = New Size(33, 23)
        PictureBox3.BackgroundImage = My.Resources.rojo

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(30, 20)
        PictureBox3.BackgroundImage = My.Resources.cerrar_negro
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.Size = New Size(33, 23)
        PictureBox4.BackgroundImage = My.Resources.minimizar_gris

    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(30, 20)
        PictureBox4.BackgroundImage = My.Resources.MINIMIZAR_NEGRO
    End Sub
End Class