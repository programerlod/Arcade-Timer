Public Class Frm_AgregarTimer

    Private _EditTimeMonitor As TimeMonitor
    Public Property EditTimeMonitor() As TimeMonitor
        Get
            Return _EditTimeMonitor
        End Get
        Set(ByVal value As TimeMonitor)
            _EditTimeMonitor = value
        End Set
    End Property

    Private bEsEdicion As Boolean = False

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        Try

            'Validamos si los datos estan completos.
            If String.IsNullOrEmpty(Txt_ExeName.Text.ToString.Trim) Then
                MessageBox.Show("Primero debe capturar el nombre del ejecutable")
                Exit Sub
            End If

            If String.IsNullOrEmpty(Txt_ExeName.Text.ToString.Trim) Then
                MessageBox.Show("Primero debe seleccionar la ruta del ejecutable")
                Exit Sub
            End If

            'Validamos que exista la extension.
            If Not Txt_ExeName.Text.Contains(".exe") Then
                MessageBox.Show("El nombre del archivo debe tener la extension .exe")
                Exit Sub
            End If

            'Actualizamos los datos del objeto timer
            EditTimeMonitor.ExeName = Txt_ExeName.Text.ToString.Trim
            EditTimeMonitor.ExePath = Txt_ExePath.Text.ToString.Trim

            'Verificamos si el ejecutable ya existe
            If Not bEsEdicion And ExisteExe(Txt_ExeName.Text.ToString.Trim) Then
                bEsEdicion = True
            End If

            'Insertamos el nuevo monitor en la base de datos.
            If Not bEsEdicion Then
                InsertaTimer(EditTimeMonitor)
            Else
                ActualizaTimer(EditTimeMonitor)
            End If

            Me.Close()
            Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)

        Catch ex As Exception
            MessageBox.Show("Problemas al confirmar los cambios del timer, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Valida si un ejecutable ya fue registrado previamente en la base de datos.
    ''' </summary>
    ''' <param name="sExeName">Nombre del ejecutable</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ExisteExe(ByVal sExeName As String) As Boolean

        Dim Dt_NewExe As New DataTable

        Try

            Dt_NewExe = LeerDatos(Frm_Timer.sConn, "SELECT * FROM ProMonitor WHERE Ejecutable = '" & sExeName & "'")

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
        Frm_Timer.AbrirFomEnPanel(New Frm_Monitoreo)
    End Sub

    Private Sub Btn_Explorar_Click(sender As Object, e As EventArgs) Handles Btn_Explorar.Click

        Dim OFD As New OpenFileDialog

        Try

            'Filtramos el tipo de extension 
            OFD.Filter = "(exe)|*.exe"

            'Mostramos el dialogo y obtenemos el resultado.
            If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Txt_ExePath.Text = OFD.FileName
            Else
                Txt_ExePath.Text = String.Empty
            End If

        Catch ex As Exception
            MessageBox.Show("Problemas al explorar el ejecutable, Error: " & ex.Message)
        Finally
            OFD.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub Frm_AgregarTimer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            If String.IsNullOrEmpty(EditTimeMonitor.ExeName) Then
                Lbl_title.Text = "Agregar Nuevo Ejecutable"
            Else
                Lbl_title.Text = "Editar Ejecutable"
                bEsEdicion = True
                Txt_ExeName.Text = EditTimeMonitor.ExeName
                Txt_ExePath.Text = EditTimeMonitor.ExePath
                Txt_ExeName.Enabled = False
                Btn_EliminarExe.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("Problemas al cargar el formulario para agregar un nuevo timer, Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Insertamos el monitoreo en la base de datos.
    ''' </summary>
    ''' <param name="EditTimeMonitor"></param>
    ''' <remarks></remarks>
    Private Sub InsertaTimer(ByVal EditTimeMonitor As TimeMonitor)

        Dim sSqlInsertTimer As String = String.Empty

        Try

            'Estructuramos el comando SQL de insercion 
            sSqlInsertTimer = "INSERT INTO ProMonitor (Ejecutable, Ruta, Estatus, TaskId) VALUES ('@Exe','@Path','Inactivo',0)"
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exe", EditTimeMonitor.ExeName)
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Path", EditTimeMonitor.ExePath)

            'Insertamos el ejecutable para su monitoreo
            InsertarDatos(Frm_Timer.sConn, sSqlInsertTimer)


        Catch ex As Exception
            Throw New ArgumentException("Problemas al registrar el ejecutable para su monitoreo, Error: " & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Actualizamos el monitoreo en la base de datos.
    ''' </summary>
    ''' <param name="EditTimeMonitor"></param>
    ''' <remarks></remarks>
    Private Sub ActualizaTimer(ByVal EditTimeMonitor As TimeMonitor)

        Dim sSqlInsertTimer As String = String.Empty

        Try

            'Estructuramos el comando SQL de insercion 
            sSqlInsertTimer = "UPDATE ProMonitor SET Ruta = '@Path' WHERE Ejecutable = '@Exe'"
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exe", EditTimeMonitor.ExeName)
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Path", EditTimeMonitor.ExePath)

            'Insertamos el ejecutable para su monitoreo
            ActualizarDatos(Frm_Timer.sConn, sSqlInsertTimer)


        Catch ex As Exception
            Throw New ArgumentException("Problemas al registrar el ejecutable para su monitoreo, Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Btn_EliminarExe_Click(sender As Object, e As EventArgs) Handles Btn_EliminarExe.Click
        Try

            'Preguntamos al usuario si esta seguro de querer eliminar el registro seleccionado.
            If MessageBox.Show("Estas seguro de querer eliminar el timer seleccionado?", "Eliminar Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'Eliminamos el timer
            EliminarTimer(EditTimeMonitor)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EliminarTimer(ByVal EditTimeMonitor As TimeMonitor)

        Dim sSqlInsertTimer As String = String.Empty

        Try

            'Estructuramos el comando SQL de insercion 
            sSqlInsertTimer = "DELETE FROM ProMonitor WHERE Ejecutable = '@Exe'"
            sSqlInsertTimer = sSqlInsertTimer.Replace("@Exe", EditTimeMonitor.ExeName)

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

End Class