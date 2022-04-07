Imports System.Data.OleDb

Public Class Login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection(My.Settings.MIMAS__InvestmentConnectionString)


        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM CustomerTable WHERE email = @mail  AND password = @pass ", con)
        cmd.Parameters.AddWithValue("@mail", OleDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.AddWithValue("@pass", OleDbType.VarChar).Value = TextBox2.Text

        con.Open()




        If True Then
            Dim Qreader As OleDbDataReader
            Dim id As String




            Qreader = cmd.ExecuteReader


            If (Qreader.Read()) Then

                id = Qreader.GetValue("0").ToString


                userID = id
                'Dim dash As New Balance(userID)


                '// //Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT CashBalance FROM AccountTable WHERE Customer_ID = ", con)




                MessageBox.Show("Login Successfully!")

                Me.Hide()
                Dashboard.Show()



            Else

                MessageBox.Show("Invalid username or password!")

            End If
        End If
    End Sub
End Class
