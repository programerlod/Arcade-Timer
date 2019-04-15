<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_StartUp
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
        Me.Lbl_Ruta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_RutaExe = New System.Windows.Forms.TextBox()
        Me.Chk_Ejecutar = New System.Windows.Forms.CheckBox()
        Me.Chk_Cerrar = New System.Windows.Forms.CheckBox()
        Me.Btn_Explorar = New System.Windows.Forms.Button()
        Me.Btn_AceptarStartUp = New System.Windows.Forms.Button()
        Me.Btn_CancelarStartUp = New System.Windows.Forms.Button()
        Me.Btn_EliminarStartUp = New System.Windows.Forms.Button()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Ruta
        '
        Me.Lbl_Ruta.AutoSize = True
        Me.Lbl_Ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ruta.Location = New System.Drawing.Point(19, 75)
        Me.Lbl_Ruta.Name = "Lbl_Ruta"
        Me.Lbl_Ruta.Size = New System.Drawing.Size(130, 13)
        Me.Lbl_Ruta.TabIndex = 1
        Me.Lbl_Ruta.Text = "Ruta del ejecutable : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ejecutar al iniciar : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cerrar al Salir : "
        '
        'Txt_RutaExe
        '
        Me.Txt_RutaExe.Enabled = False
        Me.Txt_RutaExe.ForeColor = System.Drawing.Color.DarkGray
        Me.Txt_RutaExe.Location = New System.Drawing.Point(150, 72)
        Me.Txt_RutaExe.Name = "Txt_RutaExe"
        Me.Txt_RutaExe.Size = New System.Drawing.Size(307, 20)
        Me.Txt_RutaExe.TabIndex = 4
        Me.Txt_RutaExe.Text = "Selecciona un archivo"
        '
        'Chk_Ejecutar
        '
        Me.Chk_Ejecutar.AutoSize = True
        Me.Chk_Ejecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Ejecutar.Location = New System.Drawing.Point(151, 122)
        Me.Chk_Ejecutar.Name = "Chk_Ejecutar"
        Me.Chk_Ejecutar.Size = New System.Drawing.Size(42, 17)
        Me.Chk_Ejecutar.TabIndex = 5
        Me.Chk_Ejecutar.Text = "No"
        Me.Chk_Ejecutar.UseVisualStyleBackColor = True
        '
        'Chk_Cerrar
        '
        Me.Chk_Cerrar.AutoSize = True
        Me.Chk_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Cerrar.Location = New System.Drawing.Point(151, 174)
        Me.Chk_Cerrar.Name = "Chk_Cerrar"
        Me.Chk_Cerrar.Size = New System.Drawing.Size(42, 17)
        Me.Chk_Cerrar.TabIndex = 6
        Me.Chk_Cerrar.Text = "No"
        Me.Chk_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Explorar
        '
        Me.Btn_Explorar.Location = New System.Drawing.Point(463, 70)
        Me.Btn_Explorar.Name = "Btn_Explorar"
        Me.Btn_Explorar.Size = New System.Drawing.Size(32, 23)
        Me.Btn_Explorar.TabIndex = 7
        Me.Btn_Explorar.Text = "..."
        Me.Btn_Explorar.UseVisualStyleBackColor = True
        '
        'Btn_AceptarStartUp
        '
        Me.Btn_AceptarStartUp.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_AceptarStartUp.FlatAppearance.BorderSize = 0
        Me.Btn_AceptarStartUp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_AceptarStartUp.ForeColor = System.Drawing.Color.Black
        Me.Btn_AceptarStartUp.Location = New System.Drawing.Point(337, 164)
        Me.Btn_AceptarStartUp.Name = "Btn_AceptarStartUp"
        Me.Btn_AceptarStartUp.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AceptarStartUp.TabIndex = 8
        Me.Btn_AceptarStartUp.Text = "Aceptar"
        Me.Btn_AceptarStartUp.UseVisualStyleBackColor = False
        '
        'Btn_CancelarStartUp
        '
        Me.Btn_CancelarStartUp.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_CancelarStartUp.FlatAppearance.BorderSize = 0
        Me.Btn_CancelarStartUp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_CancelarStartUp.ForeColor = System.Drawing.Color.Black
        Me.Btn_CancelarStartUp.Location = New System.Drawing.Point(420, 164)
        Me.Btn_CancelarStartUp.Name = "Btn_CancelarStartUp"
        Me.Btn_CancelarStartUp.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CancelarStartUp.TabIndex = 9
        Me.Btn_CancelarStartUp.Text = "Cancelar"
        Me.Btn_CancelarStartUp.UseVisualStyleBackColor = False
        '
        'Btn_EliminarStartUp
        '
        Me.Btn_EliminarStartUp.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_EliminarStartUp.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarStartUp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_EliminarStartUp.ForeColor = System.Drawing.Color.Black
        Me.Btn_EliminarStartUp.Location = New System.Drawing.Point(337, 118)
        Me.Btn_EliminarStartUp.Name = "Btn_EliminarStartUp"
        Me.Btn_EliminarStartUp.Size = New System.Drawing.Size(158, 23)
        Me.Btn_EliminarStartUp.TabIndex = 10
        Me.Btn_EliminarStartUp.Text = "Borrar Registro"
        Me.Btn_EliminarStartUp.UseVisualStyleBackColor = False
        Me.Btn_EliminarStartUp.Visible = False
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(18, 26)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(334, 20)
        Me.Lbl_Titulo.TabIndex = 11
        Me.Lbl_Titulo.Text = "Agregar nuevo ejecutable al Inicializador"
        '
        'Frm_StartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(520, 229)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Controls.Add(Me.Btn_EliminarStartUp)
        Me.Controls.Add(Me.Btn_CancelarStartUp)
        Me.Controls.Add(Me.Btn_AceptarStartUp)
        Me.Controls.Add(Me.Btn_Explorar)
        Me.Controls.Add(Me.Chk_Cerrar)
        Me.Controls.Add(Me.Chk_Ejecutar)
        Me.Controls.Add(Me.Txt_RutaExe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Ruta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_StartUp"
        Me.Text = "StartUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_RutaExe As System.Windows.Forms.TextBox
    Friend WithEvents Chk_Ejecutar As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Cerrar As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Explorar As System.Windows.Forms.Button
    Friend WithEvents Btn_AceptarStartUp As System.Windows.Forms.Button
    Friend WithEvents Btn_CancelarStartUp As System.Windows.Forms.Button
    Friend WithEvents Btn_EliminarStartUp As System.Windows.Forms.Button
    Friend WithEvents Lbl_Titulo As System.Windows.Forms.Label
End Class
