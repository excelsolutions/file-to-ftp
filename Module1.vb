Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Threading
Module Module1




    Public Sub Send_To_Ftp()


        Dim LP As Int16 = 0
        Dim FileName As String
        Dim Folder_Files As String = My.Forms.Form_Settings.T_Sciezka_Files.Text

        Dim remoteLOC As String
        Dim Rodzaj_Bledu As String = ""
        My.Forms.Form_Main.ToolTip1.SetToolTip(My.Forms.Form_Main.L_Error, "")
        Zmiana_Nazw() 'zmień nazwy plików
        '0 Me.Lista_Operacji.Columns.Add("No.", 50)
        '1 Me.Lista_Operacji.Columns.Add("File name", 150)
        '2 Me.Lista_Operacji.Columns.Add("Path to file", 300)
        '3 Me.Lista_Operacji.Columns.Add("New name of file", 150)
        '4 Me.Lista_Operacji.Columns.Add("Status", 40)

        For Each Plik As String In My.Computer.FileSystem.GetFiles(Folder_Files) 'Sprawdź każdy plik w folderze
            Rodzaj_Bledu = Sprawdz_Plik_FTP(Plik)
            FileName = System.IO.Path.GetFileName(Plik)
            LP = LP + 1
            If Rodzaj_Bledu = "" Then
                remoteLOC = FTP_Path & System.IO.Path.GetFileName(Plik) 'nazwa ftp plus nazwa pliku
                Try
                    'My.Computer.Network.UploadFile(Plik, remoteLOC, Login, Password, True, 500)
                    Send_To_FTP_SFTP(Plik, FileName, FTP_Path, Login, Password, SFTP)
                    For Each item As ListViewItem In Form_List.Lista_Operacji.Items
                        If item.SubItems(2).Text = System.IO.Path.GetFullPath(Plik) Then
                            item.SubItems(4).Text = "Sent"
                            item.UseItemStyleForSubItems = False
                            item.SubItems(4).BackColor = System.Drawing.Color.Green
                        End If
                    Next
                    Try
                        My.Computer.FileSystem.DeleteFile(Plik)
                    Catch ex As Exception
                        My.Forms.Form_Main.L_Error.Text = "Unable to delete file"
                    End Try
                Catch ex As Exception
                    My.Forms.Form_Main.L_Error.Text = "Unable to send files to FTP. Check settings or internet connection"
                    My.Forms.Form_Main.ToolTip1.SetToolTip(My.Forms.Form_Main.L_Error, "Unable to send files to FTP. Check settings or internet connection")
                    For Each item As ListViewItem In Form_List.Lista_Operacji.Items
                        If item.SubItems(2).Text = System.IO.Path.GetFullPath(Plik) Then
                            item.SubItems(4).Text = "NOK"
                            item.UseItemStyleForSubItems = False
                            item.SubItems(4).BackColor = System.Drawing.Color.Red
                        End If
                    Next

                End Try
            Else

            End If

        Next

    End Sub

    Public Function Ftp_Exist() As Boolean

        Ftp_Exist = False
        'WYŁĄCZENIE SPRAWDZANIA FTP !!!!!!!!
        ' If 0 = 1 Then
        If FTP_Path <> "" Then
            Dim request =
           DirectCast(WebRequest.Create(FTP_Path), FtpWebRequest)

            request.Credentials =
                New NetworkCredential(Login, Password)

            request.Method = WebRequestMethods.Ftp.ListDirectory

            Try
                Using response As FtpWebResponse =
                DirectCast(request.GetResponse(), FtpWebResponse)
                    ' Folder exists here
                    Ftp_Exist = True
                End Using

            Catch ex As WebException

                Dim response As FtpWebResponse =
                DirectCast(ex.Response, FtpWebResponse)
                'Does not exist
                If response.StatusCode =
                FtpStatusCode.ActionNotTakenFileUnavailable Then
                    Ftp_Exist = False
                End If
            End Try
        Else
            Ftp_Exist = False
        End If
        ' End If
    End Function

    Public Function IsConnectedToInternet() As Boolean
        If My.Computer.Network.IsAvailable Then
            Try
                Dim IPHost As IPHostEntry = Dns.GetHostEntry("www.google.com")
                Return True
            Catch
                Return False
            End Try
        Else
            Return False
        End If
    End Function



    Function IsFileOpen(ByVal file As FileInfo) As Boolean
        Dim stream As FileStream = Nothing
        IsFileOpen = False
        Try
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            stream.Close()
        Catch ex As Exception
            'Debug.Print(ex.Message)
            If TypeOf ex Is IOException AndAlso IsFileLocked(ex) Then
                IsFileOpen = True ' do something here, either close the file if you have a handle, show a msgbox, retry  or as a last resort terminate the process - which could cause corruption and lose data
            End If
        End Try
    End Function

    Public Function IsFileLocked(exception As Exception) As Boolean
        Dim errorCode As Integer = Marshal.GetHRForException(exception) And ((1 << 16) - 1)
        Return errorCode = 32 OrElse errorCode = 33
    End Function


    Public Function Sprawdz_Plik(Plik As String) As String
        Dim Nazwa_Pliku
        Sprawdz_Plik = ""
        Dim Licznik_Bledow As Integer = 0
        Nazwa_Pliku = System.IO.Path.GetFileName(Plik)
        'Sprawdzenie czy to plik pdf
        If Not UCase(Mid(Plik, Plik.Length - 3, 4)) = UCase(".pdf") Then
            Licznik_Bledow = Licznik_Bledow + 1
            Sprawdz_Plik = "Not pdf file"
        End If


    End Function

    Public Function Sprawdz_Plik_FTP(Plik As String) As String
        'Sprawdź czy na pewno plik jest zgodny z formatem FTP
        Dim Nazwa_Pliku
        Sprawdz_Plik_FTP = ""
        Dim Licznik_Bledow As Integer = 0
        Nazwa_Pliku = System.IO.Path.GetFileName(Plik)


    End Function


    Public Sub Zmiana_Nazw()


        Dim Folder_Files As String = My.Forms.Form_Settings.T_Sciezka_Files.Text
        Dim Wiersz(4) As String
        Dim itm As ListViewItem
        Dim i As Integer
        Dim Nazwa_Pliku As String = ""
        Dim Nowa_Nazwa_Pliku As String = ""
        Dim Licznik As Integer = 1
        Dim Rodzaj_Bledu As String = ""
        If Not Directory.Exists(Folder_Files) Then
            Exit Sub
        End If
        Form_List.Show()

        For Each Plik As String In My.Computer.FileSystem.GetFiles(Folder_Files)
            Rodzaj_Bledu = Sprawdz_Plik(Plik)
            If Rodzaj_Bledu = "" Or Rodzaj_Bledu = "File is already renamed" Then
                'TU DAĆ PROCEDURE KTORA DOTNIE ODPOWIEDNIO NAZWĘ PLIKU!!
                If Char_Num > 0 Then
                    Nazwa_Pliku = Left(System.IO.Path.GetFileName(Plik), Char_Num)
                Else
                    Nazwa_Pliku = System.IO.Path.GetFileName(Plik)
                End If

                'LP
                Wiersz(0) = i
                'Nazwa pliku
                Wiersz(1) = Nazwa_Pliku
                'Sciezka do pliku
                Wiersz(2) = System.IO.Path.GetFullPath(Plik)
                'Nowa nazwa
                Nowa_Nazwa_Pliku = Prefix & "_" & 1 & "_" & Left(Nazwa_Pliku, 15) & ".pdf"
                Licznik = 1
                For Each item As ListViewItem In Form_List.Lista_Operacji.Items
                    If Right(item.SubItems(3).Text, 19) = Right(Nowa_Nazwa_Pliku, 19) Then
                        Licznik = Licznik + 1
                    End If
                Next
                Nowa_Nazwa_Pliku = Prefix & "_" & Licznik & "_" & Left(Nazwa_Pliku, 15) & ".pdf"

                If Rodzaj_Bledu <> "File is already renamed" Then
                    Wiersz(3) = Nowa_Nazwa_Pliku
                    My.Computer.FileSystem.RenameFile(Plik, Nowa_Nazwa_Pliku)
                Else
                    Wiersz(3) = Nazwa_Pliku
                End If

                'Status
                Wiersz(4) = "OK"
                itm = New ListViewItem(Wiersz)
                Form_List.Lista_Operacji.Items.Add(itm)
                i = i + 1

            Else
                Wiersz(0) = i
                Nazwa_Pliku = System.IO.Path.GetFileName(Plik)
                Wiersz(1) = Nazwa_Pliku
                Wiersz(2) = System.IO.Path.GetFullPath(Plik)
                Nowa_Nazwa_Pliku = ""
                Wiersz(3) = Nowa_Nazwa_Pliku
                Wiersz(4) = Rodzaj_Bledu

                itm = New ListViewItem(Wiersz)
                Form_List.Lista_Operacji.Items.Add(itm)
                i = i + 1
            End If



        Next



    End Sub
End Module
