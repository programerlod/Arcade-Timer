Imports System.Runtime.InteropServices

Public Class Frm_Clock

    Private hms As TimeSpan
    Private Hours As String = String.Empty
    Private Minutes As String = String.Empty
    Private Seconds As String = String.Empty
    Private Tiempo As String = String.Empty

    Private Const HWND_TOPMOST = -1
    Private Const HWND_NOTOPMOST = -2
    Private Const SWP_NOMOVE = &H2
    Private Const SWP_NOSIZE = &H1
    Private Const SWP_NOACTIVATE = &H10
    Private Const SWP_SHOWWINDOW = &H40
    Private Const FLAGS = SWP_NOMOVE Or SWP_NOSIZE Or SWP_SHOWWINDOW Or SWP_NOACTIVATE

    ' Private Declare Function SetWindowPos Lib "user32" _
    '(ByVal hwnd As Long, ByVal hWndInsertAfter As Long, _
    ' ByVal x As Long, ByVal y As Long, _
    ' ByVal cx As Long, ByVal cy As Long, _
    ' ByVal wFlags As Long) As Long

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As UInteger) As Boolean
    End Function

    Private Sub SetWindowOnTop(f As Form, bAlwaysOnTop As Boolean)
        Dim iFlag As Long
        iFlag = IIf(bAlwaysOnTop, HWND_TOPMOST, HWND_NOTOPMOST)
        'Me.TopMost = True
        'Me.TopLevel = True
        SetWindowPos(f.Handle, -1, Me.Size.Width, Me.Size.Height, 0, 0, FLAGS)
        'MessageBox.Show("Tamaño : " & Me.Size.ToString & vbCrLf & "Posicion : " & Me.StartPosition.ToString)
    End Sub

    Private Sub Tim_Refrestimer_Tick(sender As Object, e As EventArgs) Handles Tim_Refrestimer.Tick
        Try


            hms = TimeSpan.FromSeconds(Frm_Timer.iTiempoRest)
            Hours = hms.Hours.ToString.Trim
            Minutes = hms.Minutes.ToString.Trim
            Seconds = hms.Seconds.ToString.Trim

            'Estructuramos el tiempo
            Tiempo = IIf(Hours.Length = 1, "0", "") & Hours & ":"
            Tiempo = Tiempo & IIf(Minutes.Length = 1, "0", "") & Minutes & ":"
            Tiempo = Tiempo & IIf(Seconds.Length = 1, "0", "") & Seconds

            Lbl_Timer.Text = Tiempo
            Lbl_Timer.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Clock_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            Me.TopMost = True
            Me.TopLevel = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Clock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            Tim_Refrestimer.Interval = 1000
            Tim_Refrestimer.Enabled = True
            Tim_Refrestimer.Start()

            Tim_ShowOnTop.Interval = 10
            Tim_ShowOnTop.Enabled = True
            Tim_ShowOnTop.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Clock_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Application.DoEvents()
        'hms = TimeSpan.FromSeconds(Frm_Timer.iTiempoRest)
        'Hours = hms.Hours.ToString.Trim
        'Minutes = hms.Minutes.ToString.Trim
        'Seconds = hms.Seconds.ToString.Trim

        ''Estructuramos el tiempo
        'Tiempo = IIf(Hours.Length = 1, "0", "") & Hours & ":"
        'Tiempo = Tiempo & IIf(Minutes.Length = 1, "0", "") & Minutes & ":"
        'Tiempo = Tiempo & IIf(Seconds.Length = 1, "0", "") & Seconds

        'Lbl_Timer.Text = Tiempo
        'Lbl_Timer.Refresh()
        'Threading.Thread.Sleep(1000)
        'Me.Close()
    End Sub

    Private Sub Tim_ShowOnTop_Tick(sender As Object, e As EventArgs) Handles Tim_ShowOnTop.Tick
        'Mostramos el formulario siempre frente.
        SetWindowOnTop(Me, True)
    End Sub
End Class