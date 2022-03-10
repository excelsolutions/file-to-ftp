Public Class Form_Settings
    Private Sub Pic_PDF_Click(sender As Object, e As EventArgs) Handles Pic_PDF.Click
        ' Wybor_Folderu.ShowDialog()
        If Wybor_Folderu.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.T_Sciezka_Files.Text = (Wybor_Folderu.SelectedPath) & "\"
        End If
    End Sub

    Private Sub Btn_Zapisz_Click(sender As Object, e As EventArgs) Handles Btn_Zapisz.Click
        Save_Settings_INI()
        Me.Hide()
    End Sub

    Private Sub Form_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Settings_INI()
    End Sub
End Class