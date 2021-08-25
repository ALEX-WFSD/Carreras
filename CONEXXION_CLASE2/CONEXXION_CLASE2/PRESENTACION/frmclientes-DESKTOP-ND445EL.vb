Public Class frmclientes

    Private dt As New DataTable
    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()



    End Sub

    Private Sub Mostrar()
        Try

            Dim func As New fCLIENTES
            dt = func.Mostrar
            datalistado.Columns.Item("eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtBuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
            Else
                datalistado.DataSource = Nothing
                txtBuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox("*****" + ex.Message + "*****" + "aqui")
        End Try
        Buscar()
    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = ComboBox1.Text & " like ' " & txtBuscar.Text & "%´"
            If dv.Count <> 0 Then
                datalistado.DataSource = dv
            Else
                datalistado.DataSource = Nothing
                ocultar_columnas()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        Try
            datalistado.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub
    Public Sub Limpiar()
        txtIDCorredor.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtEstatura.Clear()
        txtEdad.Clear()
        txtIdPatrocinador.Clear()
        btnEditar.Enabled = True
        btnGuardar.Visible = True



    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub



    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length <= 0 Then
            Me.ErrorIcono.SetError(sender, "NO SE LLENO EL NOMBRE")
        Else
            Me.ErrorIcono.SetError(sender, "CORRECTO")
        End If

    End Sub

    Private Sub txtDomicilio_TextChanged(sender As Object, e As EventArgs) Handles txtEstatura.TextChanged

    End Sub

    Private Sub txtDomicilio_Validated(sender As Object, e As EventArgs) Handles txtEstatura.Validated
        If DirectCast(sender, TextBox).Text.Length <= 0 Then
            Me.ErrorIcono.SetError(sender, "NO SE LLENO la Estatura")
        Else
            Me.ErrorIcono.SetError(sender, "CORRECTO")
        End If

    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged

    End Sub

    Private Sub txtApellidos_Validated(sender As Object, e As EventArgs) Handles txtApellidos.Validated
        If DirectCast(sender, TextBox).Text.Length <= 0 Then
            Me.ErrorIcono.SetError(sender, "NO SE LLENO EL Apellido")
        Else
            Me.ErrorIcono.SetError(sender, "CORRECTO")
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub



    Private Sub txtEdad_Validated(sender As Object, e As EventArgs) Handles txtEdad.Validated
        If DirectCast(sender, TextBox).Text.Length <= 0 Then
            Me.ErrorIcono.SetError(sender, "NO SE LLENO la Edad")
        Else
            Me.ErrorIcono.SetError(sender, "CORRECTO")
        End If
    End Sub
    Private Sub txtIdPatrocinador_TextChanged(sender As Object, e As EventArgs) Handles txtIdPatrocinador.TextChanged

    End Sub

    Private Sub txtIdPatrocinador_Validated(sender As Object, e As EventArgs) Handles txtIdPatrocinador.Validated
        If DirectCast(sender, TextBox).Text.Length <= 0 Then
            Me.ErrorIcono.SetError(sender, "NO SE LLENO EL Patrocinador")
        Else
            Me.ErrorIcono.SetError(sender, "CORRECTO")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellidos.Text <> "" And txtEstatura.Text <> "" And txtEdad.Text <> "" And txtIdPatrocinador.Text <> "" Then
            Try
                Dim dts As New fcampos
                Dim func As New fCLIENTES
                dts.gNOMBRE = txtNombre.Text
                dts.gAPELLIDO = txtApellidos.Text
                dts.gestatura = txtEstatura.Text
                dts.gEDAD = txtEdad.Text
                dts.gIDPATROCINADOR = txtIdPatrocinador.Text
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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim ind As Integer

        btnEditar.Visible = True

        ind = datalistado.CurrentRow.Index
        txtIDCorredor.Text = datalistado.SelectedCells.Item(1).Value
        txtNombre.Text = datalistado.SelectedCells.Item(2).Value
        txtApellidos.Text = datalistado.SelectedCells.Item(3).Value
        txtEstatura.Text = datalistado.SelectedCells.Item(4).Value
        txtEdad.Text = datalistado.SelectedCells.Item(5).Value
        txtIdPatrocinador.Text = datalistado.SelectedCells.Item(6).Value



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellidos.Text <> "" And txtEstatura.Text <> "" And txtEdad.Text <> "" And txtIdPatrocinador.Text <> "" And txtIDCorredor.Text <> "" Then
            Try
                Dim dts As New fcampos
                Dim func As New fCLIENTES
                dts.gIDCORREDOR = txtIDCorredor.Text
                dts.gNOMBRE = txtNombre.Text
                dts.gAPELLIDO = txtApellidos.Text
                dts.gestatura = txtEstatura.Text
                dts.gEDAD = txtEdad.Text
                dts.gIDPATROCINADOR = txtIdPatrocinador.Text
                If func.editar(dts) Then
                    MessageBox.Show("corredor EDITADO correctamente", "guardando EDICION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("corredor no se pudo EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub
End Class