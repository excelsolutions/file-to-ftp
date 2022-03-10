<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.Btn_Send = New System.Windows.Forms.Button()
        Me.Timer_Odswiezanie = New System.Windows.Forms.Timer(Me.components)
        Me.L_Liczba_Plikow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestFTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L_Error = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_Automat = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripAutomation = New System.Windows.Forms.ToolStripSplitButton()
        Me.Pic_Lista = New System.Windows.Forms.PictureBox()
        Me.Btn_Rename_Save = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Pic_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Send
        '
        Me.Btn_Send.Location = New System.Drawing.Point(418, 63)
        Me.Btn_Send.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Send.Name = "Btn_Send"
        Me.Btn_Send.Size = New System.Drawing.Size(234, 71)
        Me.Btn_Send.TabIndex = 0
        Me.Btn_Send.Text = "Send to FTP"
        Me.Btn_Send.UseVisualStyleBackColor = True
        '
        'Timer_Odswiezanie
        '
        Me.Timer_Odswiezanie.Enabled = True
        Me.Timer_Odswiezanie.Interval = 500
        '
        'L_Liczba_Plikow
        '
        Me.L_Liczba_Plikow.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Liczba_Plikow.ForeColor = System.Drawing.Color.Blue
        Me.L_Liczba_Plikow.Location = New System.Drawing.Point(78, 62)
        Me.L_Liczba_Plikow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Liczba_Plikow.Name = "L_Liczba_Plikow"
        Me.L_Liczba_Plikow.Size = New System.Drawing.Size(116, 57)
        Me.L_Liczba_Plikow.TabIndex = 1
        Me.L_Liczba_Plikow.Text = "0"
        Me.L_Liczba_Plikow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "no. of files"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(178, 34)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(178, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestFTPToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TestFTPToolStripMenuItem
        '
        Me.TestFTPToolStripMenuItem.Name = "TestFTPToolStripMenuItem"
        Me.TestFTPToolStripMenuItem.Size = New System.Drawing.Size(177, 34)
        Me.TestFTPToolStripMenuItem.Text = "Test FTP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(177, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'L_Error
        '
        Me.L_Error.ForeColor = System.Drawing.Color.Red
        Me.L_Error.Location = New System.Drawing.Point(18, 138)
        Me.L_Error.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Error.Name = "L_Error"
        Me.L_Error.Size = New System.Drawing.Size(411, 32)
        Me.L_Error.TabIndex = 6
        '
        'Timer_Automat
        '
        Me.Timer_Automat.Interval = 5000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAutomation})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 176)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(668, 32)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripAutomation
        '
        Me.ToolStripAutomation.Image = Global.FileToFTP.My.Resources.Resources.Red_Button
        Me.ToolStripAutomation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAutomation.Name = "ToolStripAutomation"
        Me.ToolStripAutomation.Size = New System.Drawing.Size(127, 29)
        Me.ToolStripAutomation.Text = "Automat"
        '
        'Pic_Lista
        '
        Me.Pic_Lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Lista.Image = Global.FileToFTP.My.Resources.Resources.Lista
        Me.Pic_Lista.Location = New System.Drawing.Point(18, 62)
        Me.Pic_Lista.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_Lista.Name = "Pic_Lista"
        Me.Pic_Lista.Size = New System.Drawing.Size(51, 71)
        Me.Pic_Lista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Lista.TabIndex = 3
        Me.Pic_Lista.TabStop = False
        '
        'Btn_Rename_Save
        '
        Me.Btn_Rename_Save.Location = New System.Drawing.Point(202, 63)
        Me.Btn_Rename_Save.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Rename_Save.Name = "Btn_Rename_Save"
        Me.Btn_Rename_Save.Size = New System.Drawing.Size(207, 69)
        Me.Btn_Rename_Save.TabIndex = 8
        Me.Btn_Rename_Save.Text = "Rename and Save"
        Me.Btn_Rename_Save.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 208)
        Me.Controls.Add(Me.Btn_Rename_Save)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.L_Error)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pic_Lista)
        Me.Controls.Add(Me.L_Liczba_Plikow)
        Me.Controls.Add(Me.Btn_Send)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.Text = "File to FTP 1.3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Pic_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Send As Button
    Friend WithEvents Timer_Odswiezanie As Timer
    Friend WithEvents L_Liczba_Plikow As Label
    Friend WithEvents Pic_Lista As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents L_Error As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer_Automat As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripAutomation As ToolStripSplitButton
    Friend WithEvents Btn_Rename_Save As Button
    Friend WithEvents TestFTPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
