Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim year As Integer = 2014
        Dim p As Double
        p = 7000000000
        Do While p >= 6000000
            p = p / 2
            year -= 50


        Loop
        MessageBox.Show("The year is " & year)



    End Sub
End Class
