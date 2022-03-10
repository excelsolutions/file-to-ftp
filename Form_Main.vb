Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Threading
Public Class Form_Main
    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles Btn_Send.Click
        Try
            If Ftp_Exist() = False Then
                L_Error.Text = "Problem with connection to FTP!"
                ToolTip1.SetToolTip(L_Error, "Problem with connection to FTP!")
            Else
                L_Error.Text = ""
                If IsConnectedToInternet() = False Then
                    L_Error.Text = "Problem with internet connection!"
                    ToolTip1.SetToolTip(L_Error, "Problem with internet connection!")
                Else 'jak wszystko OK, startuj!
                    Send_To_Ftp()
                End If

            End If
        Catch ex As Exception
            L_Error.Text = "Error, can't send files!"
            ToolTip1.SetToolTip(L_Error, ex.Message)
        End Try


    End Sub
    Public Sub Sprawdz_FTP()
        Try
            If Ftp_Exist() Then
                MsgBox("FTP: " & FTP_Path & " ,dla loginu: " & Login & " działa poprawnie.", vbOKOnly + vbInformation, "Poprawnie")
            Else
                MsgBox("FTP: " & FTP_Path & " ,dla loginu: " & Login & " działa niepoprawnie!.", vbOKOnly + vbExclamation, "Błąd!")
            End If


        Catch ex As Exception

        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Odswiezanie.Tick
        Dim i As Integer = 0
        Dim myDir As DirectoryInfo
        If My.Forms.Form_Settings.T_Sciezka_Files.Text <> "" Then
            myDir = New DirectoryInfo(My.Forms.Form_Settings.T_Sciezka_Files.Text)
        Else
            myDir = New DirectoryInfo("C:\")
        End If

        Try
            If myDir.EnumerateFiles().Any() Then
                For Each Plik As String In My.Computer.FileSystem.GetFiles(My.Forms.Form_Settings.T_Sciezka_Files.Text)
                    'If UCase(Mid(Plik, Plik.Length - 3, 4)) = UCase(".pdf") Then
                    i = i + 1
                    'End If
                Next
            End If

        Catch ex As Exception
            My.Forms.Form_Main.L_Liczba_Plikow.Text = 0
        End Try


        My.Forms.Form_Main.L_Liczba_Plikow.Text = i
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form_About.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form_Settings.Show()
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Settings_INI() 'wczytaj je do zmiennych
        L_Error.Text = ""

        ToolTip1.SetToolTip(Pic_Lista, "List of previously sent files")
    End Sub

    Private Sub Pic_Lista_Click(sender As Object, e As EventArgs) Handles Pic_Lista.Click
        Form_List.Show()
    End Sub

    Private Sub L_Error_Click(sender As Object, e As EventArgs) Handles L_Error.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub Automat_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripAutomation_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripAutomation.ButtonClick
        If Timer_Automat.Enabled = False Then
            Timer_Automat.Enabled = True
            ToolStripAutomation.Image = My.Resources.circle_23965_640
        Else
            Timer_Automat.Enabled = False
            ToolStripAutomation.Image = My.Resources.Red_Button
        End If
    End Sub

    Private Sub Timer_Automat_Tick(sender As Object, e As EventArgs) Handles Timer_Automat.Tick
        Try
            If Ftp_Exist() = False Then
                L_Error.Text = "Problem with connection to FTP!"
                ToolTip1.SetToolTip(L_Error, "Problem with connection to FTP!")
            Else
                L_Error.Text = ""
                If IsConnectedToInternet() = False Then
                    L_Error.Text = "Problem with internet connection!"
                    ToolTip1.SetToolTip(L_Error, "Problem with internet connection!")
                Else 'jak wszystko OK, startuj!
                    Send_To_Ftp()
                End If

            End If
        Catch ex As Exception
            L_Error.Text = "Error, can't send files!"
            ToolTip1.SetToolTip(L_Error, ex.Message)
        End Try
    End Sub

    Private Sub Btn_Rename_Save_Click(sender As Object, e As EventArgs) Handles Btn_Rename_Save.Click
        Form_List.Show()
        Zmiana_Nazw()
    End Sub

    Private Sub L_Liczba_Plikow_Click(sender As Object, e As EventArgs) Handles L_Liczba_Plikow.Click

    End Sub

    Private Sub TestFTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestFTPToolStripMenuItem.Click
        Sprawdz_FTP()
    End Sub
End Class
