Imports System.ComponentModel

Public Class Formulario
    Public negativo, positivo, muerto, recuperado, activo As Integer
    Public contadorPaciente As Integer
    Public nombre(20), municipio(20), departamento(20), edad(20), resultado(20), estado(20) As String

    Private Sub rdDatos_CheckedChanged(sender As Object, e As EventArgs) Handles rdDatos.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(0)
    End Sub

    Private Sub rdReporte_CheckedChanged(sender As Object, e As EventArgs) Handles rdReporte.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(1)
    End Sub

    Private Sub rdSalir_CheckedChanged(sender As Object, e As EventArgs) Handles rdSalir.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(2)
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese aquí su NOMBRE COMPLETO")
        ToolTip.ToolTipTitle = "Nombre de la persona"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese aquí su MUNICIPIO")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMunicipio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtNombre, "Descripción de la persona")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtlimpiar_Click(sender As Object, e As EventArgs) Handles txtlimpiar.Click
        txtNombre.Clear()
        txtMunicipio.Clear()
        cmDepartamento.Text = ""
        txtEdad.Clear()
        txtDescripcion.Clear()
        rbNega.Checked = False
        rbPosi.Checked = False
        chAC.Checked = False
        chMue.Checked = False
        chRe.Checked = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub

    Private Sub chAC_CheckedChanged(sender As Object, e As EventArgs) Handles chAC.CheckedChanged
        If chAC.Checked = True Then
            chMue.Checked = False
            chRe.Checked = False
        End If
    End Sub


    Private Sub cmDepa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmDepa.SelectedIndexChanged
        historial.Items.Clear()
        For i = 0 To contadorPaciente Step 1
            If cmDepa.SelectedItem = departamento(i) Then
                historial.Items.Add(nombre(i) & "  " & edad(i) & "  " & municipio(i) & " " & resultado(i) & " " & estado(i))
            End If
        Next

    End Sub

    Private Sub chRe_CheckedChanged(sender As Object, e As EventArgs) Handles chRe.CheckedChanged
        If chRe.Checked = True Then
            chMue.Checked = False
            chAC.Checked = False
        End If
    End Sub

    Private Sub chMue_CheckedChanged(sender As Object, e As EventArgs) Handles chMue.CheckedChanged
        If chMue.Checked = True Then
            chRe.Checked = False
            chAC.Checked = False
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese su edad")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rbNega.Checked = True Then
            negativo += 1
            txtNega.Text = negativo
            resultado(contadorPaciente) = "Negativo"
        ElseIf rbPosi.Checked = True Then
            positivo += 1
            txtPosi.Text = positivo
            resultado(contadorPaciente) = "Positivo"
        End If

        If chAC.Checked = True Then
            activo += 1
            txtAct.Text = activo
            estado(contadorPaciente) = "Activo"
        ElseIf chMue.Checked = True Then
            muerto += 1
            txtMue.Text = muerto
            estado(contadorPaciente) = "Muerto"
        ElseIf chRe.Checked = True Then
            recuperado += 1
            txtRe.Text = recuperado
            estado(contadorPaciente) = "Recuperado"
        End If

        nombre(contadorPaciente) = txtNombre.Text
        municipio(contadorPaciente) = txtMunicipio.Text
        edad(contadorPaciente) = txtEdad.Text
        departamento(contadorPaciente) = cmDepartamento.SelectedItem
        contadorPaciente += 1

    End Sub

    Private Sub btnlimpiar2_Click(sender As Object, e As EventArgs) Handles btnlimpiar2.Click
        txtAct.Clear()
        txtMue.Clear()
        txtRe.Clear()
        historial.Items.Clear()
        cmDepa.Text = ""
        txtPosi.Clear()
        txtNega.Clear()
    End Sub

End Class