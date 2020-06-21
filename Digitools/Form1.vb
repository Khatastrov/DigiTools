Public Class Form1

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Dim calc = New Form2
        calc.Show()
    End Sub

    Private Sub btn_conv_Click(sender As Object, e As EventArgs) Handles btn_conv.Click
        Dim conv = New Form3
        conv.Show()
    End Sub

End Class
