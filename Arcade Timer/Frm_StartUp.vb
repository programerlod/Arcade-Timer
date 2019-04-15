Public Class Frm_StartUp

    Private _MyStartUp As StartUp
    Public Property MyStartUp() As StartUp
        Get
            Return _MyStartUp
        End Get
        Set(ByVal value As StartUp)
            _MyStartUp = value
        End Set
    End Property

    Private bEsEdicion As Boolean = False


    Private Sub Frm_StartUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            'Verificamos si se trata de una edicion.
            If Not String.IsNullOrEmpty(MyStartUp.Ruta.ToString.Trim) Then
                bEsEdicion = True
                Lbl_Titulo.Text = "Edicion de un ejecutable a inicializar"
                Txt_RutaExe.Text = MyStartUp.Ruta
                Chk_Ejecutar.Checked = Convert.ToInt32(MyStartUp.Ejecutar)
                Chk_Cerrar.Checked = Convert.ToInt32(MyStartUp.CerrarAlSalir)
                Btn_Explorar.Enabled = False
                Btn_EliminarStartUp.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Chk_Ejecutar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Ejecutar.CheckedChanged
        Try

            If Chk_Ejecutar.Checked Then
                Chk_Ejecutar.Text = "Si"
            Else
                Chk_Ejecutar.Text = "No"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Chk_Cerrar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Cerrar.CheckedChanged
        Try

            If Chk_Cerrar.Checked Then
                Chk_Cerrar.Text = "Si"
            Else
                Chk_Cerrar.Text = "No"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Explorar_Click(sender As Object, e As EventArgs) Handles Btn_Explorar.Click

        Dim OFD As New OpenFileDialog

        Try

            'Filtramos el tipo de extension 
            OFD.Filter = "(exe)|*.exe"

            'Mostramos el dialogo y obtenemos el resultado.
            If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Txt_RutaExe.Text = OFD.FileName
            Else
                Txt_RutaExe.Text = String.Empty
            End If

        Catch ex As Exception
            MessageBox.Show("Problemas al explorar el ejecutable, Error: " & ex.Message)
        Finally
            OFD.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub Btn_AceptarStartUp_Click(sender As Object, e As EventArgs) Handles Btn_AceptarStartUp.Click
        Try

            'Validamos si los datos estan completos.
            If String.IsNullOrEmpty(Txt_RutaExe.Text.ToString.Trim) Then
                MessageBox.Show("Primero debe capturar el nombre del ejecutable")
                Exit Sub
            End If

            'Validamos que exista la extension.
            If Not Txt_RutaExe.Text.Contains(".exe") Then
                MessageBox.Show("El nombre del archivo debe tener la extension .exe")
                Exit Sub
            End If

            'Actualizamos los datos del objeto timer
            MyStartUp.Ruta = Txt_RutaExe.Text.ToString.Trim
            MyStartUp.Ejecutar = Chk_Ejecutar.Checked
            MyStartUp.CerrarAlSalir = Chk_Cerrar.Checked

            'Verificamos si el ejecutable ya existe
            If Not bEsEdicion And ExisteExe(Txt_RutaExe.Text.ToString.Trim) Then
                bEsEdicion = True
            End If

            'Insertamos el nuevo monitor en la base de datos.
            If Not bEsEdicion Then
                InsertaStartUp(MyStartUp)
            Else
                ActualizaStartUp(MyStartUp)
            End If

            Me.Close()
            Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Insertamos las rutas de los ejecutables a inicializar el sistema.
    ''' </summary>
    ''' <param name="LocalStartUp">StartUp</param>
    ''' <remarks></remarks>
    Private Sub InsertaStartUp(ByVal LocalStartUp As StartUp)

        Dim sSqlInsertTimer As String = String.Empty

        Try

            'Estructuramos el comando SQL de insercion 
            sSqlInsertTimer = "INSERT INTO ProEjecutarAlArranque (Ruta, Ejecutar,CerrarAlSalir) VALUES ('@Path',@Exe,@Exit)"

            sSqlInsertTimer = sSqlInsertTimer.Replace("@Path", LocalStartUp.Ruta)
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exe", Convert.ToInt32(LocalStartUp.Ejecutar))
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exit", Convert.ToInt32(LocalStartUp.CerrarAlSalir))

            'Insertamos el ejecutable para su monitoreo
            InsertarDatos(Frm_Timer.sConn, sSqlInsertTimer)


        Catch ex As Exception
            Throw New ArgumentException("Problemas al registrar el ejecutable para su monitoreo, Error: " & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Actualizamos los ejecutables a arrancar con el inicio de la aplicacion.
    ''' </summary>
    ''' <param name="LocalStartUp">StartUp</param>
    ''' <remarks></remarks>
    Private Sub ActualizaStartUp(ByVal LocalStartUp As StartUp)

        Dim sSqlInsertTimer As String = String.Empty

        Try

            'Estructuramos el comando SQL de insercion 
            sSqlInsertTimer = "UPDATE ProEjecutarAlArranque SET Ejecutar = @Exe, CerrarAlSalir = @Exit WHERE Ruta = '@Path'"
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exe", Convert.ToInt32(LocalStartUp.Ejecutar))
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exit", Convert.ToInt32(LocalStartUp.CerrarAlSalir))
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Path", LocalStartUp.Ruta)

            'Insertamos el ejecutable para su monitoreo
            ActualizarDatos(Frm_Timer.sConn, sSqlInsertTimer)


        Catch ex As Exception
            Throw New ArgumentException("Problemas al registrar el ejecutable para su monitoreo, Error: " & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Elimina el registro de la base de datos
    ''' </summary>
    ''' <param name="LocalStartUp">Starup</param>
    ''' <remarks></remarks>
    Private Sub EliminarStartUp(ByVal LocalStartUp As StartUp)

        Dim sSqlInsertTimer As String = String.Empty

        Try

            'Estructuramos el comando SQL de insercion 
            sSqlInsertTimer = "DELETE FROM ProEjecutarAlArranque WHERE Ruta = '@Path'"
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Path", LocalStartUp.Ruta)

            'Insertamos el ejecutable para su monitoreo
            EliminarDatos(Frm_Timer.sConn, sSqlInsertTimer)

            'Cerramos
            Me.Close()

            'Abrimos el monitor.
            Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)

        Catch ex As Exception
            Throw New ArgumentException("Problemas al eliminar el registro de monitoreo, Error: " & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Valida si un ejecutable ya fue registrado previamente en la base de datos.
    ''' </summary>
    ''' <param name="sRuta">Ruta del archivo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ExisteExe(ByVal sRuta As String) As Boolean

        Dim Dt_NewExe As New DataTable

        Try

            Dt_NewExe = LeerDatos(Frm_Timer.sConn, "SELECT * FROM ProEjecutarAlArranque WHERE Ruta = '" & sRuta & "'")

            If Dt_NewExe.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            Throw New ArgumentException("Problemas al validar si un ejecutable ya existe en la base de datos, Error: " & ex.Message)
        Finally
            Dt_NewExe.Dispose()
        End Try
    End Function

    Private Sub Btn_CancelarStartUp_Click(sender As Object, e As EventArgs) Handles Btn_CancelarStartUp.Click
        Me.Close()
        Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)
    End Sub

    Private Sub Btn_EliminarStartUp_Click(sender As Object, e As EventArgs) Handles Btn_EliminarStartUp.Click
        Try

            'Preguntamos al usuario si esta seguro de querer eliminar el registro seleccionado.
            If MessageBox.Show("Estas seguro de querer eliminar el ejecutable seleccionado?", "Eliminar Ejecutable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'Eliminamos el timer
            EliminarStartUp(MyStartUp)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class