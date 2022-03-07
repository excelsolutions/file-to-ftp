<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_About))
        Me.Btn_Zamknij = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkMail = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.L_Wersja = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Zamknij
        '
        Me.Btn_Zamknij.Location = New System.Drawing.Point(207, 290)
        Me.Btn_Zamknij.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Zamknij.Name = "Btn_Zamknij"
        Me.Btn_Zamknij.Size = New System.Drawing.Size(248, 54)
        Me.Btn_Zamknij.TabIndex = 15
        Me.Btn_Zamknij.Text = "Close"
        Me.Btn_Zamknij.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "mail:"
        '
        'LinkMail
        '
        Me.LinkMail.AutoSize = True
        Me.LinkMail.Location = New System.Drawing.Point(70, 42)
        Me.LinkMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkMail.Name = "LinkMail"
        Me.LinkMail.Size = New System.Drawing.Size(220, 20)
        Me.LinkMail.TabIndex = 3
        Me.LinkMail.TabStop = True
        Me.LinkMail.Text = "lukasz.r.morawski@gmail.com"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(4, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 48)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Main task of this program is sending files to FTP."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.L_Wersja)
        Me.GroupBox3.Location = New System.Drawing.Point(153, 97)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(302, 97)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "About author"
        '
        'L_Wersja
        '
        Me.L_Wersja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Wersja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Wersja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Wersja.ForeColor = System.Drawing.Color.Black
        Me.L_Wersja.Location = New System.Drawing.Point(4, 24)
        Me.L_Wersja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Wersja.Name = "L_Wersja"
        Me.L_Wersja.Size = New System.Drawing.Size(294, 68)
        Me.L_Wersja.TabIndex = 10
        Me.L_Wersja.Text = "Software developer, Excel trainer and IT consultant. Solutions in Excel, VBA, VB." &
    "NET."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LinkMail)
        Me.GroupBox2.Location = New System.Drawing.Point(152, 203)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(302, 77)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(302, 77)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About program"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FileToFTP.My.Resources.Resources.p1080372
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form_About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 351)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Zamknij)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_About"
        Me.Text = "About FileToFTP"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Zamknij As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkMail As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents L_Wersja As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
