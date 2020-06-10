Imports System.ComponentModel

Public Class Form1


    Private Sub btnAcceso_Click(sender As Object, e As EventArgs)
        If txtUsuario.Text = "Administrador" And txtContraseña.Text = "SinHacer2020" Then
            Formulario.Show()
            Me.Hide()
        Else
            MessageBox.Show("Contraseña incorrecta", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContraseña.Text = ""
            txtUsuario.Text = ""
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtContraseña, "Ingrese la contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtUsuario, "Ingrese la contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub btnAcceso_Click_1(sender As Object, e As EventArgs) Handles btnAcceso.Click
        Formulario.Show()
        Me.Hide()
    End Sub
End Class
