Public Class Frm_Monitoreo

    Private NewProcess As Process
    Private pi As ProcessStartInfo
    Private LocalProcess As New Process()
    Private iCountProcess As Integer = 0
    Private iLastProcSelect As Integer = 0
    Private Dt_Monitor As New DataTable
    Private Dt_StartUp As New DataTable

    Private Sub Frm_Monitoreo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try


            Dim Lvi_FoundExe As ListViewItem
            Dim ArrProc() As String

            For Each Dr_KillProc As DataRow In Dt_StartUp.Rows

                If Convert.ToBoolean(Dr_KillProc.Item("CerrarAlSalir")) Then

                    'Obtenemos el nombre del proceso a finalizar 
                    ArrProc = Split(Dr_KillProc.Item("Ruta"), "\")

                    'Buscamos el nombre del proceso en el listado.
                    Lvi_FoundExe = LView_Procesos.FindItemWithText(Mid(ArrProc(ArrProc.Length - 1).ToString.Trim, 1, ArrProc(ArrProc.Length - 1).ToString.Trim.Length - 4))

                    If Lvi_FoundExe IsNot Nothing Then
                        Process.GetProcessById(Lvi_FoundExe.SubItems(4).Text).Kill()
                    End If

                End If

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Monitoreo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            'Cargamos el monitor de emuladores.
            LoadMonitor()

            'Cargamos los procesos.
            StartLoadProcess()

            'Cargamos los ejecutables a inicializar al arrancar la aplicacion.
            LoadStartUp()

            'Confuguramos el timer.
            TimerConfig()

        Catch ex As Exception
            MessageBox.Show("Problemas al cargar el formulario, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Configuramos el timer.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TimerConfig()
        Try

            'Configuramos e inicializamos el timer para los procesos
            Tim_Procesos.Interval = 1000
            Tim_Procesos.Enabled = True
            Tim_Procesos.Start()

            'Configuramos e inicializamos el timer para el monitoreo
            If Convert.ToBoolean(Frm_Timer.Dt_SegParametros.Rows(0).Item("MonitorOn")) Then
                Tim_Monitor.Interval = 1000
                Tim_Monitor.Enabled = True
                Tim_Monitor.Start()
            Else
                Tim_Monitor.Enabled = False
                Tim_Monitor.Stop()
            End If

        Catch ex As Exception
            Throw New ArgumentException("Problemas al configurar el timer, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Se carga el listado de emuladores a monitorear
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadMonitor()
        Try

            Dim Lvi_NewItem As ListViewItem
            Dt_Monitor = LeerDatos(Frm_Timer.sConn, "SELECT * FROM ProMonitor")

            'Limpiamos el listview
            LView_Monitor.Items.Clear()

            'Agregamos los ejecutablas a monitorear
            For Each Dr_Exe As DataRow In Dt_Monitor.Rows

                Lvi_NewItem = New ListViewItem
                Lvi_NewItem.Name = Dr_Exe.Item("Ejecutable").ToString.Trim
                Lvi_NewItem.Text = Dr_Exe.Item("Ejecutable").ToString.Trim
                Lvi_NewItem.SubItems.Add(Dr_Exe.Item("Ruta").ToString.Trim)
                Lvi_NewItem.SubItems.Add(Dr_Exe.Item("Estatus").ToString.Trim)
                Lvi_NewItem.SubItems.Add("TaskId")
                LView_Monitor.Items.Add(Lvi_NewItem)

            Next

        Catch ex As Exception
            Throw New ArgumentException("Problemas al cargar el monitor de emuladores, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cargamos la informacion de los ejecutables a iniciar al arrancar la aplicacion.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadStartUp()
        Try

            Try

                Dim Lvi_NewItem As ListViewItem
                Dt_StartUp = LeerDatos(Frm_Timer.sConn, "SELECT * FROM ProEjecutarAlArranque")

                'Limpiamos el listview
                LView_Iniciar.Items.Clear()

                'Agregamos los ejecutablas a monitorear
                For Each Dr_Exe As DataRow In Dt_StartUp.Rows

                    Lvi_NewItem = New ListViewItem
                    Lvi_NewItem.Name = Dr_Exe.Item("Ruta").ToString.Trim
                    Lvi_NewItem.Text = Dr_Exe.Item("Ruta").ToString.Trim
                    Lvi_NewItem.SubItems.Add(Dr_Exe.Item("Ejecutar").ToString.Trim)
                    Lvi_NewItem.SubItems.Add(Dr_Exe.Item("CerrarAlSalir").ToString.Trim)
                    LView_Iniciar.Items.Add(Lvi_NewItem)

                    'Validamos si es el arranque de la aplicacion.
                    If Convert.ToBoolean(Dr_Exe.Item("Ejecutar")) Then

                        AbrirEjecutable(Dr_Exe.Item("Ruta").ToString.Trim)

                    End If

                Next

            Catch ex As Exception
                Throw New ArgumentException("Problemas al cargar el monitor de emuladores, Error: " & ex.Message)
            End Try

        Catch ex As Exception
            Throw New ArgumentException("Problemas al cargar la informacion de ejecutables de arranque, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Abre los ejecutables de arranque.
    ''' </summary>
    ''' <param name="sRuta">Ruta del ejecutable</param>
    ''' <remarks></remarks>
    Private Sub AbrirEjecutable(ByVal sRuta As String)

        Dim Proceso As New Process

        Try

            Proceso.StartInfo.FileName = sRuta
            Proceso.Start()

        Catch ex As Exception
            Throw New ArgumentException("Problemas al abrir los programas de arranque, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Carga todos los procesos.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub StartLoadProcess()

        Dim Lvi_FoundEmul As ListViewItem
        LView_Procesos.Items.Clear()
        iCountProcess = 0

        For Each MyProcess As Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next

            'Validamos si alguna de estas sentencias corresponde a alguno de los emuladores monitoreados.
            If LView_Monitor.Items.Count > 0 Then
                Lvi_FoundEmul = LView_Monitor.FindItemWithText(MyProcess.ProcessName)
                If Lvi_FoundEmul IsNot Nothing Then

                    'Validamos si hay tiempo restante.
                    If Frm_Timer.iTiempoRest <= 0 Then
                        'Cerramos la instancia del sistema y reproducimos el mensaje de error.
                        MyProcess.Kill()
                        MessageBox.Show("No se pudo iniciar la emulacion, primero inserte una moneda")
                        Continue For
                    End If

                    'Asignamos el id del proceso al item en cuestion.
                    LView_Monitor.Items(Lvi_FoundEmul.Index).SubItems(3).Text = MyProcess.Id
                    LView_Monitor.Items(Lvi_FoundEmul.Index).SubItems(2).Text = "Activo"
                End If
            End If

            LView_Procesos.Items.Add(MyProcess.ProcessName)
            LView_Procesos.Items(iCountProcess).SubItems.Add(FormatNumber(Math.Round(MyProcess.PrivateMemorySize64)))
            LView_Procesos.Items(iCountProcess).SubItems.Add(MyProcess.Responding)
            LView_Procesos.Items(iCountProcess).SubItems.Add(MyProcess.StartTime.ToString.Trim)
            LView_Procesos.Items(iCountProcess).SubItems.Add(MyProcess.Id)
            iCountProcess += 1

        Next


    End Sub

    ''' <summary>
    ''' Rectificamos los procesos.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindProcess()

        Dim CurrentProcess As ListViewItem
        Dim Lvi_FoundEmul As ListViewItem
        Dim Proc As Process
        Dim ArrProc() As Process
        Dim bFind As Boolean = False

        'Obtenemos los procesos actuales de la maquina.
        ArrProc = Process.GetProcesses(My.Computer.Name)

        'Primero validamos si es necesario insertar mas procesos.
        For Each MyProcess As Process In ArrProc
            On Error Resume Next

            'Obtenemos el proceso actual del listado.
            CurrentProcess = LView_Procesos.FindItemWithText(MyProcess.ProcessName)

            'Agregamos los nuevos procesos.
            If CurrentProcess Is Nothing Then

                'Validamos si alguna de estas sentencias corresponde a alguno de los emuladores monitoreados.
                If LView_Monitor.Items.Count > 0 Then
                    Lvi_FoundEmul = LView_Monitor.FindItemWithText(MyProcess.ProcessName)
                    If Lvi_FoundEmul IsNot Nothing Then

                        'Validamos si hay tiempo restante.
                        If Frm_Timer.iTiempoRest <= 0 Then

                            Lvi_FoundEmul = LView_Procesos.FindItemWithText("RocketLauncher")

                            If Lvi_FoundEmul IsNot Nothing Then
                                Process.GetProcessById(Lvi_FoundEmul.SubItems(4).Text).Kill()
                            End If

                            'Cerramos la instancia del sistema y reproducimos el mensaje de error.
                            MyProcess.Kill()

                            If Not String.IsNullOrEmpty(Frm_Timer.Dt_SegParametros.Rows(0).Item("InsertCoinSound").ToString.Trim) Then
                                wmp_reproductor.URL = Frm_Timer.Dt_SegParametros.Rows(0).Item("InsertCoinSound").ToString.Trim
                            Else
                                wmp_reproductor.URL = My.Application.Info.DirectoryPath & "\Sounds\InserteMoneda.wav"
                            End If

                            wmp_reproductor.Ctlcontrols.play()

                            Continue For

                        End If

                        'Asignamos el id del proceso al item en cuestion.
                        LView_Monitor.Items(Lvi_FoundEmul.Index).SubItems(3).Text = MyProcess.Id
                        LView_Monitor.Items(Lvi_FoundEmul.Index).SubItems(2).Text = "Activo"

                    End If

                End If

                LView_Procesos.Items.Add(MyProcess.ProcessName)
                LView_Procesos.Items(LView_Procesos.Items.Count - 1).SubItems.Add(FormatNumber(Math.Round(MyProcess.PrivateMemorySize64)))
                LView_Procesos.Items(LView_Procesos.Items.Count - 1).SubItems.Add(MyProcess.Responding)
                LView_Procesos.Items(LView_Procesos.Items.Count - 1).SubItems.Add(MyProcess.StartTime.ToString.Trim)
                LView_Procesos.Items(LView_Procesos.Items.Count - 1).SubItems.Add(MyProcess.Id)

            End If

        Next

        'Ahora validamos si hay procesos que ya no existan.
        For Each DelItem As ListViewItem In LView_Procesos.Items

            'Reiniciamos la variable.
            bFind = False

            For Each Proc In ArrProc

                'Buscamos el item en los procesos.
                If DelItem.Text = Proc.ProcessName Then
                    bFind = True
                End If

            Next

            'Validamos si aun existe el proceso en la lista.
            If Not bFind Then

                'Validamos si alguna de estas sentencias corresponde a alguno de los emuladores monitoreados.
                If LView_Monitor.Items.Count > 0 Then
                    Lvi_FoundEmul = LView_Monitor.FindItemWithText(DelItem.Text)
                    If Lvi_FoundEmul IsNot Nothing Then
                        'Asignamos el id del proceso al item en cuestion.
                        LView_Monitor.Items(Lvi_FoundEmul.Index).SubItems(3).Text = String.Empty
                        LView_Monitor.Items(Lvi_FoundEmul.Index).SubItems(2).Text = "Inactivo"
                    End If
                End If

                DelItem.Remove()

            End If

            If Not bFind And DelItem.Text.ToString.Trim = Frm_Timer.Dt_SegParametros.Rows(0).Item("FrontEnd").ToString.Trim Then
                Frm_Timer.Close()
            End If

        Next

        'Actualizamos la informacion del Listview
        LView_Procesos.Refresh()

    End Sub

    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Try

            pi = New ProcessStartInfo
            NewProcess = New Process

            pi.FileName = Txt_NewProcess.Text.ToString.Trim
            'pi.Arguments = ""
            'pi.UseShellExecute = False
            'pi.RedirectStandardError = True
            'pi.RedirectStandardOutput = True
            'pi.CreateNoWindow = True

            NewProcess.StartInfo = pi
            NewProcess.Start()

        Catch ex As Exception
            MessageBox.Show("Problemas al finalizar el proceso seleccionado, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_KillProcess_Click(sender As Object, e As EventArgs) Handles Btn_KillProcess.Click
        Try

            'Matamos el proceso de todos los items seleccionados.
            For Each ItemProcess As ListViewItem In LView_Procesos.SelectedItems
                Process.GetProcessById(ItemProcess.SubItems(4).Text).Kill()
            Next

        Catch ex As Exception
            MessageBox.Show("Problemas al finalizar el proceso seleccionado, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Tim_Monitor_Tick(sender As Object, e As EventArgs) Handles Tim_Monitor.Tick
        Try

            Dim bKillProc As Boolean = False

            If Frm_Timer.bMonedaDepositada Then

                Frm_Timer.bMonedaDepositada = False

                If Not String.IsNullOrEmpty(Frm_Timer.Dt_SegParametros.Rows(0).Item("CoinInsertedSound").ToString.Trim) Then
                    wmp_reproductor.URL = Frm_Timer.Dt_SegParametros.Rows(0).Item("CoinInsertedSound").ToString.Trim
                Else
                    wmp_reproductor.URL = My.Application.Info.DirectoryPath & "\Sounds\MonedaDepositada.wav"
                End If

                wmp_reproductor.Ctlcontrols.play()
                Tim_Monitor.Stop()
                System.Threading.Thread.Sleep(1000)
                Tim_Monitor.Start()

            End If

            If Frm_Timer.iTiempoRest > 0 Then

                Frm_Timer.iTiempoRest = Frm_Timer.iTiempoRest - 1

                'Si el tiempo restante es igual a 10 segundos, vamos a reproducir el audio de tiempo restante.
                If Frm_Timer.iTiempoRest = Convert.ToInt32(Frm_Timer.Dt_SegParametros.Rows(0).Item("SegInsertCoinSound")) Then

                    If Not String.IsNullOrEmpty(Frm_Timer.Dt_SegParametros.Rows(0).Item("LittleGameTimeSound").ToString.Trim) Then
                        wmp_reproductor.URL = Frm_Timer.Dt_SegParametros.Rows(0).Item("LittleGameTimeSound").ToString.Trim
                    Else
                        wmp_reproductor.URL = My.Application.Info.DirectoryPath & "\Sounds\PocoTiempo.wav"
                    End If

                    wmp_reproductor.Ctlcontrols.play()
                    Tim_Monitor.Stop()
                    System.Threading.Thread.Sleep(1000)
                    Tim_Monitor.Start()

                End If

                'Si el tiempo restante es menor a 10 segundos, vamos a reproducir la alarma de sonido.
                If Frm_Timer.iTiempoRest <= Convert.ToInt32(Frm_Timer.Dt_SegParametros.Rows(0).Item("SegSoundAlert")) Then

                    If Not String.IsNullOrEmpty(Frm_Timer.Dt_SegParametros.Rows(0).Item("AlertSound").ToString.Trim) Then
                        wmp_reproductor.URL = Frm_Timer.Dt_SegParametros.Rows(0).Item("AlertSound").ToString.Trim
                    Else
                        wmp_reproductor.URL = My.Application.Info.DirectoryPath & "\Sounds\Alarma.wav"
                    End If

                    wmp_reproductor.Ctlcontrols.play()
                    Tim_Monitor.Stop()
                    System.Threading.Thread.Sleep(1000)
                    Tim_Monitor.Start()

                End If

            Else

                'Aqui debemos agrear el sonido del tiempo terminado y eliminar el proceso del emulador.
                Dim EmulProc As Process

                For Each ItemProc As ListViewItem In LView_Monitor.Items

                    If ItemProc.SubItems(2).Text = "Activo" Then

                        bKillProc = True
                        EmulProc = Process.GetProcessById(Convert.ToInt32(ItemProc.SubItems(3).Text))
                        EmulProc.Kill()

                    End If

                Next

            End If

            If bKillProc Then

                If Not String.IsNullOrEmpty(Frm_Timer.Dt_SegParametros.Rows(0).Item("ExitGameSound").ToString.Trim) Then
                    wmp_reproductor.URL = Frm_Timer.Dt_SegParametros.Rows(0).Item("ExitGameSound").ToString.Trim
                Else
                    wmp_reproductor.URL = My.Application.Info.DirectoryPath & "\Sounds\Salir.wav"
                End If

                wmp_reproductor.Ctlcontrols.play()
                bKillProc = False

            End If

        Catch ex As Exception
            'MessageBox.Show("Problemas al monitorizar el tiempo de emulacion, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Tim_Procesos_Tick(sender As Object, e As EventArgs) Handles Tim_Procesos.Tick
        Try

            'Cargamos los procesos.
            BindProcess()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar los procesos, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LView_Monitor_DoubleClick(sender As Object, e As EventArgs) Handles LView_Monitor.DoubleClick
        Try

            Dim Dlg_AddTimer As New Frm_AgregarTimer
            Dim NewTime As New TimeMonitor

            Try

                NewTime.ExeName = LView_Monitor.SelectedItems(0).Text
                NewTime.ExePath = LView_Monitor.SelectedItems(0).SubItems(1).Text
                Dlg_AddTimer.EditTimeMonitor = NewTime
                Frm_Timer.AbrirFomEnPanel(Dlg_AddTimer)

            Catch ex As Exception
                MessageBox.Show("Problemas al mostrar el formulario, Error: " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el dialogo de edicion, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LView_Iniciar_DoubleClick(sender As Object, e As EventArgs) Handles LView_Iniciar.DoubleClick


        Dim MyFrmStartUp As New Frm_StartUp
        Dim MyStartUP As New StartUp

        Try

            MyStartUP.Ruta = LView_Iniciar.SelectedItems(0).Text
            MyStartUP.Ejecutar = LView_Iniciar.SelectedItems(0).SubItems(1).Text
            MyStartUP.CerrarAlSalir = LView_Iniciar.SelectedItems(0).SubItems(2).Text
            MyFrmStartUp.MyStartUp = MyStartUP

            Frm_Timer.AbrirFomEnPanel(MyFrmStartUp)

        Catch ex As Exception
            MessageBox.Show("Problemas al mostrar el formulario, Error: " & ex.Message)
        Finally
            MyStartUP.Dispose()
            GC.Collect()
        End Try
    End Sub

End Class