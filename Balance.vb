Imports System.Data.OleDb
Imports Stock_Management.Login



Public Class Balance




    Private Shared Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection(My.Settings.MIMAS__InvestmentConnectionString)

        Dim uid = userID

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM accountD WHERE Customer_ID = " & uid, con)

        If True Then

            Dim Qreader As OleDbDataReader
            Dim Cash As String

            con.Open()


            Qreader = cmd.ExecuteReader


            If (Qreader.Read()) Then

                Cash = Qreader.GetValue("1").ToString


                MessageBox.Show(Cash)

            End If

        End If

        'MessageBox.Show(users)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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


                MessageBox.Show(Cash)

            End If

        End If

    End Sub
End Class