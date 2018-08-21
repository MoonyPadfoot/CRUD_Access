Public Class Students
    Dim db As New ConnectionDB
    Dim _username As String
    Dim _password As String
    Public WriteOnly Property UName() As String
        Set(value As String)
            _username = value
        End Set
    End Property
    Public WriteOnly Property PWord() As String
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Function Save() As Boolean
        Try
            db.OpenCon()
            query = "SELECT * FROM "
            dbCommand = New OleDb.OleDbCommand(query, dbConnection)
            dbDReader = dbCommand.ExecuteReader

            If dbDReader.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message)
        Finally
            db.CloseCon()
        End Try

    End Function
End Class
