<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clock
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
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Tim_Refrestimer = New System.Windows.Forms.Timer(Me.components)
        Me.Tim_ShowOnTop = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Timer.ForeColor = System.Drawing.Color.White
        Me.Lbl_Timer.Location = New System.Drawing.Point(2, 3)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(173, 44)
        Me.Lbl_Timer.TabIndex = 0
        Me.Lbl_Timer.Text = "00:00:00"
        '
        'Tim_Refrestimer
        '
        Me.Tim_Refrestimer.Interval = 1000
        '
        'Tim_ShowOnTop
        '
        '
        'Frm_Clock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(175, 47)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Clock"
        Me.Text = "Frm_Clock"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Tim_Refrestimer As System.Windows.Forms.Timer
    Friend WithEvents Tim_ShowOnTop As System.Windows.Forms.Timer
End Class
