
Imports Finisar.SQLite

Module Mod_Sqlite

    Public Function LeerDatos(ByVal sConn As String, ByVal sQuery As String) As DataTable

        Dim objConn As New SQLiteConnection
        ' Dim objcommand As SQLiteCommand
        ' Dim objReader As SQLiteDataReader
        Dim objAdapter As SQLiteDataAdapter
        Dim Dt_Consulta As New DataTable

        Try

            objConn = New SQLiteConnection(sConn)
            objConn.Open()
            objAdapter = New SQLiteDataAdapter(sQuery, sConn)
            Dt_Consulta = New DataTable

            objAdapter.Fill(Dt_Consulta)

            Return Dt_Consulta

        Catch ex As Exception
            Throw New ArgumentException("Error al obtener la informacion Conn: " & sConn & " Query: " & sQuery, ex.Message)
        Finally
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try
    End Function

    Public Function InsertarDatos(ByVal sConn As String, ByVal sQueryInsert As String) As Boolean

        Dim objConn As New SQLiteConnection
        Dim objCommand As SQLiteCommand

        Try

            objConn = New SQLiteConnection(sConn)
            objConn.Open()
            objCommand = objConn.CreateCommand
            objCommand.CommandText = sQueryInsert
            objCommand.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New ArgumentException("Error al registrar la informacion en la tabla Conn: " & sConn & " Query: " & sQueryInsert, ex.Message)
            Return False
        Finally
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try
    End Function

    Public Sub ExecuteCommandsSqlLiteWithTrans(ByVal sConn As String, ByVal Dt_Querys As DataTable)

        Dim TMgr As SQLiteTransaction
        Dim objConn As New SQLiteConnection
        Dim objCommand As SQLiteCommand

        Try

            objConn = New SQLiteConnection(sConn)
            objConn.Open()
            TMgr = objConn.BeginTransaction

            objCommand = objConn.CreateCommand
            objCommand.Transaction = TMgr

            For Each Dr_Command As DataRow In Dt_Querys.Rows

                objCommand.CommandText = Dr_Command.Item("Query").ToString.Trim
                objCommand.ExecuteNonQuery()

            Next

            'Hacemos el commit de todos los cambios.
            TMgr.Commit()

        Catch ex As Exception
            TMgr.Rollback()
            Throw New ArgumentException("Funcion: ExecuteCommandsSqlLiteWithTrans, Descrip: " & ex.Message)
        End Try
    End Sub

    Public Function EliminarDatos(ByVal sConn As String, ByVal sDeleteCommand As String) As Boolean

        Dim objConn As New SQLiteConnection
        Dim objCommand As SQLiteCommand

        Try

            objConn = New SQLiteConnection(sConn)
            objConn.Open()
            objCommand = objConn.CreateCommand
            objCommand.CommandText = sDeleteCommand
            objCommand.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New ArgumentException("Error al borrar la informacion Conn: " & sConn & " Query: " & sDeleteCommand, ex.Message)
            Return False
        Finally
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try
    End Function

    Public Function ActualizarDatos(ByVal sConn As String, ByVal sUpdateQuery As String) As Boolean
        Dim objConn As New SQLiteConnection
        Dim objCommand As SQLiteCommand

        Try

            objConn = New SQLiteConnection(sConn)
            objConn.Open()
            objCommand = objConn.CreateCommand
            objCommand.CommandText = sUpdateQuery
            objCommand.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New ArgumentException("Error al actualizar la informacion Conn: " & sConn & " Query: " & sUpdateQuery, ex.Message)
            Return False
        Finally
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try
    End Function

End Module
