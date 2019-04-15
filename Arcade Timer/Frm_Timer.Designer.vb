<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Timer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Timer))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.Pnl_Ventana = New System.Windows.Forms.Panel()
        Me.Btn_Minimizar = New System.Windows.Forms.Button()
        Me.Btn_Restaurar = New System.Windows.Forms.Button()
        Me.Btn_Maximizar = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Pnl_Menu = New System.Windows.Forms.Panel()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.Ace_Temporizador = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Ace_AddEditExe = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Ace_StartUp = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Ace_Config = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Ace_About = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Pnl_ContainerForm = New System.Windows.Forms.Panel()
        Me.Tim_Monitor = New System.Windows.Forms.Timer(Me.components)
        Me.Tim_Clock = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl_Ventana.SuspendLayout()
        Me.Pnl_Menu.SuspendLayout()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_Ventana
        '
        Me.Pnl_Ventana.BackColor = System.Drawing.Color.Black
        Me.Pnl_Ventana.Controls.Add(Me.Btn_Minimizar)
        Me.Pnl_Ventana.Controls.Add(Me.Btn_Restaurar)
        Me.Pnl_Ventana.Controls.Add(Me.Btn_Maximizar)
        Me.Pnl_Ventana.Controls.Add(Me.Btn_Cerrar)
        Me.Pnl_Ventana.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Ventana.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Ventana.Name = "Pnl_Ventana"
        Me.Pnl_Ventana.Size = New System.Drawing.Size(766, 41)
        Me.Pnl_Ventana.TabIndex = 0
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.Btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimizar.Image = Global.Arcade_Timer.My.Resources.Resources.Icono_Minimizar
        Me.Btn_Minimizar.Location = New System.Drawing.Point(634, 0)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Minimizar.TabIndex = 2
        Me.Btn_Minimizar.UseVisualStyleBackColor = True
        '
        'Btn_Restaurar
        '
        Me.Btn_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Restaurar.FlatAppearance.BorderSize = 0
        Me.Btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Restaurar.Image = Global.Arcade_Timer.My.Resources.Resources.Icono_Restaurar
        Me.Btn_Restaurar.Location = New System.Drawing.Point(680, 0)
        Me.Btn_Restaurar.Name = "Btn_Restaurar"
        Me.Btn_Restaurar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Restaurar.TabIndex = 1
        Me.Btn_Restaurar.UseVisualStyleBackColor = True
        Me.Btn_Restaurar.Visible = False
        '
        'Btn_Maximizar
        '
        Me.Btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximizar.FlatAppearance.BorderSize = 0
        Me.Btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Maximizar.Image = Global.Arcade_Timer.My.Resources.Resources.Icono_Maximizar
        Me.Btn_Maximizar.Location = New System.Drawing.Point(680, 0)
        Me.Btn_Maximizar.Name = "Btn_Maximizar"
        Me.Btn_Maximizar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Maximizar.TabIndex = 0
        Me.Btn_Maximizar.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Image = Global.Arcade_Timer.My.Resources.Resources.Icono_cerrar_FN
        Me.Btn_Cerrar.Location = New System.Drawing.Point(726, 0)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Cerrar.TabIndex = 0
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Pnl_Menu
        '
        Me.Pnl_Menu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Menu.Controls.Add(Me.AccordionControl1)
        Me.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_Menu.Location = New System.Drawing.Point(0, 41)
        Me.Pnl_Menu.Name = "Pnl_Menu"
        Me.Pnl_Menu.Size = New System.Drawing.Size(172, 360)
        Me.Pnl_Menu.TabIndex = 1
        '
        'AccordionControl1
        '
        Me.AccordionControl1.AllowItemSelection = True
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.Ace_Temporizador, Me.Ace_AddEditExe, Me.Ace_StartUp, Me.Ace_Config, Me.Ace_About})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 0)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.OptionsMinimizing.NormalWidth = 170
        Me.AccordionControl1.Size = New System.Drawing.Size(170, 358)
        Me.AccordionControl1.TabIndex = 0
        Me.AccordionControl1.Text = "AccordionControl1"
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'Ace_Temporizador
        '
        Me.Ace_Temporizador.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text)})
        Me.Ace_Temporizador.ImageOptions.Image = CType(resources.GetObject("Ace_Temporizador.ImageOptions.Image"), System.Drawing.Image)
        Me.Ace_Temporizador.Name = "Ace_Temporizador"
        Me.Ace_Temporizador.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        ToolTipTitleItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Text = "Temporizador"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = " "
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.Ace_Temporizador.SuperTip = SuperToolTip1
        Me.Ace_Temporizador.Text = "Temporizador"
        '
        'Ace_AddEditExe
        '
        Me.Ace_AddEditExe.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text)})
        Me.Ace_AddEditExe.ImageOptions.Image = CType(resources.GetObject("Ace_AddEditExe.ImageOptions.Image"), System.Drawing.Image)
        Me.Ace_AddEditExe.Name = "Ace_AddEditExe"
        Me.Ace_AddEditExe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        ToolTipTitleItem3.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipTitleItem3.Text = "Agregar / Editar Ejecutables"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Aqui es donde se agregan los ejecutables que el sistema tiene que monitorizar."
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = " "
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip2.Items.Add(ToolTipTitleItem4)
        Me.Ace_AddEditExe.SuperTip = SuperToolTip2
        Me.Ace_AddEditExe.Text = "Agregar / Editar Ejecutable"
        '
        'Ace_StartUp
        '
        Me.Ace_StartUp.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text)})
        Me.Ace_StartUp.ImageOptions.Image = CType(resources.GetObject("Ace_StartUp.ImageOptions.Image"), System.Drawing.Image)
        Me.Ace_StartUp.Name = "Ace_StartUp"
        Me.Ace_StartUp.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        ToolTipTitleItem5.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipTitleItem5.Text = "Abrir la iniciar"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Aqui se agregan todos los ejecutables que necesitamos se abran al iniciar nuestra" & _
    " aplicacion."
        ToolTipTitleItem6.LeftIndent = 6
        ToolTipTitleItem6.Text = " "
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip3.Items.Add(ToolTipTitleItem6)
        Me.Ace_StartUp.SuperTip = SuperToolTip3
        Me.Ace_StartUp.Text = "Abrir al Iniciar"
        '
        'Ace_Config
        '
        Me.Ace_Config.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text)})
        Me.Ace_Config.ImageOptions.Image = CType(resources.GetObject("Ace_Config.ImageOptions.Image"), System.Drawing.Image)
        Me.Ace_Config.Name = "Ace_Config"
        Me.Ace_Config.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        ToolTipTitleItem7.ImageOptions.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        ToolTipTitleItem7.Text = "Configuracion"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "En este apartado se realiza la configuracion del comportamiento del sistema, como" & _
    " los sonidos, minutos por moneda, tiempos de ejecucion de las alertas etc."
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = " "
        SuperToolTip4.Items.Add(ToolTipTitleItem7)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip4.Items.Add(ToolTipTitleItem8)
        Me.Ace_Config.SuperTip = SuperToolTip4
        Me.Ace_Config.Text = "Configuracion"
        '
        'Ace_About
        '
        Me.Ace_About.ImageOptions.Image = CType(resources.GetObject("Ace_About.ImageOptions.Image"), System.Drawing.Image)
        Me.Ace_About.Name = "Ace_About"
        Me.Ace_About.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        ToolTipTitleItem9.ImageOptions.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        ToolTipTitleItem9.Text = "Acerca De"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Se muestra la informacion de la aplicacion y redes sociales."
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = " "
        SuperToolTip5.Items.Add(ToolTipTitleItem9)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip5.Items.Add(ToolTipTitleItem10)
        Me.Ace_About.SuperTip = SuperToolTip5
        Me.Ace_About.Text = "Acerca de"
        '
        'Pnl_ContainerForm
        '
        Me.Pnl_ContainerForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Pnl_ContainerForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_ContainerForm.Location = New System.Drawing.Point(172, 41)
        Me.Pnl_ContainerForm.Name = "Pnl_ContainerForm"
        Me.Pnl_ContainerForm.Size = New System.Drawing.Size(594, 360)
        Me.Pnl_ContainerForm.TabIndex = 2
        '
        'Tim_Clock
        '
        Me.Tim_Clock.Interval = 1300
        '
        'Frm_Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 401)
        Me.Controls.Add(Me.Pnl_ContainerForm)
        Me.Controls.Add(Me.Pnl_Menu)
        Me.Controls.Add(Me.Pnl_Ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Timer"
        Me.Text = "Arcade Timer"
        Me.Pnl_Ventana.ResumeLayout(False)
        Me.Pnl_Menu.ResumeLayout(False)
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl_Ventana As System.Windows.Forms.Panel
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Pnl_Menu As System.Windows.Forms.Panel
    Friend WithEvents Pnl_ContainerForm As System.Windows.Forms.Panel
    Friend WithEvents Btn_Minimizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Restaurar As System.Windows.Forms.Button
    Friend WithEvents Btn_Maximizar As System.Windows.Forms.Button
    Friend WithEvents Tim_Monitor As System.Windows.Forms.Timer
    Friend WithEvents Tim_Clock As System.Windows.Forms.Timer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents Ace_Temporizador As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Ace_AddEditExe As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Ace_StartUp As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Ace_Config As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Ace_About As DevExpress.XtraBars.Navigation.AccordionControlElement

End Class
