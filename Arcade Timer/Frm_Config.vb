Imports DevExpress.XtraEditors

Public Class Frm_Config

    Dim Dt_UbicacionTiempo As New DataTable

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        Try
            'Validamos que los datos sean correctos.
            If Not IsNumeric(Txt_MinxMoneda.Text) Then
                Throw New ArgumentException("El campo minutos por moneda solo acepta valores numericos")
            End If

            If Convert.ToInt32(Txt_MinxMoneda.Text) <= 0 Then
                Throw New ArgumentException("El campo minutos por moneda, solo acepta valores mayores a cero")
            End If


            If Not IsNumeric(Txt_PocoTiempo.Text) Then
                Throw New ArgumentException("El campo Sonido poco tiempo solo acepta valores numericos")
            End If

            If Convert.ToInt32(Txt_PocoTiempo.Text) <= 0 Then
                Throw New ArgumentException("El campo Sonido poco tiempo, solo acepta valores mayores a cero")
            End If

            If Not IsNumeric(Txt_Alerta.Text) Then
                Throw New ArgumentException("El campo Sonido Alerta solo acepta valores numericos")
            End If

            If Convert.ToInt32(Txt_Alerta.Text) <= 0 Then
                Throw New ArgumentException("El campo Sonido Alerta, solo acepta valores mayores a cero")
            End If

            'Actualizamos los parametros.
            ActualizarParametros()

            'Cerramos el formulario y abrirmos el monitoreo
            Me.Close()
            Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Actualizamos los parametros
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActualizarParametros()

        Dim sSql As String = String.Empty

        Try

            'Armamos el comando SQL para actualizar la tabla de parametros
            sSql = "UPDATE SegParametros SET MinxMoneda = @MinxMon, " & _
                                            "MonitorOn = @MonitorOn, " & _
                                            "MostrarTiempo = @MostrarTiempo, " & _
                                            "SegInsertCoinSound = @PocoTiempo, " & _
                                            "SegSoundAlert = @Alerta, " & _
                                            "FrontEnd = '@FronEnd', " & _
                                            "UbicacionTiempo = '@UbicTime', " & _
                                            "InsertCoinSound = '@InsertCoinSound', " & _
                                            "AlertSound = '@AlertSound', " & _
                                            "CoinInsertedSound = '@CoinInsertedSound', " & _
                                            "ExitGameSound = '@ExitGameSound', " & _
                                            "LittleGameTimeSound = '@LittleGameTimeSound' " & _
                                            "WHERE Id = 1"

            'Reemplazamos las variables @ por los valores finales
            sSql = sSql.Replace("@MinxMon", Txt_MinxMoneda.Text.ToString.Trim)
            sSql = sSql.Replace("@MonitorOn", Convert.ToInt32(Chk_Monitoreo.Checked))
            sSql = sSql.Replace("@MostrarTiempo", Convert.ToInt32(Chk_Temporizador.Checked))
            sSql = sSql.Replace("@PocoTiempo", Txt_PocoTiempo.Text.ToString.Trim)
            sSql = sSql.Replace("@Alerta", Txt_Alerta.Text.ToString.Trim)
            sSql = sSql.Replace("@FronEnd", Txt_FrontEnd.Text.ToString.Trim)
            sSql = sSql.Replace("@UbicTime", Cbo_UbicacionTiempo.SelectedValue.ToString.Trim)
            sSql = sSql.Replace("@InsertCoinSound", BtnEdt_InserteMoneda.EditValue.ToString.Trim)
            sSql = sSql.Replace("@AlertSound", BtnEdt_AlertSound.EditValue.ToString.Trim)
            sSql = sSql.Replace("@CoinInsertedSound", BtnEdt_CoinInsertedSound.EditValue.ToString.Trim)
            sSql = sSql.Replace("@ExitGameSound", BtnEdt_ExitGameSound.EditValue.ToString.Trim)
            sSql = sSql.Replace("@LittleGameTimeSound", BtnEdt_LittleGameTimeSound.EditValue.ToString.Trim)

            'Ejecutamos los comandos SQL.
            ActualizarDatos(Frm_Timer.sConn, sSql)

        Catch ex As Exception
            Throw New ArgumentException("Problemas al actualizar los parametros del sistema, Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        'Cerramos el formulario y abrirmos el monitoreo
        Me.Close()
        Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)
    End Sub

    Dim Dt_Config As New DataTable

    Private Sub Frm_Config_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            'Obtenemos los parametros del sistema
            Dt_Config = LeerDatos(Frm_Timer.sConn, "SELECT MinxMoneda, " & _
                                                            "MonitorOn, " & _
                                                            "MostrarTiempo, " & _
                                                            "SegInsertCoinSound, " & _
                                                            "SegSoundAlert, " & _
                                                            "SegMostrarTiempo, " & _
                                                            "FrontEnd, " & _
                                                            "UbicacionTiempo, " & _
                                                            "IFNULL(InsertCoinSound,'') AS InsertCoinSound, " & _
                                                            "IFNULL(AlertSound,'') AS AlertSound, " & _
                                                            "IFNULL(CoinInsertedSound, '') AS CoinInsertedSound, " & _
                                                            "IFNULL(ExitGameSound,'') AS ExitGameSound, " & _
                                                            "IFNULL(LittleGameTimeSound, '') AS LittleGameTimeSound " & _
                                                            "FROM SegParametros WHERE Id = 1")

            'Obtenemos las ubicaciones que puede tener el temporizador
            Dt_UbicacionTiempo = ObtenerUbicaciones()

            'Asignamos el origen de datos al combobox.
            With Cbo_UbicacionTiempo
                .DataSource = Dt_UbicacionTiempo
                .DisplayMember = "Descripcion"
                .ValueMember = "Clave"
            End With

            'Asignamos los parametros del sistema
            Txt_MinxMoneda.Text = Dt_Config.Rows(0).Item("MinxMoneda")
            Chk_Monitoreo.Checked = Convert.ToBoolean(Dt_Config.Rows(0).Item("MonitorOn"))
            Chk_Temporizador.Checked = Convert.ToBoolean(Dt_Config.Rows(0).Item("MostrarTiempo"))
            Txt_PocoTiempo.Text = Dt_Config.Rows(0).Item("SegInsertCoinSound").ToString.Trim
            Txt_Alerta.Text = Dt_Config.Rows(0).Item("SegSoundAlert").ToString.Trim
            Txt_FrontEnd.Text = Dt_Config.Rows(0).Item("FrontEnd").ToString.Trim
            Cbo_UbicacionTiempo.SelectedValue = Dt_Config.Rows(0).Item("UbicacionTiempo").ToString.Trim

            'Asignamos las rutas de los sonidos a procesar.
            BtnEdt_InserteMoneda.EditValue = Dt_Config.Rows(0).Item("InsertCoinSound").ToString.Trim
            BtnEdt_AlertSound.EditValue = Dt_Config.Rows(0).Item("AlertSound").ToString.Trim
            BtnEdt_CoinInsertedSound.EditValue = Dt_Config.Rows(0).Item("CoinInsertedSound").ToString.Trim
            BtnEdt_ExitGameSound.EditValue = Dt_Config.Rows(0).Item("ExitGameSound").ToString.Trim
            BtnEdt_LittleGameTimeSound.EditValue = Dt_Config.Rows(0).Item("LittleGameTimeSound").ToString.Trim

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Obtenemos las ubicaciones.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ObtenerUbicaciones() As DataTable

        Dim Dt_Ubicaciones As New DataTable
        Dim Dr_AddLocation As DataRow
        Try

            Dt_Ubicaciones.Columns.Add("Clave")
            Dt_Ubicaciones.Columns.Add("Descripcion")

            'Agregamos los items
            Dr_AddLocation = Dt_Ubicaciones.NewRow
            Dr_AddLocation.Item("Clave") = "TL"
            Dr_AddLocation.Item("Descripcion") = "Arriba - Izquierda"
            Dt_Ubicaciones.Rows.Add(Dr_AddLocation)

            Dr_AddLocation = Dt_Ubicaciones.NewRow
            Dr_AddLocation.Item("Clave") = "TR"
            Dr_AddLocation.Item("Descripcion") = "Arriba - Derecha"
            Dt_Ubicaciones.Rows.Add(Dr_AddLocation)

            Dr_AddLocation = Dt_Ubicaciones.NewRow
            Dr_AddLocation.Item("Clave") = "BL"
            Dr_AddLocation.Item("Descripcion") = "Abajo - Izquierda"
            Dt_Ubicaciones.Rows.Add(Dr_AddLocation)

            Dr_AddLocation = Dt_Ubicaciones.NewRow
            Dr_AddLocation.Item("Clave") = "BR"
            Dr_AddLocation.Item("Descripcion") = "Abajo - Derecha"
            Dt_Ubicaciones.Rows.Add(Dr_AddLocation)

            Return Dt_Ubicaciones

        Catch ex As Exception
            Throw New ArgumentException("Problemas al obtener las ubicaciones, Error: " & ex.Message)
        Finally
            Dt_Ubicaciones.Dispose()
            GC.Collect()
        End Try

    End Function

    Private Sub Chk_Monitoreo_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Monitoreo.CheckedChanged, Chk_Temporizador.CheckedChanged
        Try

            Dim Chk As CheckBox = TryCast(sender, CheckBox)

            If Chk.Checked Then

                Chk.Text = "Si"

            Else

                Chk.Text = "No"

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEdt_AlertSound_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles BtnEdt_AlertSound.ButtonClick,
                                                                                                                                     BtnEdt_CoinInsertedSound.ButtonClick,
                                                                                                                                     BtnEdt_ExitGameSound.ButtonClick,
                                                                                                                                     BtnEdt_InserteMoneda.ButtonClick,
                                                                                                                                     BtnEdt_LittleGameTimeSound.ButtonClick
        Try

            Dim MyButtonEdit As ButtonEdit = TryCast(sender, ButtonEdit)

            'Validamos que boton fue presionado por el usuario.
            If e.Button.Caption = "Play" Then

                'Validamos que haya un archivo de audio seleccionado.
                If String.IsNullOrEmpty(MyButtonEdit.EditValue.ToString.Trim) Then
                    Throw New ArgumentException("Primero debe seleccionar un archivo de sonido")
                End If

                'Reproducimos el sonido seleccionado por el usuario.
                wmp_reproductor.URL = MyButtonEdit.EditValue.ToString.Trim
                wmp_reproductor.Ctlcontrols.play()

            ElseIf e.Button.Caption = "Browse" Then

                Dim Dlg As New OpenFileDialog
                Dlg.Filter = "Archivo de audio (*.mp3)|*.mp3|Archivo de audio (*.wma)|*.wma|Archivo de audio (*.wav)|*.wav"

                If Dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    MyButtonEdit.EditValue = Dlg.FileName
                End If

                Dlg.Dispose()

            Else

                MyButtonEdit.EditValue = String.Empty

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class