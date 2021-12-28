Imports MySql.Data.MySqlClient

Module PublicFunctions
    Public Sub deletePrintTbl()
        conn.Open()
        Try
            comm = New MySqlCommand("prcDeletePrintTable", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            conn.Dispose()
        End Try
        conn.Close()
    End Sub


End Module
