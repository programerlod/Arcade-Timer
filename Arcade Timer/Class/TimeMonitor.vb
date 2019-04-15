Public Class TimeMonitor
    Private _ExeName As String
    Public Property ExeName() As String
        Get
            Return _ExeName
        End Get
        Set(ByVal value As String)
            _ExeName = value
        End Set
    End Property

    Private _ExePath As String
    Public Property ExePath() As String
        Get
            Return _ExePath
        End Get
        Set(ByVal value As String)
            _ExePath = value
        End Set
    End Property


End Class
