<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Settings))
        Me.Group_FTP = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_Sciezka_FTP = New System.Windows.Forms.TextBox()
        Me.T_Haslo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_Login = New System.Windows.Forms.TextBox()
        Me.Btn_Anuluj = New System.Windows.Forms.Button()
        Me.Btn_Zapisz = New System.Windows.Forms.Button()
        Me.Group_PDF = New System.Windows.Forms.GroupBox()
        Me.T_Sciezka_Files = New System.Windows.Forms.TextBox()
        Me.Pic_PDF = New System.Windows.Forms.PictureBox()
        Me.Wybor_Pliku = New System.Windows.Forms.OpenFileDialog()
        Me.Wybor_Folderu = New System.Windows.Forms.FolderBrowserDialog()
        Me.Num_Znaki = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_Sufix = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T_Prefix = New System.Windows.Forms.TextBox()
        Me.Radio_FTP = New System.Windows.Forms.RadioButton()
        Me.Radio_SFTP = New System.Windows.Forms.RadioButton()
        Me.Group_FTP.SuspendLayout()
        Me.Group_PDF.SuspendLayout()
        CType(Me.Pic_PDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Znaki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_FTP
        '
        Me.Group_FTP.Controls.Add(Me.Radio_SFTP)
        Me.Group_FTP.Controls.Add(Me.Radio_FTP)
        Me.Group_FTP.Controls.Add(Me.Label4)
        Me.Group_FTP.Controls.Add(Me.T_Sciezka_FTP)
        Me.Group_FTP.Controls.Add(Me.T_Haslo)
        Me.Group_FTP.Controls.Add(Me.Label1)
        Me.Group_FTP.Controls.Add(Me.Label3)
        Me.Group_FTP.Controls.Add(Me.T_Login)
        Me.Group_FTP.Location = New System.Drawing.Point(18, 148)
        Me.Group_FTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_FTP.Name = "Group_FTP"
        Me.Group_FTP.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_FTP.Size = New System.Drawing.Size(724, 176)
        Me.Group_FTP.TabIndex = 15
        Me.Group_FTP.TabStop = False
        Me.Group_FTP.Text = "FTP"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(369, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Sciezka_FTP
        '
        Me.T_Sciezka_FTP.Location = New System.Drawing.Point(12, 57)
        Me.T_Sciezka_FTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Sciezka_FTP.Multiline = True
        Me.T_Sciezka_FTP.Name = "T_Sciezka_FTP"
        Me.T_Sciezka_FTP.Size = New System.Drawing.Size(606, 30)
        Me.T_Sciezka_FTP.TabIndex = 2
        '
        'T_Haslo
        '
        Me.T_Haslo.Location = New System.Drawing.Point(372, 135)
        Me.T_Haslo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Haslo.Name = "T_Haslo"
        Me.T_Haslo.Size = New System.Drawing.Size(319, 26)
        Me.T_Haslo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Address"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Login
        '
        Me.T_Login.Location = New System.Drawing.Point(12, 134)
        Me.T_Login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Login.Name = "T_Login"
        Me.T_Login.Size = New System.Drawing.Size(316, 26)
        Me.T_Login.TabIndex = 8
        '
        'Btn_Anuluj
        '
        Me.Btn_Anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Anuluj.Location = New System.Drawing.Point(33, 535)
        Me.Btn_Anuluj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Anuluj.Name = "Btn_Anuluj"
        Me.Btn_Anuluj.Size = New System.Drawing.Size(225, 57)
        Me.Btn_Anuluj.TabIndex = 19
        Me.Btn_Anuluj.Text = "Cancel"
        Me.Btn_Anuluj.UseVisualStyleBackColor = True
        '
        'Btn_Zapisz
        '
        Me.Btn_Zapisz.Location = New System.Drawing.Point(517, 535)
        Me.Btn_Zapisz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Zapisz.Name = "Btn_Zapisz"
        Me.Btn_Zapisz.Size = New System.Drawing.Size(225, 57)
        Me.Btn_Zapisz.TabIndex = 18
        Me.Btn_Zapisz.Text = "Ok"
        Me.Btn_Zapisz.UseVisualStyleBackColor = True
        '
        'Group_PDF
        '
        Me.Group_PDF.Controls.Add(Me.T_Sciezka_Files)
        Me.Group_PDF.Controls.Add(Me.Pic_PDF)
        Me.Group_PDF.Location = New System.Drawing.Point(18, 18)
        Me.Group_PDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_PDF.Name = "Group_PDF"
        Me.Group_PDF.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_PDF.Size = New System.Drawing.Size(724, 120)
        Me.Group_PDF.TabIndex = 20
        Me.Group_PDF.TabStop = False
        Me.Group_PDF.Text = "Folder with files"
        '
        'T_Sciezka_Files
        '
        Me.T_Sciezka_Files.Location = New System.Drawing.Point(9, 29)
        Me.T_Sciezka_Files.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Sciezka_Files.Multiline = True
        Me.T_Sciezka_Files.Name = "T_Sciezka_Files"
        Me.T_Sciezka_Files.Size = New System.Drawing.Size(612, 67)
        Me.T_Sciezka_Files.TabIndex = 1
        '
        'Pic_PDF
        '
        Me.Pic_PDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_PDF.Image = Global.FileToFTP.My.Resources.Resources.Folder
        Me.Pic_PDF.Location = New System.Drawing.Point(632, 29)
        Me.Pic_PDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_PDF.Name = "Pic_PDF"
        Me.Pic_PDF.Size = New System.Drawing.Size(64, 69)
        Me.Pic_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_PDF.TabIndex = 6
        Me.Pic_PDF.TabStop = False
        '
        'Wybor_Pliku
        '
        Me.Wybor_Pliku.FileName = "OpenFileDialog1"
        '
        'Num_Znaki
        '
        Me.Num_Znaki.Location = New System.Drawing.Point(14, 29)
        Me.Num_Znaki.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Znaki.Name = "Num_Znaki"
        Me.Num_Znaki.Size = New System.Drawing.Size(224, 26)
        Me.Num_Znaki.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Num_Znaki)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 440)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(724, 75)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number of characters from PDF name (0- means take whole name)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.T_Sufix)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.T_Prefix)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 331)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(724, 106)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prefix and suffix"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(372, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sufix"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Sufix
        '
        Me.T_Sufix.Location = New System.Drawing.Point(375, 60)
        Me.T_Sufix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Sufix.Name = "T_Sufix"
        Me.T_Sufix.Size = New System.Drawing.Size(319, 26)
        Me.T_Sufix.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Prefix"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Prefix
        '
        Me.T_Prefix.Location = New System.Drawing.Point(15, 58)
        Me.T_Prefix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Prefix.Name = "T_Prefix"
        Me.T_Prefix.Size = New System.Drawing.Size(316, 26)
        Me.T_Prefix.TabIndex = 8
        '
        'Radio_FTP
        '
        Me.Radio_FTP.AutoSize = True
        Me.Radio_FTP.Location = New System.Drawing.Point(631, 27)
        Me.Radio_FTP.Name = "Radio_FTP"
        Me.Radio_FTP.Size = New System.Drawing.Size(63, 24)
        Me.Radio_FTP.TabIndex = 12
        Me.Radio_FTP.TabStop = True
        Me.Radio_FTP.Text = "FTP"
        Me.Radio_FTP.UseVisualStyleBackColor = True
        '
        'Radio_SFTP
        '
        Me.Radio_SFTP.AutoSize = True
        Me.Radio_SFTP.Location = New System.Drawing.Point(631, 63)
        Me.Radio_SFTP.Name = "Radio_SFTP"
        Me.Radio_SFTP.Size = New System.Drawing.Size(74, 24)
        Me.Radio_SFTP.TabIndex = 13
        Me.Radio_SFTP.TabStop = True
        Me.Radio_SFTP.Text = "SFTP"
        Me.Radio_SFTP.UseVisualStyleBackColor = True
        '
        'Form_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 610)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Group_PDF)
        Me.Controls.Add(Me.Btn_Anuluj)
        Me.Controls.Add(Me.Btn_Zapisz)
        Me.Controls.Add(Me.Group_FTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form_Settings"
        Me.Text = "File to FTP Settings"
        Me.Group_FTP.ResumeLayout(False)
        Me.Group_FTP.PerformLayout()
        Me.Group_PDF.ResumeLayout(False)
        Me.Group_PDF.PerformLayout()
        CType(Me.Pic_PDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Znaki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Group_FTP As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents T_Sciezka_FTP As TextBox
    Friend WithEvents T_Haslo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_Login As TextBox
    Friend WithEvents Btn_Anuluj As Button
    Friend WithEvents Btn_Zapisz As Button
    Friend WithEvents Group_PDF As GroupBox
    Friend WithEvents T_Sciezka_Files As TextBox
    Friend WithEvents Pic_PDF As PictureBox
    Friend WithEvents Wybor_Pliku As OpenFileDialog
    Friend WithEvents Wybor_Folderu As FolderBrowserDialog
    Friend WithEvents Num_Znaki As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents T_Sufix As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents T_Prefix As TextBox
    Friend WithEvents Radio_SFTP As RadioButton
    Friend WithEvents Radio_FTP As RadioButton
End Class
