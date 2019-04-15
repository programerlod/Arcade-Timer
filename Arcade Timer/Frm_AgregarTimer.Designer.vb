<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AgregarTimer
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
        Me.Lbl_ExeName = New System.Windows.Forms.Label()
        Me.Lbl_RutaExe = New System.Windows.Forms.Label()
        Me.Txt_ExeName = New System.Windows.Forms.TextBox()
        Me.Txt_ExePath = New System.Windows.Forms.TextBox()
        Me.Btn_Explorar = New System.Windows.Forms.Button()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Lbl_title = New System.Windows.Forms.Label()
        Me.Btn_EliminarExe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_ExeName
        '
        Me.Lbl_ExeName.AutoSize = True
        Me.Lbl_ExeName.Location = New System.Drawing.Point(27, 53)
        Me.Lbl_ExeName.Name = "Lbl_ExeName"
        Me.Lbl_ExeName.Size = New System.Drawing.Size(106, 13)
        Me.Lbl_ExeName.TabIndex = 1
        Me.Lbl_ExeName.Text = "Nombre Ejecutable : "
        '
        'Lbl_RutaExe
        '
        Me.Lbl_RutaExe.AutoSize = True
        Me.Lbl_RutaExe.Location = New System.Drawing.Point(27, 97)
        Me.Lbl_RutaExe.Name = "Lbl_RutaExe"
        Me.Lbl_RutaExe.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_RutaExe.TabIndex = 2
        Me.Lbl_RutaExe.Text = "Ruta del ejecutable : "
        '
        'Txt_ExeName
        '
        Me.Txt_ExeName.Location = New System.Drawing.Point(141, 50)
        Me.Txt_ExeName.Name = "Txt_ExeName"
        Me.Txt_ExeName.Size = New System.Drawing.Size(141, 20)
        Me.Txt_ExeName.TabIndex = 3
        '
        'Txt_ExePath
        '
        Me.Txt_ExePath.Enabled = False
        Me.Txt_ExePath.Location = New System.Drawing.Point(141, 94)
        Me.Txt_ExePath.Name = "Txt_ExePath"
        Me.Txt_ExePath.Size = New System.Drawing.Size(247, 20)
        Me.Txt_ExePath.TabIndex = 4
        '
        'Btn_Explorar
        '
        Me.Btn_Explorar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Explorar.Location = New System.Drawing.Point(394, 92)
        Me.Btn_Explorar.Name = "Btn_Explorar"
        Me.Btn_Explorar.Size = New System.Drawing.Size(30, 23)
        Me.Btn_Explorar.TabIndex = 5
        Me.Btn_Explorar.Text = "..."
        Me.Btn_Explorar.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Aceptar.FlatAppearance.BorderSize = 0
        Me.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Aceptar.Location = New System.Drawing.Point(268, 137)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Aceptar.TabIndex = 6
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Cancelar.Location = New System.Drawing.Point(349, 137)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 7
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Lbl_title
        '
        Me.Lbl_title.AutoSize = True
        Me.Lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_title.Location = New System.Drawing.Point(27, 9)
        Me.Lbl_title.Name = "Lbl_title"
        Me.Lbl_title.Size = New System.Drawing.Size(156, 17)
        Me.Lbl_title.TabIndex = 8
        Me.Lbl_title.Text = "Agregar nuevo timer"
        '
        'Btn_EliminarExe
        '
        Me.Btn_EliminarExe.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_EliminarExe.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarExe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_EliminarExe.Location = New System.Drawing.Point(323, 48)
        Me.Btn_EliminarExe.Name = "Btn_EliminarExe"
        Me.Btn_EliminarExe.Size = New System.Drawing.Size(101, 23)
        Me.Btn_EliminarExe.TabIndex = 9
        Me.Btn_EliminarExe.Text = "Borrar Registro"
        Me.Btn_EliminarExe.UseVisualStyleBackColor = False
        Me.Btn_EliminarExe.Visible = False
        '
        'Frm_AgregarTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(453, 186)
        Me.Controls.Add(Me.Btn_EliminarExe)
        Me.Controls.Add(Me.Lbl_title)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.Btn_Explorar)
        Me.Controls.Add(Me.Txt_ExePath)
        Me.Controls.Add(Me.Txt_ExeName)
        Me.Controls.Add(Me.Lbl_RutaExe)
        Me.Controls.Add(Me.Lbl_ExeName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_AgregarTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_ExeName As System.Windows.Forms.Label
    Friend WithEvents Lbl_RutaExe As System.Windows.Forms.Label
    Friend WithEvents Txt_ExeName As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ExePath As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Explorar As System.Windows.Forms.Button
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_title As System.Windows.Forms.Label
    Friend WithEvents Btn_EliminarExe As System.Windows.Forms.Button
End Class
