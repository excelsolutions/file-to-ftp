Public Class Form_Settings
    Private Sub Pic_PDF_Click(sender As Object, e As EventArgs) Handles Pic_PDF.Click
        ' Wybor_Folderu.ShowDialog()
        If Wybor_Folderu.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.T_Sciezka_Files.Text = (Wybor_Folderu.SelectedPath) & "\"
        End If
    End Sub

    Private Sub Btn_Zapisz_Click(sender As Object, e As EventArgs) Handles Btn_Zapisz.Click
        My.Settings.Folder_Files = T_Sciezka_Files.Text
        My.Settings.Znaki = CInt(Num_Znaki.Value)
        My.Settings.Folder_FTP = T_Sciezka_FTP.Text
        My.Settings.Login = T_Login.Text
        My.Settings.Password = T_Haslo.Text
        My.Settings.Prefix = T_Prefix.Text
        My.Settings.Sufix = T_Sufix.Text
        If Radio_FTP.Checked = True Then
            My.Settings.SFTP = "FTP"
        Else
            My.Settings.SFTP = "SFTP"
        End If
        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub Form_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_Sciezka_Files.Text = My.Settings.Folder_Files
        Num_Znaki.Value = CInt(My.Settings.Znaki)
        T_Sciezka_FTP.Text = My.Settings.Folder_FTP
        T_Login.Text = My.Settings.Login
        T_Haslo.Text = My.Settings.Password
        T_Prefix.Text = My.Settings.Prefix
        T_Sufix.Text = My.Settings.Sufix
        If My.Settings.SFTP = "FTP" Then
            Radio_FTP.Checked = True
            Radio_SFTP.Checked = False
        Else
            Radio_SFTP.Checked = True
            Radio_FTP.Checked = False
        End If
    End Sub
End Class