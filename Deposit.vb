Imports System.Data.OleDb

Public Class Deposit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection(My.Settings.MIMAS__InvestmentConnectionString)

        Dim uid = userID

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM accountD WHERE Customer_ID = " & uid, con)

        If True Then

            Dim Qreader As OleDbDataReader
            Dim Cash As String

            con.Open()


            Qreader = cmd.ExecuteReader


            If (Qreader.Read()) Then

                Cash = Qreader.GetValue("4").ToString

                Dim cashs As String
                cashs = (Cash + TextBox1.Text)
                If True Then
                    Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO accountD ([CashBalance] VALUES (@newcash)", con)
                    cmd2.Parameters.AddWithValue("@newcash", cashs)

                End If
                MessageBox.Show("Deposited Succesfully")
                Me.Hide()
            End If

        End If
    End Sub
End Class