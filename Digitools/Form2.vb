Public Class Form2

    Dim value
    Dim opeClicked = False
    Dim sign As String

    Private Sub OnNumClick(sender As Object, e As EventArgs) Handles btn_DOT.Click, btn_9.Click, btn_8.Click, btn_7.Click, btn_6.Click, btn_5.Click, btn_4.Click, btn_3.Click, btn_2.Click, btn_1.Click, btn_00.Click, btn_0.Click

        Dim b As Button = sender

        If (display.Text = "0") Then
            If (b.Text = ",") Then
                display.Text += b.Text
            ElseIf (Not b.Text = "00") Then
                display.Text = b.Text
            End If
        ElseIf (b.Text = ",") Then
            If (Not display.Text.Contains(",")) Then
                    display.Text += b.Text
                End If
            Else
                display.Text += b.Text
        End If

        opeClicked = False

    End Sub


    Private Sub OnClearEntryClick(sender As Object, e As EventArgs) Handles btn_CE.Click

        display.Text = "0"

    End Sub

    Private Sub OnInvertClick(sender As Object, e As EventArgs) Handles btn_INV.Click

        display.Text *= -1

    End Sub

    Private Sub OnOperatorClick(sender As Object, e As EventArgs) Handles btn_PLU.Click, btn_MUL.Click, btn_MIN.Click, btn_DIV.Click

        Dim b As Button = sender

        If (Not opeClicked) Then
            If (Equation.Text <> "") Then
                Select Case sign
                    Case "+"
                        Equation.Text = value + Double.Parse(display.Text)
                    Case "-"
                        Equation.Text = value - Double.Parse(display.Text)
                    Case "*"
                        Equation.Text = value * Double.Parse(display.Text)
                    Case "/"
                        Equation.Text = value / Double.Parse(display.Text)
                End Select

                sign = b.Text
                value = Equation.Text
                Equation.Text = value & " " & sign
                display.Text = "0"

            Else
                sign = b.Text
                value = display.Text
                opeClicked = True

                Equation.Text = value & " " & sign

                display.Text = "0"
            End If
        End If

    End Sub

    Private Sub OnEqualsClick(sender As Object, e As EventArgs) Handles btn_EQ.Click

        If (Equation.Text <> "") Then
            Equation.Text = ""
            Select Case sign
                Case "+"
                    display.Text = value + Double.Parse(display.Text)
                Case "-"
                    display.Text = value - Double.Parse(display.Text)
                Case "*"
                    display.Text = value * Double.Parse(display.Text)
                Case "/"
                    display.Text = value / Double.Parse(display.Text)
            End Select

            value = 0

        End If

    End Sub

    Private Sub OnClearAllClick(sender As Object, e As EventArgs) Handles btn_C.Click

        display.Clear()
        Equation.Text = ""
        value = 0
        opeClicked = False
        display.Text = "0"

    End Sub

    Private Sub OnLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles calcLink.LinkClicked
        Process.Start("www.github.io")
    End Sub
End Class