<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInsideFile = New System.Windows.Forms.TextBox()
        Me.txtUpdated = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(11, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inside File"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Updated"
        '
        'txtInsideFile
        '
        Me.txtInsideFile.Location = New System.Drawing.Point(111, 55)
        Me.txtInsideFile.Multiline = True
        Me.txtInsideFile.Name = "txtInsideFile"
        Me.txtInsideFile.ReadOnly = True
        Me.txtInsideFile.Size = New System.Drawing.Size(677, 116)
        Me.txtInsideFile.TabIndex = 2
        '
        'txtUpdated
        '
        Me.txtUpdated.Location = New System.Drawing.Point(111, 190)
        Me.txtUpdated.Multiline = True
        Me.txtUpdated.Name = "txtUpdated"
        Me.txtUpdated.ReadOnly = True
        Me.txtUpdated.Size = New System.Drawing.Size(185, 29)
        Me.txtUpdated.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Created Date"
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(111, 234)
        Me.txtCreated.Multiline = True
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(185, 29)
        Me.txtCreated.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 278)
        Me.Controls.Add(Me.txtCreated)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUpdated)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInsideFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "Form1"
        Me.Text = "File Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInsideFile As TextBox
    Friend WithEvents txtUpdated As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCreated As TextBox
End Class
