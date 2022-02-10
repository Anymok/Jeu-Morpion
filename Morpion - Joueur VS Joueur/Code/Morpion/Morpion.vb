Public Class Morpion

    Dim nomX As String = InputBox("Quel est le nom du premier joueur ?", "Nom")
    Dim nomO As String = InputBox("Quel est le nom du deuxième joueur ?", "Nom")
    Dim joueur As Boolean = True
    Dim nombrecoup As Int16
    Dim victoire As Boolean = False




    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        Application.Restart()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pseudo()
    End Sub
    Public Sub Pseudo()
        If nomX = "" Then
            nomX = "L'équipe des croix"
            LabelJoueurX.Text = "Équipe des croix"
        End If

        If nomO = "" Then
            nomO = "L'équipe des ronds"
            LabelJoueurO.Text = "Équipe des ronds"
        End If

        If (nomX IsNot "") And (nomX IsNot "L'équipe des croix") Then
            LabelJoueurX.Text = nomX
        End If

        If (nomO IsNot "") And (nomO IsNot "L'équipe des ronds") Then
            LabelJoueurO.Text = nomO
        End If
    End Sub
    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click
        Close()
    End Sub
    Private Sub egalite()
        If nombrecoup = 9 And victoire = False Then
            MsgBox("Égalité")
        End If
    End Sub
    Private Sub cmdAgain_Click(sender As Object, e As EventArgs) Handles cmdAgain.Click
        TextCase1.Text = ""
        TextCase1.Enabled = True
        TextCase2.Text = ""
        TextCase2.Enabled = True
        TextCase3.Text = ""
        TextCase3.Enabled = True
        TextCase4.Text = ""
        TextCase4.Enabled = True
        TextCase5.Text = ""
        TextCase5.Enabled = True
        TextCase6.Text = ""
        TextCase6.Enabled = True
        TextCase7.Text = ""
        TextCase7.Enabled = True
        TextCase8.Text = ""
        TextCase8.Enabled = True
        TextCase9.Text = ""
        TextCase9.Enabled = True
        nombrecoup = 0
        victoire = False
    End Sub
    Private Sub cmdScoreReset_Click(sender As Object, e As EventArgs) Handles cmdScoreReset.Click
        TextCase1.Text = ""
        TextCase1.Enabled = True
        TextCase2.Text = ""
        TextCase2.Enabled = True
        TextCase3.Text = ""
        TextCase3.Enabled = True
        TextCase4.Text = ""
        TextCase4.Enabled = True
        TextCase5.Text = ""
        TextCase5.Enabled = True
        TextCase6.Text = ""
        TextCase6.Enabled = True
        TextCase7.Text = ""
        TextCase7.Enabled = True
        TextCase8.Text = ""
        TextCase8.Enabled = True
        TextCase9.Text = ""
        TextCase9.Enabled = True
        TextJoueurO.Text = "0"
        TextJoueurX.Text = "0"
        nombrecoup = 0
        victoire = False
    End Sub


    Private Sub TextCase1_TextChanged(sender As Object, e As EventArgs) Handles TextCase1.Click

        TextCase1.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase1.Text = "X"
            nombrecoup += 1

        Else
            TextCase1.Text = "O"
            nombrecoup += 1
        End If


        TextCase1.Enabled = False

        If ((TextCase1.Text = TextCase2.Text) And (TextCase1.Text = TextCase3.Text)) Or ((TextCase1.Text = TextCase4.Text) And (TextCase1.Text = TextCase7.Text)) Or ((TextCase1.Text = TextCase5.Text) And (TextCase1.Text = TextCase9.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub

    Private Sub TextCase2_TextChanged(sender As Object, e As EventArgs) Handles TextCase2.Click
        TextCase2.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase2.Text = "X"
            nombrecoup += 1
        Else
            TextCase2.Text = "O"
            nombrecoup += 1
        End If

        TextCase2.Enabled = False

        If ((TextCase2.Text = TextCase1.Text) And (TextCase2.Text = TextCase3.Text)) Or ((TextCase2.Text = TextCase5.Text) And (TextCase2.Text = TextCase8.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub

    Private Sub TextCase3_TextChanged(sender As Object, e As EventArgs) Handles TextCase3.Click
        TextCase3.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase3.Text = "X"
            nombrecoup += 1
        Else
            TextCase3.Text = "O"
            nombrecoup += 1
        End If

        TextCase3.Enabled = False

        If ((TextCase3.Text = TextCase2.Text) And (TextCase3.Text = TextCase1.Text)) Or ((TextCase3.Text = TextCase6.Text) And (TextCase3.Text = TextCase9.Text)) Or ((TextCase3.Text = TextCase5.Text) And (TextCase3.Text = TextCase7.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub

    Private Sub TextCase4_TextChanged(sender As Object, e As EventArgs) Handles TextCase4.Click
        TextCase4.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase4.Text = "X"
            nombrecoup += 1
        Else
            TextCase4.Text = "O"
            nombrecoup += 1
        End If

        TextCase4.Enabled = False

        If ((TextCase4.Text = TextCase1.Text) And (TextCase4.Text = TextCase7.Text)) Or ((TextCase4.Text = TextCase5.Text) And (TextCase4.Text = TextCase6.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If
        egalite()

        joueur = Not joueur

    End Sub

    Private Sub TextCase5_TextChanged(sender As Object, e As EventArgs) Handles TextCase5.Click
        TextCase5.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase5.Text = "X"
            nombrecoup += 1
        Else

            TextCase5.Text = "O"
            nombrecoup += 1
        End If

        TextCase5.Enabled = False



        If ((TextCase5.Text = TextCase2.Text) And (TextCase5.Text = TextCase7.Text)) Or ((TextCase5.Text = TextCase4.Text) And (TextCase5.Text = TextCase6.Text)) Or ((TextCase5.Text = TextCase1.Text) And (TextCase5.Text = TextCase9.Text)) Or ((TextCase5.Text = TextCase3.Text) And (TextCase5.Text = TextCase7.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur


    End Sub


    Private Sub TextCase6_TextChanged(sender As Object, e As EventArgs) Handles TextCase6.Click
        TextCase6.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase6.Text = "X"
            nombrecoup += 1
        Else

            TextCase6.Text = "O"
            nombrecoup += 1
        End If

        TextCase6.Enabled = False



        If ((TextCase6.Text = TextCase3.Text) And (TextCase6.Text = TextCase9.Text)) Or ((TextCase6.Text = TextCase5.Text) And (TextCase6.Text = TextCase4.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub
    Private Sub TextCase7_TextChanged(sender As Object, e As EventArgs) Handles TextCase7.Click
        TextCase7.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase7.Text = "X"
            nombrecoup += 1
        Else

            TextCase7.Text = "O"
            nombrecoup += 1
        End If

        TextCase7.Enabled = False



        If ((TextCase7.Text = TextCase8.Text) And (TextCase7.Text = TextCase9.Text)) Or ((TextCase7.Text = TextCase4.Text) And (TextCase7.Text = TextCase1.Text)) Or ((TextCase7.Text = TextCase5.Text) And (TextCase7.Text = TextCase3.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub


    Private Sub TextCase8_TextChanged(sender As Object, e As EventArgs) Handles TextCase8.Click
        TextCase8.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase8.Text = "X"
            nombrecoup += 1
        Else

            TextCase8.Text = "O"
            nombrecoup += 1
        End If

        TextCase8.Enabled = False


        If ((TextCase8.Text = TextCase7.Text) And (TextCase8.Text = TextCase9.Text)) Or ((TextCase8.Text = TextCase5.Text) And (TextCase8.Text = TextCase2.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub

    Private Sub TextCase9_TextChanged(sender As Object, e As EventArgs) Handles TextCase9.Click
        TextCase9.Font = New Font("comic sans ms", 30)
        If joueur Then
            TextCase9.Text = "X"
            nombrecoup += 1
        Else

            TextCase9.Text = "O"
            nombrecoup += 1
        End If

        TextCase9.Enabled = False

        If ((TextCase9.Text = TextCase8.Text) And (TextCase9.Text = TextCase7.Text)) Or ((TextCase9.Text = TextCase6.Text) And (TextCase9.Text = TextCase3.Text)) Or ((TextCase9.Text = TextCase5.Text) And (TextCase9.Text = TextCase1.Text)) Then
            If joueur = True Then
                TextJoueurX.Text += 1
                MsgBox(nomX & " gagne")
                victoire = True
            Else
                TextJoueurO.Text += 1
                MsgBox(nomO & " gagne")
                victoire = True
            End If

            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False

        End If

        egalite()

        joueur = Not joueur

    End Sub


End Class