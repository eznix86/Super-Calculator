Imports System.Drawing.Text
Public Class splash_screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value += 1
        Label1.Show()


        If (ProgressBar.Value Mod 15 = 0) Then
            Label1.ForeColor = Color.DarkBlue


        Else
            Label1.ForeColor = Color.White

        End If

        If (ProgressBar.Value = 100) Then
            Me.Hide()
            Super_calc.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim NeuroFonts As PrivateFontCollection = New PrivateFontCollection

        NeuroFonts.AddFontFile("neuropolitical.ttf")

        Label3.Font = New Font(NeuroFonts.Families(0), 16)



    End Sub
End Class