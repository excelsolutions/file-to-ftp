<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_List
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
        Me.Lista_Operacji = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Lista_Operacji
        '
        Me.Lista_Operacji.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lista_Operacji.GridLines = True
        Me.Lista_Operacji.HideSelection = False
        Me.Lista_Operacji.Location = New System.Drawing.Point(0, 0)
        Me.Lista_Operacji.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Lista_Operacji.Name = "Lista_Operacji"
        Me.Lista_Operacji.Size = New System.Drawing.Size(1472, 954)
        Me.Lista_Operacji.TabIndex = 0
        Me.Lista_Operacji.UseCompatibleStateImageBehavior = False
        Me.Lista_Operacji.View = System.Windows.Forms.View.Details
        '
        'Form_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 954)
        Me.Controls.Add(Me.Lista_Operacji)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_List"
        Me.Text = "List of files"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lista_Operacji As ListView
End Class
