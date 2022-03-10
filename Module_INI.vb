'Schemat dodawania nowego ustawienia:
'0. Utwórz checkbox/textbox itp w zależności co chcesz zrobić
'1. Dodaj zmienną w module o odpowiedniej nazwie jako string
'2. Dodaj 2 wpisy w procedurze: ZAPISZ_USTAWIENIA_INI
'   a) Dodaj przyporządkowanie wartości do zmiennej w zależności od wybranego checkboxa itp
'   b) Dodaj wpis w odpowiedniej sekcji ini np.: ini.AddSection("OTHER_SETTINGS").AddKey("SFTP").Value = SFTP
'3. Dodaj 2 wpisy w module WCZYTAJ_USTAWIENIA_INI
'   a) Dodaj przyporządkowanie wczytanej wartości z ini do zmiennej np. 
'If ini.RenameKey("OTHER_SETTINGS", "SFTP", "SFTP") Then
'SFTP = ini.GetSection("OTHER_SETTINGS").GetKey("SFTP").Value
'Else
'ini.AddSection("OTHER_SETTINGS").AddKey("SFTP").Value = 0
'ini.Save(Directory & "\Preferences.ini")
'SFTP = 0
'End If
'   b) Dodaj przyporządkowanie wczytanej wartości do checkbox i PIC - kontrolek

Imports System.IO
Module Module_INI
    Public Folder_Files As String
    Public File_Sent_List As String = "No history"
    Public FTP_Path As String
    Public Login As String
    Public Password As String
    Public Prefix As String
    Public Sufix As String
    Public Char_Num As Integer
    Public SFTP As String

    Sub Save_Settings_INI()
        '1. Read to variables
        Folder_Files = My.Forms.Form_Settings.T_Sciezka_Files.Text
        Char_Num = CInt(My.Forms.Form_Settings.Num_Znaki.Value)
        FTP_Path = My.Forms.Form_Settings.T_Sciezka_FTP.Text
        Login = My.Forms.Form_Settings.T_Login.Text
        Password = My.Forms.Form_Settings.T_Haslo.Text
        Prefix = My.Forms.Form_Settings.T_Prefix.Text
        Sufix = My.Forms.Form_Settings.T_Sufix.Text
        If My.Forms.Form_Settings.Radio_FTP.Checked = True Then
            SFTP = "FTP"
        Else
            SFTP = "SFTP"
        End If
        '2. Check if INI file exist
        INI_Initiation()

        '3. Save to INI file
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim ini As New IniFile
        'Load and existing file
        ini.Load(Directory & "\Preferences.ini")
        ini.AddSection("ACCESS_PATH").AddKey("Folder_Files").Value = Folder_Files
        ini.AddSection("STRING_SETTINGS").AddKey("Char_Num").Value = Char_Num
        ini.AddSection("STRING_SETTINGS").AddKey("Prefix").Value = Prefix
        ini.AddSection("STRING_SETTINGS").AddKey("Sufix").Value = Sufix
        ini.AddSection("FTP_SFTP_SETTINGS").AddKey("FTP_Path").Value = FTP_Path
        ini.AddSection("FTP_SFTP_SETTINGS").AddKey("Login").Value = Login
        ini.AddSection("FTP_SFTP_SETTINGS").AddKey("Password").Value = Password
        ini.AddSection("FTP_SFTP_SETTINGS").AddKey("SFTP").Value = SFTP

        ini.Save(Directory & "\Preferences.ini")
    End Sub
    Sub Load_Settings_INI()
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim ini As New IniFile
        '0. Check if INI file exist
        INI_Initiation()
        '1. Load and existing file
        ini.Load(Directory & "\Preferences.ini")

        '2. Read to variables
        Folder_Files = ini.GetSection("ACCESS_PATH").GetKey("Folder_Files").GetValue()
        Char_Num = ini.GetSection("STRING_SETTINGS").AddKey("Char_Num").GetValue()
        Prefix = ini.GetSection("STRING_SETTINGS").AddKey("Prefix").GetValue()
        Sufix = ini.GetSection("STRING_SETTINGS").AddKey("Sufix").GetValue()
        FTP_Path = ini.GetSection("FTP_SFTP_SETTINGS").AddKey("FTP_Path").GetValue()
        Login = ini.GetSection("FTP_SFTP_SETTINGS").AddKey("Login").GetValue()
        Password = ini.GetSection("FTP_SFTP_SETTINGS").AddKey("Password").GetValue()
        SFTP = ini.GetSection("FTP_SFTP_SETTINGS").AddKey("SFTP").GetValue()

        '3. Read settings
        My.Forms.Form_Settings.T_Sciezka_Files.Text = Folder_Files
        My.Forms.Form_Settings.Num_Znaki.Value = CInt(Char_Num)
        My.Forms.Form_Settings.T_Sciezka_FTP.Text = FTP_Path
        My.Forms.Form_Settings.T_Login.Text = Login
        My.Forms.Form_Settings.T_Haslo.Text = Password
        My.Forms.Form_Settings.T_Prefix.Text = Prefix
        My.Forms.Form_Settings.T_Sufix.Text = Sufix
        If SFTP = "SFTP" Then
            My.Forms.Form_Settings.Radio_FTP.Checked = False
            My.Forms.Form_Settings.Radio_SFTP.Checked = True
        Else 'FTP
            My.Forms.Form_Settings.Radio_SFTP.Checked = False
            My.Forms.Form_Settings.Radio_FTP.Checked = True
        End If


    End Sub
    Sub INI_Initiation()
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim ini As New IniFile
        If File.Exists(Directory & "\Preferences.ini") Then
        Else
            My.Computer.FileSystem.WriteAllText(Directory & "\Preferences.ini", "[File_To_Ftp_Settings]", False)
            Save_Settings_INI()
        End If

    End Sub
End Module
