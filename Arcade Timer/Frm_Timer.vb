Imports System.Runtime.InteropServices
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Navigation

Public Class Frm_Timer

    Private WithEvents MyNotifyIcon As New NotifyIcon
    Private NotifMenuItem As New ContextMenu
    Private bSalir As Boolean = False
    Public Shared iTiempoRest As Integer = 0
    Public Shared bMonedaDepositada As Boolean = False
    Private iMinxMoneda As Integer = 1
    Public Const sConn As String = "Data Source=Data\ArcadeTimer.s3db;Version=3"
    Public Shared Dt_SegParametros As New DataTable
    Private bMenuExpanded As Boolean = True
    'Public Shared bEsArranque As Boolean = True

    ''' <summary>
    ''' Los siguientes dos procesos nos perminte mover el formulario desde la barra de iconos personalizada.
    ''' </summary>
    ''' <remarks></remarks>
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Maximizar_Click(sender As Object, e As EventArgs) Handles Btn_Maximizar.Click
        Btn_Maximizar.Visible = False
        Btn_Restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btn_Restaurar_Click(sender As Object, e As EventArgs) Handles Btn_Restaurar.Click
        Btn_Restaurar.Visible = False
        Btn_Maximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Pnl_Ventana_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Ventana.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Pic_HideMenu_Click(sender As Object, e As EventArgs)
        If Pnl_Menu.Width = 172 Then
            Pnl_Menu.Width = 63
        Else
            Pnl_Menu.Width = 172
        End If
    End Sub

    ''' <summary>
    ''' Abrimos un formulario dentro de un panel
    ''' </summary>
    ''' <param name="Formhijo"></param>
    ''' <remarks></remarks>
    Public Sub AbrirFomEnPanel(ByVal Formhijo As Object)

        If Me.Pnl_ContainerForm.Controls.Count > 0 Then
            TryCast(Pnl_ContainerForm.Controls(0), Form).Close()
            'Me.Pnl_ContainerForm.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Pnl_ContainerForm.Controls.Add(fh)
        Me.Pnl_ContainerForm.Tag = fh
        fh.Show()

    End Sub

    Private Sub Frm_Timer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Cerramos el ultimo formulario hijo
        TryCast(Pnl_ContainerForm.Controls(0), Form).Close()
    End Sub

    Private Sub Frm_Timer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Eliminamos las referencias a los iconos de notificacion.
        MyNotifyIcon.Visible = False
        MyNotifyIcon = Nothing
        NotifMenuItem = Nothing
    End Sub

    Private Sub Frm_Timer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            'Agregamos los segundos al tiempo restante.
            If e.KeyCode = Keys.Z And Pnl_ContainerForm.Controls(0).Name = "Frm_Monitoreo" Then
                iTiempoRest += iMinxMoneda * 60
                bMonedaDepositada = True
                'MessageBox.Show("Moneda Despositada :)")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Timer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            'Agregamos los items a los menus, para asigarlos al icono de notificacion.
            NotifMenuItem.MenuItems.Add("&Restaurar", New EventHandler(AddressOf MyNotifyIcon_DoubleClick))
            NotifMenuItem.MenuItems(0).DefaultItem = True

            NotifMenuItem.MenuItems.Add("-")
            NotifMenuItem.MenuItems.Add("&Acerca de...", New EventHandler(AddressOf AcercaDe_Click))

            NotifMenuItem.MenuItems.Add("-")
            NotifMenuItem.MenuItems.Add("&Salir", New EventHandler(AddressOf Salir_Click))

            'Configuramos el icono de notificacion.
            With MyNotifyIcon
                .Icon = Me.Icon
                .ContextMenu = Me.NotifMenuItem
                .Text = Application.ProductName
                .Visible = True
            End With

            'Le indicamos al sistema que debe arrancar minimizado
            Me.WindowState = FormWindowState.Normal

            'Obtenemos los parametros del sistema.
            Dt_SegParametros = LeerDatos(sConn, "SELECT * FROM SegParametros WHERE Id = 1")

            'Validamos si se logro obtener los parametros.
            If Dt_SegParametros.Rows.Count = 0 Then
                Throw New ArgumentException("No se pudieron obtener los parametros principales del sistema")
            End If

            iMinxMoneda = Dt_SegParametros.Rows(0).Item("MinxMoneda")

            'Mostramos el timer, si es que esta activo para visualizacion
            If Convert.ToInt32(Frm_Timer.Dt_SegParametros.Rows(0).Item("MostrarTiempo")) Then
                'Tim_Clock.Enabled = True
                'Tim_Clock.Start()

                Dim fClock As Form = New Frm_Clock
                fClock.StartPosition = FormStartPosition.Manual
                fClock.Location = GetLocation(Dt_SegParametros.Rows(0).Item("UbicacionTiempo").ToString.Trim)
                fClock.TopMost = True
                fClock.TopLevel = True
                fClock.TransparencyKey = Color.FromArgb(253, 253, 253)
                fClock.Show()

            End If

            AccordionControl1.SelectElement(AccordionControl1.Elements(0))

        Catch ex As Exception
            MessageBox.Show("Problemas al cargar el formulario, Error: " & ex.Message)
            Me.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Obtiene la nueva ubicacion del temporizador.
    ''' </summary>
    ''' <returns>La nueva ubicacion</returns>
    ''' <remarks></remarks>
    Private Function GetLocation(ByVal sUbicacion As String) As Point
        Try

            Dim scr As Screen = Screen.FromPoint(Cursor.Position)
            Dim Pnt As Point

            Frm_Clock.StartPosition = FormStartPosition.Manual

            Select Case sUbicacion
                Case "TL"
                    Pnt = New Point(0, 0)
                Case "TR"
                    Pnt = New Point(scr.WorkingArea.Right - Frm_Clock.Size.Width, 0)
                Case "BL"
                    Pnt = New Point(0, scr.WorkingArea.Bottom - Frm_Clock.Size.Height)
                Case "BR"
                    Pnt = New Point(scr.WorkingArea.Right - Frm_Clock.Size.Width, scr.WorkingArea.Bottom - Frm_Clock.Size.Height)
            End Select

            Return Pnt

        Catch ex As Exception
            Throw New ArgumentException("Problemas al obtener la nueva ubicacion del temporizador, Error: " & ex.Message)
        End Try
    End Function

    Private Sub Salir_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Me.Close()


        Catch ex As Exception
            MessageBox.Show("Problemas al cerrar la aplicacion, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AcercaDe_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el dialogo Acerca De, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Frm_Timer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
        End If
    End Sub

    Private Sub Frm_Timer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Minimized
        AbrirFomEnPanel(New Frm_Monitoreo)
    End Sub

    Private Sub MyNotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles MyNotifyIcon.DoubleClick
        Try
            Show()
            Me.WindowState = FormWindowState.Normal
            Activate()
        Catch ex As Exception
            MessageBox.Show("Problemas al restaurar el formulario, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Tim_Clock_Tick(sender As Object, e As EventArgs) Handles Tim_Clock.Tick

        Dim fClock As Form = New Frm_Clock

        Try

            fClock.StartPosition = FormStartPosition.Manual
            fClock.Location = GetLocation(Dt_SegParametros.Rows(0).Item("UbicacionTiempo").ToString.Trim)
            fClock.TopMost = True
            fClock.TopLevel = True
            fClock.TransparencyKey = Color.FromArgb(253, 253, 253)
            fClock.Show()

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el formulario del temporizador, Error: " & ex.Message)
        Finally
            'fClock.Dispose()
            'GC.Collect()
        End Try
    End Sub


    Private Sub AccordionControl1_StateChanged(sender As Object, e As EventArgs) Handles AccordionControl1.StateChanged
        If bMenuExpanded Then
            Pnl_Menu.Width = 63
            bMenuExpanded = False
        Else
            Pnl_Menu.Width = 172
            bMenuExpanded = True
        End If
    End Sub

    Private Sub Ace_StartUp_Click(sender As Object, e As EventArgs) Handles Ace_StartUp.Click
        Dim NewStartUp As New StartUp
        Dim MyFrm_StartUp As New Frm_StartUp

        Try

            NewStartUp.Ruta = String.Empty
            NewStartUp.Ejecutar = False
            NewStartUp.CerrarAlSalir = False
            MyFrm_StartUp.MyStartUp = NewStartUp
            AbrirFomEnPanel(MyFrm_StartUp)

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el formulario, Error: " & ex.Message)
        Finally
            NewStartUp.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub Ace_AddEditExe_Click(sender As Object, e As EventArgs) Handles Ace_AddEditExe.Click
        Dim Dlg_AddTimer As New Frm_AgregarTimer
        Dim NewTime As New TimeMonitor

        Try

            NewTime.ExeName = String.Empty
            NewTime.ExePath = String.Empty
            Dlg_AddTimer.EditTimeMonitor = NewTime
            AbrirFomEnPanel(Dlg_AddTimer)

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el formulario, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Ace_Config_Click(sender As Object, e As EventArgs) Handles Ace_Config.Click
        Try

            AbrirFomEnPanel(New Frm_Config)

        Catch ex As Exception
            MessageBox.Show("Problemas al mostar el formulario de configuracion, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Ace_Temporizador_Click(sender As Object, e As EventArgs) Handles Ace_Temporizador.Click
        Try

            AbrirFomEnPanel(New Frm_Monitoreo)

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el monitoreo, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Ace_About_Click(sender As Object, e As EventArgs) Handles Ace_About.Click
        Try

            AbrirFomEnPanel(New Frm_About)

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el monitoreo, Error: " & ex.Message)
        End Try
    End Sub
End Class
