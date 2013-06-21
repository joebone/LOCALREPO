Public Class SELServidor

    Private Sub SrvCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SrvCombo.SelectedIndexChanged
        If SrvCombo.Text.ToLowerInvariant() = "yosemiteii" Then
            LoginCombo.Text = "desarrollo;juniper"
        Else
            LoginCombo.Text = "sa;as"
        End If
        LoginCombo_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub LoginCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LoginCombo.SelectedIndexChanged
        BdCombo.Items.Clear()
        Dim SQLSB = New SqlClient.SqlConnectionStringBuilder()
        Dim Logins = LoginCombo.Text.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
        SQLSB.DataSource = SrvCombo.Text
        SQLSB.UserID = Logins(0).Trim
        SQLSB.Password = Logins(1).Trim
        Using con = New SqlClient.SqlConnection(SQLSB.ToString)
            Try
                con.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed : " & ex.ToString)
                Exit Sub
            End Try
            Using Cmd = New SqlClient.SqlCommand("EXEC sp_databases", con)
                Using rdr = Cmd.ExecuteReader()
                    While rdr.Read()
                        BdCombo.Items.Add(rdr("DATABASE_NAME").ToString)
                    End While
                End Using
            End Using

        End Using

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Vals = ComboBox1.Text.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
        Dim Components = Vals(1).Trim().Split("¬"c)
        SrvCombo.Text = Components(0)
        LoginCombo.Text = Components(2) & ";" & Components(3)
        BdCombo.Text = Components(1)
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        btnSave.Enabled = False
        Dim SQLSB = New SqlClient.SqlConnectionStringBuilder()
        Dim Logins = LoginCombo.Text.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
        SQLSB.DataSource = SrvCombo.Text
        SQLSB.UserID = Logins(0).Trim
        SQLSB.Password = Logins(1).Trim
        SQLSB.InitialCatalog = BdCombo.Text
        Using con = New SqlClient.SqlConnection(SQLSB.ToString)
            Try
                con.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed : " & ex.ToString)
                Exit Sub
            End Try
        End Using
        btnSave.Enabled = True


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Logins      = LoginCombo.Text.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
        Server          = SrvCombo.Text
        User            = Logins(0).Trim
        Password        = Logins(1).Trim
        BD              = BdCombo.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Public Property Server As String
    Public Property User As String
    Public Property Password As String
    Public Property BD As String
End Class