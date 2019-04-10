<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnPress = New System.Windows.Forms.Button()
        Me.lstFreq = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.Location = New System.Drawing.Point(153, 73)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(143, 36)
        Me.btnPress.TabIndex = 0
        Me.btnPress.Text = "Press"
        Me.btnPress.UseVisualStyleBackColor = True
        '
        'lstFreq
        '
        Me.lstFreq.FormattingEnabled = True
        Me.lstFreq.Location = New System.Drawing.Point(153, 115)
        Me.lstFreq.Name = "lstFreq"
        Me.lstFreq.Size = New System.Drawing.Size(143, 95)
        Me.lstFreq.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 303)
        Me.Controls.Add(Me.lstFreq)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents lstFreq As ListBox
End Class
