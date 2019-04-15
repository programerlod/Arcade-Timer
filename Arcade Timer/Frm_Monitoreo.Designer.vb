<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Monitoreo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Monitoreo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPag_Monitor = New System.Windows.Forms.TabPage()
        Me.wmp_reproductor = New AxWMPLib.AxWindowsMediaPlayer()
        Me.LView_Monitor = New System.Windows.Forms.ListView()
        Me.Emulador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ejecutable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TaskId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPag_Procesos = New System.Windows.Forms.TabPage()
        Me.Btn_KillProcess = New System.Windows.Forms.Button()
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.Txt_NewProcess = New System.Windows.Forms.TextBox()
        Me.Lbl_IniciarProceso = New System.Windows.Forms.Label()
        Me.LView_Procesos = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Memoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Trabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Inicializado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPag_Iniciar = New System.Windows.Forms.TabPage()
        Me.LView_Iniciar = New System.Windows.Forms.ListView()
        Me.ExePath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ejecutar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CerrarAlSalir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tim_Monitor = New System.Windows.Forms.Timer(Me.components)
        Me.Tim_Procesos = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPag_Monitor.SuspendLayout()
        CType(Me.wmp_reproductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPag_Procesos.SuspendLayout()
        Me.TabPag_Iniciar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPag_Monitor)
        Me.TabControl1.Controls.Add(Me.TabPag_Procesos)
        Me.TabControl1.Controls.Add(Me.TabPag_Iniciar)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(543, 252)
        Me.TabControl1.TabIndex = 0
        '
        'TabPag_Monitor
        '
        Me.TabPag_Monitor.Controls.Add(Me.wmp_reproductor)
        Me.TabPag_Monitor.Controls.Add(Me.LView_Monitor)
        Me.TabPag_Monitor.Location = New System.Drawing.Point(4, 22)
        Me.TabPag_Monitor.Name = "TabPag_Monitor"
        Me.TabPag_Monitor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPag_Monitor.Size = New System.Drawing.Size(535, 226)
        Me.TabPag_Monitor.TabIndex = 0
        Me.TabPag_Monitor.Text = "Monitor"
        Me.TabPag_Monitor.UseVisualStyleBackColor = True
        '
        'wmp_reproductor
        '
        Me.wmp_reproductor.Enabled = True
        Me.wmp_reproductor.Location = New System.Drawing.Point(454, 197)
        Me.wmp_reproductor.Name = "wmp_reproductor"
        Me.wmp_reproductor.OcxState = CType(resources.GetObject("wmp_reproductor.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp_reproductor.Size = New System.Drawing.Size(75, 23)
        Me.wmp_reproductor.TabIndex = 2
        Me.wmp_reproductor.Visible = False
        '
        'LView_Monitor
        '
        Me.LView_Monitor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LView_Monitor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Emulador, Me.Ejecutable, Me.Estatus, Me.TaskId})
        Me.LView_Monitor.FullRowSelect = True
        Me.LView_Monitor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LView_Monitor.Location = New System.Drawing.Point(6, 6)
        Me.LView_Monitor.Name = "LView_Monitor"
        Me.LView_Monitor.Size = New System.Drawing.Size(523, 214)
        Me.LView_Monitor.TabIndex = 1
        Me.LView_Monitor.UseCompatibleStateImageBehavior = False
        Me.LView_Monitor.View = System.Windows.Forms.View.Details
        '
        'Emulador
        '
        Me.Emulador.Text = "Emulador"
        Me.Emulador.Width = 100
        '
        'Ejecutable
        '
        Me.Ejecutable.Text = "Ejecutable"
        Me.Ejecutable.Width = 320
        '
        'Estatus
        '
        Me.Estatus.Text = "Estatus"
        Me.Estatus.Width = 75
        '
        'TaskId
        '
        Me.TaskId.Text = "Task Id"
        Me.TaskId.Width = 50
        '
        'TabPag_Procesos
        '
        Me.TabPag_Procesos.Controls.Add(Me.Btn_KillProcess)
        Me.TabPag_Procesos.Controls.Add(Me.Btn_Start)
        Me.TabPag_Procesos.Controls.Add(Me.Txt_NewProcess)
        Me.TabPag_Procesos.Controls.Add(Me.Lbl_IniciarProceso)
        Me.TabPag_Procesos.Controls.Add(Me.LView_Procesos)
        Me.TabPag_Procesos.Location = New System.Drawing.Point(4, 22)
        Me.TabPag_Procesos.Name = "TabPag_Procesos"
        Me.TabPag_Procesos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPag_Procesos.Size = New System.Drawing.Size(535, 226)
        Me.TabPag_Procesos.TabIndex = 1
        Me.TabPag_Procesos.Text = "Procesos"
        Me.TabPag_Procesos.UseVisualStyleBackColor = True
        '
        'Btn_KillProcess
        '
        Me.Btn_KillProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_KillProcess.Location = New System.Drawing.Point(367, 196)
        Me.Btn_KillProcess.Name = "Btn_KillProcess"
        Me.Btn_KillProcess.Size = New System.Drawing.Size(162, 23)
        Me.Btn_KillProcess.TabIndex = 4
        Me.Btn_KillProcess.Text = "Finalizar proceso seleccionado"
        Me.Btn_KillProcess.UseVisualStyleBackColor = True
        '
        'Btn_Start
        '
        Me.Btn_Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Start.Location = New System.Drawing.Point(269, 196)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Start.TabIndex = 3
        Me.Btn_Start.Text = "Iniciar"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'Txt_NewProcess
        '
        Me.Txt_NewProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txt_NewProcess.Location = New System.Drawing.Point(102, 198)
        Me.Txt_NewProcess.Name = "Txt_NewProcess"
        Me.Txt_NewProcess.Size = New System.Drawing.Size(161, 20)
        Me.Txt_NewProcess.TabIndex = 2
        '
        'Lbl_IniciarProceso
        '
        Me.Lbl_IniciarProceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_IniciarProceso.AutoSize = True
        Me.Lbl_IniciarProceso.Location = New System.Drawing.Point(6, 201)
        Me.Lbl_IniciarProceso.Name = "Lbl_IniciarProceso"
        Me.Lbl_IniciarProceso.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_IniciarProceso.TabIndex = 1
        Me.Lbl_IniciarProceso.Text = "Nuevo Proceso : "
        '
        'LView_Procesos
        '
        Me.LView_Procesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LView_Procesos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Memoria, Me.Trabajo, Me.Inicializado, Me.Id})
        Me.LView_Procesos.FullRowSelect = True
        Me.LView_Procesos.Location = New System.Drawing.Point(6, 6)
        Me.LView_Procesos.Name = "LView_Procesos"
        Me.LView_Procesos.Size = New System.Drawing.Size(526, 181)
        Me.LView_Procesos.TabIndex = 0
        Me.LView_Procesos.UseCompatibleStateImageBehavior = False
        Me.LView_Procesos.View = System.Windows.Forms.View.Details
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 100
        '
        'Memoria
        '
        Me.Memoria.Text = "Memoria"
        Me.Memoria.Width = 100
        '
        'Trabajo
        '
        Me.Trabajo.Text = "Trabajo"
        Me.Trabajo.Width = 100
        '
        'Inicializado
        '
        Me.Inicializado.Text = "Inizializado"
        Me.Inicializado.Width = 150
        '
        'Id
        '
        Me.Id.Text = "Id"
        Me.Id.Width = 65
        '
        'TabPag_Iniciar
        '
        Me.TabPag_Iniciar.Controls.Add(Me.LView_Iniciar)
        Me.TabPag_Iniciar.Location = New System.Drawing.Point(4, 22)
        Me.TabPag_Iniciar.Name = "TabPag_Iniciar"
        Me.TabPag_Iniciar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPag_Iniciar.Size = New System.Drawing.Size(535, 226)
        Me.TabPag_Iniciar.TabIndex = 2
        Me.TabPag_Iniciar.Text = "Abrir al Iniciar"
        Me.TabPag_Iniciar.UseVisualStyleBackColor = True
        '
        'LView_Iniciar
        '
        Me.LView_Iniciar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LView_Iniciar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ExePath, Me.Ejecutar, Me.CerrarAlSalir})
        Me.LView_Iniciar.FullRowSelect = True
        Me.LView_Iniciar.Location = New System.Drawing.Point(3, 3)
        Me.LView_Iniciar.Name = "LView_Iniciar"
        Me.LView_Iniciar.Size = New System.Drawing.Size(529, 223)
        Me.LView_Iniciar.TabIndex = 0
        Me.LView_Iniciar.UseCompatibleStateImageBehavior = False
        Me.LView_Iniciar.View = System.Windows.Forms.View.Details
        '
        'ExePath
        '
        Me.ExePath.Text = "Ruta"
        Me.ExePath.Width = 300
        '
        'Ejecutar
        '
        Me.Ejecutar.Text = "Ejecutar al Iniciar"
        Me.Ejecutar.Width = 100
        '
        'CerrarAlSalir
        '
        Me.CerrarAlSalir.Text = "Cerrar al Salir"
        Me.CerrarAlSalir.Width = 80
        '
        'Tim_Monitor
        '
        '
        'Tim_Procesos
        '
        '
        'Frm_Monitoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(564, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Monitoreo"
        Me.Text = "Frm_Monitoreo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPag_Monitor.ResumeLayout(False)
        CType(Me.wmp_reproductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPag_Procesos.ResumeLayout(False)
        Me.TabPag_Procesos.PerformLayout()
        Me.TabPag_Iniciar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPag_Monitor As System.Windows.Forms.TabPage
    Friend WithEvents TabPag_Procesos As System.Windows.Forms.TabPage
    Friend WithEvents LView_Monitor As System.Windows.Forms.ListView
    Friend WithEvents Emulador As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ejecutable As System.Windows.Forms.ColumnHeader
    Friend WithEvents Estatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents TaskId As System.Windows.Forms.ColumnHeader
    Friend WithEvents LView_Procesos As System.Windows.Forms.ListView
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Memoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents Trabajo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Inicializado As System.Windows.Forms.ColumnHeader
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents Btn_KillProcess As System.Windows.Forms.Button
    Friend WithEvents Btn_Start As System.Windows.Forms.Button
    Friend WithEvents Txt_NewProcess As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_IniciarProceso As System.Windows.Forms.Label
    Friend WithEvents Tim_Monitor As System.Windows.Forms.Timer
    Friend WithEvents Tim_Procesos As System.Windows.Forms.Timer
    Friend WithEvents wmp_reproductor As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TabPag_Iniciar As System.Windows.Forms.TabPage
    Friend WithEvents LView_Iniciar As System.Windows.Forms.ListView
    Friend WithEvents ExePath As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ejecutar As System.Windows.Forms.ColumnHeader
    Friend WithEvents CerrarAlSalir As System.Windows.Forms.ColumnHeader
End Class
