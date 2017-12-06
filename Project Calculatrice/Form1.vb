Public Class Form1
    Dim Element() As String
    Dim Position() As Integer
    Dim IndexPos As Integer = 0
    Dim Dejamoins As Boolean = False
    Dim compteur As Integer = 0 ' compteur = position 
    Dim back = False
    Dim answer = False
    Dim operateur = False
    Dim moinsExiste = False
    Dim LePoint = True
    Dim EncoreZero = False

    Private Sub Moving(cases As Integer, operation As Integer)
        For i As Integer = operation To (Element.Count - 1) - cases
            Element(i) = Element(i + cases)
        Next
        ReDim Preserve Element(Element.GetUpperBound(0) - cases)

        ReDim Position(0)
        Dim incremente As Integer = 0
        Dim tableau As Integer = 0
        For Each boite As String In Element

            If boite = "+" Or boite = "/" Or boite = "x" Then
                ReDim Preserve Position(incremente)
                Position(incremente) = tableau
                incremente += 1
            End If
            tableau += 1
        Next

    End Sub

    Private Sub Ecrire(Entrer As String, Nombre As Boolean)
        If answer And Nombre = True And Not Entrer = "-" Then
            TextBox1.Clear()
            ReDim Position(0)
            ReDim Element(0)
            Button17.Enabled = True
            answer = False
        End If

        ReDim Preserve Element(compteur)
        If Entrer = "-" Then
            MessageBox.Show("Hi")
            If Not moinsExiste Then

                If Not Dejamoins Then
                    If Not TextBox1.Text.Length = 0 Then
                        compteur += 1
                    End If
                    ReDim Preserve Element(compteur)

                End If


                TextBox1.AppendText(Entrer)
                Element(compteur) += Entrer
                answer = False
            End If


        ElseIf Nombre Then

            If Entrer = "." Then
                If LePoint Then
                    MessageBox.Show("Nombre de boite: " + Element.Count.ToString)
                    If TextBox1.Text.Length = 0 Or Element(compteur) Is Nothing Then
                        TextBox1.AppendText("0.")
                    Else

                        TextBox1.AppendText(Entrer)
                    End If

                    If TextBox1.Text.Length > 1 Then
                        If back = True AndAlso (TextBox1.Text(TextBox1.Text.Count - 2) = "+" Or TextBox1.Text(TextBox1.Text.Count - 2) = "x" Or TextBox1.Text(TextBox1.Text.Count - 2) = "/") Then
                            compteur += 1
                            ReDim Preserve Element(compteur)
                            back = False
                        End If

                    End If


                    Element(compteur) += Entrer
                    Dejamoins = False
                    operateur = False
                    moinsExiste = False
                    LePoint = False
                    EncoreZero = False
                End If

            Else
                If Entrer = "0" And EncoreZero = False Or operateur Then
                    EncoreZero = True
                ElseIf EncoreZero And Entrer = "0" Then
                    Exit Sub
                End If
                MessageBox.Show("Nombre de boite: " + Element.Count.ToString)
                If EncoreZero And Entrer <> "0" Then
                    If TextBox1.Text.Length <> 0 Then
                        TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                    Else
                        TextBox1.Text = Entrer
                    End If

                    EncoreZero = False
                End If

                TextBox1.AppendText(Entrer)

                If TextBox1.Text.Length > 1 Then
                    If back = True AndAlso (TextBox1.Text(TextBox1.Text.Count - 2) = "+" Or TextBox1.Text(TextBox1.Text.Count - 2) = "x" Or TextBox1.Text(TextBox1.Text.Count - 2) = "/") Then
                        compteur += 1
                        ReDim Preserve Element(compteur)
                        back = False
                    End If

                End If


                Element(compteur) += Entrer
                Dejamoins = False
                operateur = False
                moinsExiste = False

            End If

        Else
            'Creer une boite d'operation
            If Not moinsExiste Then

                If operateur = False Then

                    TextBox1.AppendText(Entrer)
                    compteur += 1
                    ReDim Preserve Element(compteur)
                    Element(compteur) = Entrer
                    ReDim Preserve Position(IndexPos)
                    Position(IndexPos) = compteur
                    IndexPos += 1
                    compteur += 1
                    Dejamoins = True
                    answer = False
                    operateur = True
                    LePoint = True
                End If
            End If


        End If


    End Sub

    Private Sub operation()

        Dim i As Integer = 0
        Dim num As Double
        'Do Until Position(Position.GetUpperBound(0)) = 0
        If Position IsNot Nothing Then
            Do Until i = Position.GetUpperBound(0) + 1
                If Element(Position(i)) = "/" Then
                    num = CDbl(Element(Position(i) - 1)) / CDbl(Element(Position(i) + 1))
                    Element(Position(i) - 1) = num
                    Moving(2, Position(i))
                    TextBox1.Clear()
                    For Each boite As String In Element
                        TextBox1.Text += boite
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
                    TextBox1.Clear()
                    For Each boite As String In Element
                        TextBox1.Text += boite
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
                    TextBox1.Clear()
                    For Each boite As String In Element
                        TextBox1.Text += boite
                    Next
                    i -= 1
                End If
                i = i + 1
            Loop

        End If

        'Loop

        i = Element.GetUpperBound(0)

        Do Until i = 0
            num = CDbl(Element(i)) + CDbl(Element(i - 1))
            Element(i - 1) = num
            ReDim Preserve Element(Element.GetUpperBound(0) - 1)
            i -= 1
            TextBox1.Clear()
            For Each boite As String In Element
                TextBox1.Text += boite
            Next
        Loop

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ecrire("1", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ecrire("2", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ecrire("3", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ecrire("4", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ecrire("5", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ecrire("6", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Ecrire("7", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Ecrire("8", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Ecrire("9", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Ecrire("0", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Ecrire(".", True)
        MessageBox.Show(Element(compteur), "Boite actuelle:" + compteur.ToString)


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Ecrire("+", False)
        'MessageBox.Show("Position P:" + Position(IndexPos - 1).ToString, "Boite actuelle:" + (compteur - 1).ToString)


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Ecrire("-", True)
        moinsExiste = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Ecrire("/", False)
        'MessageBox.Show("Position P:" + Position(IndexPos - 1).ToString, "Boite actuelle:" + (compteur - 1).ToString)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Ecrire("x", False)
        'MessageBox.Show("Position P:" + Position(IndexPos - 1).ToString, "Boite actuelle:" + (compteur - 1).ToString)
       
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ListBox1.Items.Clear()

        'For i As Integer = 0 To Element.Count - 1
        '    ListBox1.Items.Add(Element(i))

        'Next
        'ListBox1.Items.Add("Position Operator: ")

        'For i As Integer = 0 To Position.Count - 1
        '    ListBox1.Items.Add(Position(i))

        'Next

        If Not (TextBox1.Text.Count = 0) And Not answer Then
            If Not Dejamoins And Not TextBox1.Text(TextBox1.Text.Count - 1) = "-" Then
                operation()
                IndexPos = 0
                compteur = 0
                answer = True
                operateur = False
            End If
        End If


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        back = True
        If answer Then
            Button17.Enabled = False
            Exit Sub
        End If
        If TextBox1.Text.Length <> 0 And (Element.GetUpperBound(0) + 1) > 0 Then

            'If Element(Element.GetUpperBound(0)).Length >= 0 Then
            If Element IsNot Nothing Then
                If Element(Element.GetUpperBound(0)) = "-" Then
                    moinsExiste = False
                End If
                Try
                    Element(Element.GetUpperBound(0)) = Element(Element.GetUpperBound(0)).Substring(0, Element(Element.GetUpperBound(0)).Length - 1) 'effacer 1 character'

                Catch ex As Exception
                    ReDim Preserve Element(Element.GetUpperBound(0) - 1)
                End Try

                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                MessageBox.Show("Length of Element : " + Element(Element.GetUpperBound(0)).Length.ToString, "Position Element: " + Element.Count.ToString)

                If Element(Element.GetUpperBound(0)).Length = 0 Then
                    operateur = True
                    If Position IsNot Nothing Then

                        For i As Integer = 0 To Position.Count - 1
                            If Element.GetUpperBound(0) = Position(i) Then
                                ReDim Preserve Position(Position.GetUpperBound(0) - 1)

                                MessageBox.Show(Element.Count)
                                IndexPos = IndexPos - 1
                                Dejamoins = False
                                operateur = False
                                back = False
                                LePoint = False

                            End If

                        Next
                        ReDim Preserve Element(Element.GetUpperBound(0) - 1)
                        If compteur > 0 Then
                            compteur = compteur - 1
                        End If

                    End If




                    'MessageBox.Show("Nombre de boite P: " + Position.Count.ToString + " Compteur : " + compteur.ToString + " IndexPos : " + IndexPos.ToString, "Nombre de boite : " + Element.Count.ToString)

                End If
            End If

        End If

    End Sub


End Class
