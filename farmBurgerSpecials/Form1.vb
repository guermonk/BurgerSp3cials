Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        PrimeBeef1.Visible = True
        Veggie2.Visible = False
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Veggie2.Visible = True
        PrimeBeef1.Visible = False
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btn1.Enabled = False
        btn2.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub PrimeBeef1_Click(sender As Object, e As EventArgs) Handles PrimeBeef1.Click

    End Sub

    Private Sub Veggie2_Click(sender As Object, e As EventArgs) Handles Veggie2.Click

    End Sub
End Class
