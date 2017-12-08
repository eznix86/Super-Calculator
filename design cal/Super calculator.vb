Imports System.Drawing.Text

Public Class Super_calc
    'pour qu'on puisse bouger la fenetre windows 
    Dim mouse_move, mposition As System.Drawing.Point

    Private Sub Super_calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KeyFonts As PrivateFontCollection = New PrivateFontCollection
        Dim OtherFonts As PrivateFontCollection = New PrivateFontCollection

        KeyFonts.AddFontFile("zeroes two.ttf")
        OtherFonts.AddFontFile("neuropolitical.ttf")
        For Each C As Control In Me.Controls
            If C.GetType Is GetType(Button) Then
                C.Font = New Font(KeyFonts.Families(0), 16)
            ElseIf C.GetType Is GetType(TextBox) Then
                C.Font = New Font(KeyFonts.Families(0), 23)
            ElseIf C.GetType Is GetType(Label) Then
                C.Font = New Font(OtherFonts.Families(0), 8)
            End If
        Next
        btn_ans.Font = New Font(KeyFonts.Families(0), 11)
    End Sub

    Private Sub DragBar_MouseDown(sender As Object, e As MouseEventArgs) Handles DragBar.MouseDown
        mouse_move = New Point(-e.X, -e.Y) 'Permet de trouver la position de la  souris actuelle lorsquon clique sur la barre pour faire bouger la fenetre
    End Sub

    Private Sub DragBar_MouseMove(sender As Object, e As MouseEventArgs) Handles DragBar.MouseMove 'la fenetre suit le curseur de l'utilisateur, jusqua que lutilisateur arrete d'appuyer en foncée sur la souris

        If (e.Button = MouseButtons.Left) Then

            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If

    End Sub

    Private Sub Switch_Click(sender As Object, e As EventArgs) Handles Switch.Click
        If Not Switch.Selected Then

            Scientifique.Location = New Point(186, Scientifique.Location.Y)
            Do Until Scientifique.Location.X = 248
                Scientifique.Location = New Point(Scientifique.Location.X + 1, Scientifique.Location.Y)

            Loop
        End If

        If Switch.Selected Then
            Scientifique.Location = New Point(248, Scientifique.Location.Y)
            Do Until Scientifique.Location.X = 186
                Scientifique.Location = New Point(Scientifique.Location.X - 1, Scientifique.Location.Y)

            Loop
        End If

    End Sub

    '**************************************************************************************************************************************

    Dim Position() As Integer
    Dim Element() As String
    Dim ans As String = "0"
    Dim compteur = 0, IndexPos As Integer = 0
    Dim operateur = False, dejaZero = False, dejaMoins = False, zeroPossible = False, dejaPoint = False, finish = False, errors = False
    Dim parenthese = False, fermerParenthese = False
    Dim puissanceCalcule As Double
    Dim racineCalcule As Double
    Private Function Factorielle(nombre As Double) As Double

        If nombre < 0 Then
            If nombre = 0 Then
                Return 1
            End If
            Return 0
        End If
        If nombre = 1 Then
            Return nombre

        Else
            Return nombre * Factorielle(nombre - 1)
        End If

    End Function

    Private Function Puissance(num1 As Double, exponant As Double) As Double
        If InStr(exponant.ToString, ".") Then
            puissanceCalcule = Math.Pow(num1, exponant)
            Return puissanceCalcule
        End If
        If exponant = 1 Then
            puissanceCalcule *= num1
            Return puissanceCalcule
        ElseIf exponant = -1 Then
            puissanceCalcule *= (1 / num1)
            Return puissanceCalcule
        End If

        If exponant > 0 Then
            puissanceCalcule *= num1
            Puissance(CDbl(num1), exponant - 1)
        ElseIf exponant < 0 Then
            puissanceCalcule *= (1 / num1)
            Puissance(CDbl(num1), exponant + 1)
        End If

        Return puissanceCalcule

    End Function

    Private Sub Moving(cases As Integer, operation As Integer)
        For i As Integer = operation To (Element.Count - 1) - cases
            Element(i) = Element(i + cases)
        Next
        ReDim Preserve Element(Element.GetUpperBound(0) - cases)

        ReDim Position(0)
        Dim incremente As Integer = 0
        Dim tableau As Integer = 0
        For Each boite As String In Element

            If boite = "+" Or boite = "/" Or boite = "x" Or boite = "^" Or boite = "√" Or boite = "∛" Or boite = "!" Then
                ReDim Preserve Position(incremente)
                Position(incremente) = tableau
                incremente += 1
            End If
            tableau += 1
        Next

    End Sub

    Private Sub clearScreen()
        If finish Then
            Screen.Clear()
            compteur = 0
            IndexPos = 0

            dejaPoint = False
            parenthese = False
        End If
        finish = False

    End Sub

    Private Function VerifieZero() As Boolean
        If Screen.Text.Length = 0 Then

            Return True
        ElseIf Screen.Text.Length > 0 And Not operateur And Screen.Text(Screen.Text.Length - 1) <> "0" Then
            zeroPossible = True
            Return True
        ElseIf Screen.Text.Length > 0 And zeroPossible Then
            Return True
        ElseIf Screen.Text.Length > 0 And Screen.Text(Screen.Text.Length - 1) = "0" Then
            Return False
        ElseIf operateur And Screen.Text(Screen.Text.Length - 1) <> "0" Then
            Return True

        End If
        Return False
    End Function

    Private Sub operation()

        Dim i As Integer = 0
        Dim num As Double

        If Position IsNot Nothing Then
            Do Until i = Position.GetUpperBound(0) + 1
                If Element(Position(i)) = "!" Then
                    If Element(Position(i) - 1) > 1111 Then
                        btn_clear.PerformClick()
                        Screen.Text = "Infinity"
                        finish = True

                        Exit Sub
                    End If
                    num = Factorielle(Element(Position(i) - 1))

                    Element(Position(i) - 1) = num
                    Moving(1, Position(i))
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop
            i = 0
            Do While i < Position.Count
                If Element(Position(i)) = "∛" Then
                    num = Math.Pow(Element(Position(i) + 1), 1 / 3)
                    Element(Position(i)) = num
                    Moving(1, Position(i) + 1)
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop
            i = 0
            Do While i < Position.Count
                If Element(Position(i)) = "√" Then
                    num = Math.Sqrt(Element(Position(i) + 1))
                    Element(Position(i)) = num
                    Moving(1, Position(i) + 1)
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop
            i = 0
            Do Until i = Position.GetUpperBound(0) + 1
                If Element(Position(i)) = "^" Then
                    puissanceCalcule = 1
                    num = Puissance(CDbl((Element(Position(i) - 1))), Element(Position(i) + 1))
                    Element(Position(i) - 1) = num
                    Moving(2, Position(i))
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop

            i = 0
            Do Until i = Position.GetUpperBound(0) + 1
                If Element(Position(i)) = "/" Then
                    If Element(Position(i) + 1) > 111 Then
                        btn_clear.PerformClick()
                        Screen.Text = "Infinity"
                        finish = True

                        Exit Sub
                    End If
                    num = CDbl(Element(Position(i) - 1)) / CDbl(Element(Position(i) + 1))
                    Element(Position(i) - 1) = num
                    Moving(2, Position(i))
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop

            i = 0
            Do Until i = Position.GetUpperBound(0) + 1
                If Element(Position(i)) = "x" Then
                    num = CDbl(Element(Position(i) - 1)) * CDbl(Element(Position(i) + 1))
                    Element(Position(i) - 1) = num
                    Moving(2, Position(i))
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If

                i += 1
            Loop

            i = 0
            Do While i <= Position.GetUpperBound(0)
                If Element(Position(i)) = "+" Then
                    num = CDbl(Element(Position(i) - 1)) + CDbl(Element(Position(i) + 1))
                    Element(Position(i) - 1) = num
                    Moving(2, Position(i))
                    Screen.Clear()
                    For Each boite As String In Element
                        Screen.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop

        End If

        i = Element.GetUpperBound(0)

        Do Until i = 0
            num = CDbl(Element(i)) + CDbl(Element(i - 1))
            Element(i - 1) = num
            ReDim Preserve Element(Element.GetUpperBound(0) - 1)
            i -= 1
            Screen.Clear()
            For Each boite As String In Element
                Screen.Text += boite
            Next
        Loop

        If Screen.Text = "NaN" Or Screen.Text = "Infinity" Then
            errors = True
            Exit Sub
        Else

            ans = Screen.Text

        End If

    End Sub

    Private Sub Ecrire(entrer As String, nombre As Boolean)


        If (dejaPoint And entrer = ".") Then 'pour le symbole point
            Timer1.Start()
            Exit Sub
        End If

        If entrer = "-" Then 'pour le symbole moins
            If Screen.TextLength <> 0 Then
                If Screen.Text(Screen.Text.Length - 1) = "." Then
                    Timer1.Start()
                    Exit Sub
                End If
            End If

            operateur = True
            If dejaMoins Then
                If parenthese = True Then
                    Exit Sub
                End If
                If Screen.TextLength = 1 Then
                    Exit Sub
                End If
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
                Screen.AppendText("+")
                operateur = True
                Exit Sub

            End If

            If dejaPoint Then
                dejaPoint = False
            End If
            If Screen.Text.Length <> 0 Then

                If fermerParenthese And parenthese And IsNumeric(Screen.Text(Screen.Text.Length - 1)) Then

                    Screen.Text += ")"
                    parenthese = False
                    fermerParenthese = False
                End If
                If operateur = True And Screen.Text(Screen.Text.Length - 1) <> "+" And Screen.Text(Screen.Text.Length - 1) <> "!" And Not IsNumeric(Screen.Text(Screen.Text.Length - 1)) And Screen.Text(Screen.Text.Length - 1) <> "(" And Screen.Text(Screen.Text.Length - 1) <> ")" Then
                    If dejaPoint Then
                        Exit Sub
                    End If
                    Screen.Text += "("
                    parenthese = True
                End If

                If Screen.Text(Screen.Text.Length - 1) = "+" Then
                    Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
                End If

            End If

            If Not Screen.Text.Length = 0 Then
                If Screen.Text(Screen.Text.Length - 1) = "-" Then
                    Timer1.Start()
                    Exit Sub
                End If

            End If

            Screen.Text += entrer
            dejaMoins = True
            finish = False
            Timer1.Stop()
            PictureBox2.Visible = False
        End If

        If nombre And entrer <> "-" Then 'pour tous les nombres
            clearScreen()


            If dejaZero And Not zeroPossible And Screen.Text.Length <> 0 And entrer <> "." Then
                If Screen.Text(Screen.Text.Length - 1) = "0" Then
                    Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
                End If

            End If
            If (operateur Or Screen.Text.Length = 0) And entrer = "." Then
                Screen.Text += "0."
            Else
                Screen.Text += entrer
            End If


            If entrer = "." Then
                dejaPoint = True
            End If


            operateur = False
            dejaMoins = False
            If parenthese Then
                fermerParenthese = True
            End If
            Timer1.Stop()
            PictureBox2.Visible = False
        ElseIf operateur = False And entrer <> "-" Then 'pour tous les operateurs
            If errors Then
                clearScreen()
                errors = False
                Exit Sub
            End If

            If Screen.TextLength <> 0 Then
                If Screen.Text(Screen.Text.Length - 1) = "." Then
                    Timer1.Start()
                    Exit Sub
                End If
            End If

            If Screen.Text.Length <> 0 Then
                If fermerParenthese And Not IsNumeric(Screen.Text(Screen.Text.Length - 1)) Then
                    Timer1.Start()
                    Exit Sub
                End If
            End If

            If parenthese Then
                Screen.Text += ")"
                parenthese = False
            End If
            If Not Screen.Text.Length = 0 Then
                If Screen.Text(Screen.Text.Length - 1) = "+" Or Screen.Text(Screen.Text.Length - 1) = "/" Or Screen.Text(Screen.Text.Length - 1) = "x" Or Screen.Text(Screen.Text.Length - 1) = "^" Then
                    Timer1.Start()
                    Exit Sub
                Else
                    Screen.Text += entrer
                End If

            End If
            dejaZero = False
            operateur = True
            zeroPossible = False
            dejaPoint = False
            finish = False
        End If
        Screen.SelectionStart = Screen.Text.Length
        Screen.ScrollToCaret()
        Screen.Refresh()
        Timer1.Stop()
        PictureBox2.Visible = False

    End Sub


    Private Sub btn_ans_Click(sender As Object, e As EventArgs) Handles btn_ans.Click
        If operateur Or Screen.Text.Length = 0 Then

            If CDbl(ans) < 0 And Screen.Text.Length <> 0 Then

                If Screen.Text(Screen.TextLength - 1) = "-" Then
                    Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
                    Dim num As Integer = -1
                    num *= ans
                    ans = "+" + num.ToString
                    Screen.Text += ans
                ElseIf Screen.Text(Screen.TextLength - 1) = "+" Then
                    Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
                    Screen.Text += ans
                Else
                    Screen.Text += "(" + ans + ")"
                End If

            Else
                If Screen.Text.Length = 0 And ans = "0" Then
                    finish = True
                End If
                Screen.Text += ans
            End If
        ElseIf Screen.Text.Length <> 0 Then
            If Screen.Text(Screen.Text.Length - 1) = "∛" Or Screen.Text(Screen.Text.Length - 1) = "√" Then
                Screen.Text += ans
            End If
        End If

        operateur = False
        finish = False
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        Ecrire("7", True)
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        Ecrire("4", True)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        Screen.Clear()
        compteur = 0
        IndexPos = 0
        ReDim Position(0)
        ReDim Element(0)
        dejaPoint = False
        parenthese = False
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        Ecrire("8", True)
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        Ecrire("9", True)
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        Ecrire("5", True)
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        Ecrire("6", True)
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Ecrire("3", True)
    End Sub

    Private Sub btn_Mul_Click(sender As Object, e As EventArgs) Handles btn_multiplication.Click
        Ecrire("x", False)
    End Sub

    Private Sub btn_Div_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        Ecrire("/", False)
    End Sub

    Private Sub btn_Plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        Ecrire("+", False)
    End Sub

    Private Sub btn_factoriel_Click(sender As Object, e As EventArgs) Handles btn_factoriel.Click
        If Screen.Text.Length > 0 Then
            If dejaZero Then
                dejaZero = False
            End If
            If finish Then
                clearScreen()
                finish = False
                Exit Sub

            End If
            If parenthese And IsNumeric(Screen.Text(Screen.TextLength - 1)) Then
                Screen.AppendText(")")
                parenthese = False
                fermerParenthese = False
                operateur = False
            End If

            If Screen.Text(Screen.TextLength - 1) <> "!" And ((IsNumeric(Screen.Text(Screen.TextLength - 1)) Or Screen.Text(Screen.TextLength - 1) = ")")) Then
                Ecrire("!", True)
                operateur = False
            End If

            If operateur Then
                If Screen.Text(Screen.TextLength - 1) <> "!" And IsNumeric(Screen.Text(Screen.TextLength - 1)) Then
                    Ecrire("!", False)
                    operateur = False
                End If
            End If
        End If
        Switch.PerformClick()
        Switch.Selected = True
        Switch.Refresh()

    End Sub

    Private Sub btn_puissance_Click(sender As Object, e As EventArgs) Handles btn_puissance.Click
        Ecrire("^", False)
        Switch.PerformClick()
        Switch.Selected = True
        Switch.Refresh()
    End Sub

    Private Sub btn_racine_Click(sender As Object, e As EventArgs) Handles btn_racine.Click
        If finish Then
            clearScreen()

        End If
        If Screen.Text.Length = 0 Then
            Ecrire("√", True)
        ElseIf operateur Then
            Ecrire("√", True)
        End If
        Switch.PerformClick()
        Switch.Selected = True
        Switch.Refresh()
    End Sub

    Private Sub btn_cubique_Click(sender As Object, e As EventArgs) Handles btn_cubique.Click
        If finish Then
            clearScreen()
        End If
        If Screen.Text.Length = 0 Then
            Ecrire("∛", True)
        ElseIf operateur Then
            Ecrire("∛", True)
        End If
        Switch.PerformClick()
        Switch.Selected = True
        Switch.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox2.Visible = False Then
            PictureBox2.Visible = True
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("Insert a number", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub btn_Moins_Click(sender As Object, e As EventArgs) Handles btn_moins.Click
        Ecrire("-", True)
    End Sub

    Private Sub btn_Egale_Click(sender As Object, e As EventArgs) Handles btn_egale.Click

        If operateur Then
            Timer1.Start()
            Exit Sub
        End If
        If Screen.TextLength <> 0 Then
            If Screen.Text(Screen.Text.Length - 1) = "." Then
                Timer1.Start()
                Exit Sub
            End If
        End If
        If parenthese Then
            Screen.Text += ")"
            parenthese = False
            Exit Sub
        End If
        Dim Exponant As Boolean
        Answer_Box.Text = Screen.Text
        For Each caractere As String In Screen.Text()
            If caractere = "(" Or caractere = ")" Then
                If caractere = "(" Then
                    compteur -= 1
                End If
                Continue For
            End If
            If Exponant Then
                ReDim Preserve Element(compteur)
                Element(compteur) += caractere
                Exponant = False
                Continue For

            End If
            If caractere = "E" Then
                Exponant = True
            End If

            If caractere = "+" Or caractere = "x" Or caractere = "/" Or caractere = "-" Or caractere = "^" Or caractere = "√" Or caractere = "∛" Or caractere = "!" Then
                compteur += 1

                ReDim Preserve Position(IndexPos)
                Position(IndexPos) = compteur
                If caractere = "!" Then
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "!"

                    IndexPos += 1
                ElseIf caractere = "∛" Then
                    compteur -= 1
                    Position(IndexPos) = compteur
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "∛"
                    compteur += 1
                    IndexPos += 1
                ElseIf caractere = "√" Then
                    compteur -= 1
                    Position(IndexPos) = compteur
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "√"
                    compteur += 1
                    IndexPos += 1
                ElseIf caractere = "^" Then
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "^"
                    compteur += 1
                    IndexPos += 1
                ElseIf caractere = "/" Then
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "/"
                    compteur += 1
                    IndexPos += 1
                ElseIf caractere = "x" Then
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "x"
                    compteur += 1
                    IndexPos += 1
                ElseIf caractere = "+" Then
                    ReDim Preserve Element(compteur)
                    Element(compteur) = "+"
                    compteur += 1
                    IndexPos += 1
                ElseIf caractere = "-" Then
                    ReDim Preserve Element(compteur)
                    Element(compteur) += "-"
                End If
            Else
                ReDim Preserve Element(compteur)
                Element(compteur) += caractere
            End If
        Next
        operation()
        compteur = 0
        IndexPos = 0
        ReDim Position(0)
        ReDim Element(0)
        finish = True
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        Ecrire("1", True)
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        clearScreen()

        If VerifieZero() Then
            dejaZero = VerifieZero()

            Ecrire("0", True)
        End If
    End Sub

    Private Sub btn_Point_Click(sender As Object, e As EventArgs) Handles btn_point.Click
        Ecrire(".", True)
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        Ecrire("2", True)
    End Sub

    Private Sub Back(sender As Object, e As EventArgs) Handles btn_back.Click
        If Screen.Text.Length <> 0 Then
            If Screen.Text(Screen.Text.Length - 1) = "+" Or Screen.Text(Screen.Text.Length - 1) = "-" Or Screen.Text(Screen.Text.Length - 1) = "x" Or Screen.Text(Screen.Text.Length - 1) = "^" Or Screen.Text(Screen.Text.Length - 1) = "/" Or Screen.Text(Screen.Text.Length - 1) = "√" Or Screen.Text(Screen.Text.Length - 1) = "∛" Or Screen.Text(Screen.Text.Length - 1) = "!" Then
                operateur = False

            End If
            If Screen.Text(Screen.Text.Length - 1) = "-" Then
                If Screen.Text(Screen.Text.Length - 2) = "(" Then
                    Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
                End If
                dejaMoins = False
            End If
            If Screen.Text(Screen.Text.Length - 1) = "." Then
                dejaPoint = False
            End If
            If Screen.Text(Screen.Text.Length - 1) = "(" Then
                parenthese = False
            End If
            If Screen.Text(Screen.Text.Length - 1) = ")" Then
                parenthese = True
                fermerParenthese = True
            End If
            If Screen.Text(Screen.Text.Length - 1) = ")" Then
                zeroPossible = False
                dejaZero = False
            End If
            If Screen.Text(Screen.Text.Length - 1) = "." Then
                dejaPoint = False
                If Screen.Text(Screen.Text.Length - 2) = "0" Then
                    dejaZero = True
                End If

            End If
            Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles Minimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Close()
            splash_screen.Close()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

End Class
