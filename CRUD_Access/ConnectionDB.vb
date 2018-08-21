Public Class ConnectionDB
    Dim _dbPath As String
    Public WriteOnly Property DbPath() As String
        Set(value As String)
            _dbPath = value
        End Set
    End Property
    Public Sub OpenCon()
        Dim dbProvider As String = "Provider=Microsoft.Jet.OleDb.4.0;"
        dbConnection.ConnectionString = dbProvider & "Data Source=" & _dbPath
        dbConnection.Open()
    End Sub
    Public Sub CloseCon()
        dbConnection.Close()
        dbConnection.Dispose()
    End Sub
End Class
