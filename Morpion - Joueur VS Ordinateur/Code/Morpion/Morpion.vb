Public Class Morpion
    '============================================================== VARIABLE =============================================================='
    Dim nomX As String = InputBox("Quel est le nom du joueur ?", "Nom")
    Dim nomO As String = "Ordinateur"
    Dim joueur As Boolean = True
    Public tab(8) As Integer
    Dim égalité As Boolean = False
    Dim number As Int32 = 1
    Dim i As Int16 = 0
    Dim r As Int16 = 0
    Private victoire As Boolean = False
    Dim nombre_coup As Int32 = 0
    '============================================================== VARIABLE =============================================================='






    '============================================================== CALCUL =============================================================='
    Public Sub Tableau()
        If (tab(0) = 15) Or (tab(1) = 15) Or (tab(2) = 15) Or (tab(3) = 15) Or (tab(4) = 15) Or (tab(5) = 15) Or (tab(6) = 15) Or (tab(7) = 15) Then
            TextJoueurX.Text += 1
            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False
            MsgBox(nomX & " gagne")
            victoire = True
            If Checkeffectvictoire.Checked = True Then
                effect()
            End If

        End If
        If (tab(0) = 9) Or (tab(1) = 9) Or (tab(2) = 9) Or (tab(3) = 9) Or (tab(4) = 9) Or (tab(5) = 9) Or (tab(6) = 9) Or (tab(7) = 9) Then
            TextJoueurO.Text += 1
            TextCase1.Enabled = False
            TextCase2.Enabled = False
            TextCase3.Enabled = False
            TextCase4.Enabled = False
            TextCase5.Enabled = False
            TextCase6.Enabled = False
            TextCase7.Enabled = False
            TextCase8.Enabled = False
            TextCase9.Enabled = False
            MsgBox(nomO & " gagne")
            victoire = True
            If Checkeffectdefaite.Checked = True Then
                effect1()
            End If

        End If
    End Sub
    Public Sub Pseudo()
        If nomX = "" Then
            nomX = "L'équipe des croix"
            LabelJoueurX.Text = "Équipe des croix"
        End If
        If (nomX IsNot "") And (nomX IsNot "L'équipe des croix") Then
            LabelJoueurX.Text = nomX
        End If
        LabelJoueurO.Text = nomO
    End Sub
    Private Sub egalite()
        If (nombre_coup = 9) And (victoire = False) Then
            égalité = True
            MsgBox("Égalité")
        End If
    End Sub
    '============================================================== CALCUL =============================================================='






    '============================================================== BOUTON =============================================================='
    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        Application.Restart()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pseudo()
    End Sub
    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click
        Close()
    End Sub
    Private Sub cmdAgain_Click(sender As Object, e As EventArgs) Handles cmdAgain.Click
        égalité = False
        victoire = False
        nombre_coup = 0
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
        tab(0) = 0
        tab(1) = 0
        tab(2) = 0
        tab(3) = 0
        tab(4) = 0
        tab(5) = 0
        tab(6) = 0
        tab(7) = 0
        clear()
        number = 0
        If joueur = False Then
            random()
        End If
    End Sub
    Private Sub cmdScoreReset_Click(sender As Object, e As EventArgs) Handles cmdScoreReset.Click
        égalité = False
        victoire = False
        nombre_coup = 0
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
        tab(0) = 0
        tab(1) = 0
        tab(2) = 0
        tab(3) = 0
        tab(4) = 0
        tab(5) = 0
        tab(6) = 0
        tab(7) = 0
        clear()
        number = 0
    End Sub
    '============================================================== BOUTON =============================================================='






    '============================================================== CASE =============================================================='
    Private Sub TextCase1_click(sender As Object, e As EventArgs) Handles TextCase1.Click
        If joueur Then
            raccourci_play(1)
            case1(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase2_click(sender As Object, e As EventArgs) Handles TextCase2.Click
        If joueur Then
            raccourci_play(2)
            case2(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase3_click(sender As Object, e As EventArgs) Handles TextCase3.Click
        If joueur Then
            raccourci_play(3)
            case3(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase4_click(sender As Object, e As EventArgs) Handles TextCase4.Click
        If joueur Then
            raccourci_play(4)
            case4(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase5_click(sender As Object, e As EventArgs) Handles TextCase5.Click
        If joueur Then
            raccourci_play(5)
            case5(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase6_click(sender As Object, e As EventArgs) Handles TextCase6.Click
        If joueur Then
            raccourci_play(6)
            case6(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase7_click(sender As Object, e As EventArgs) Handles TextCase7.Click
        If joueur Then
            raccourci_play(7)
            case7(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase8_click(sender As Object, e As EventArgs) Handles TextCase8.Click
        If joueur Then
            raccourci_play(8)
            case8(True)
        End If
        raccourci()
    End Sub
    Private Sub TextCase9_click(sender As Object, e As EventArgs) Handles TextCase9.Click
        If joueur Then
            raccourci_play(9)
            case9(True)
        End If
        raccourci()
    End Sub
    '============================================================== CASE =============================================================='






    '============================================================== RACCOURCI =============================================================='
    Private Sub raccourci_play(int)
        If (int = 1) Then
            TextCase1.Text = "X"
            TextCase1.Enabled = False
        End If
        If (int = 2) Then
            TextCase2.Text = "X"
            TextCase2.Enabled = False
        End If
        If (int = 3) Then
            TextCase3.Text = "X"
            TextCase3.Enabled = False
        End If
        If (int = 4) Then
            TextCase4.Text = "X"
            TextCase4.Enabled = False
        End If
        If (int = 5) Then
            TextCase5.Text = "X"
            TextCase5.Enabled = False
        End If
        If (int = 6) Then
            TextCase6.Text = "X"
            TextCase6.Enabled = False
        End If
        If (int = 7) Then
            TextCase7.Text = "X"
            TextCase7.Enabled = False
        End If
        If (int = 8) Then
            TextCase8.Text = "X"
            TextCase8.Enabled = False
        End If
        If (int = 9) Then
            TextCase9.Text = "X"
            TextCase9.Enabled = False
        End If
        joueur = Not joueur
        nombre_coup += 1
    End Sub
    Private Sub raccourci()
        Tableau()
        egalite()
        clear()
        AI()
    End Sub
    Private Sub clear()
        i = 0
        r = 0
    End Sub
    Private Sub case1(bool)
        If (bool = True) Then
            tab(0) = tab(0) + 5
            tab(5) = tab(5) + 5
            tab(7) = tab(7) + 5
        End If
        If (bool = False) Then
            tab(0) = tab(0) + 3
            tab(5) = tab(5) + 3
            tab(7) = tab(7) + 3
        End If
    End Sub
    Private Sub case2(bool)
        If (bool = True) Then
            tab(0) = tab(0) + 5
            tab(4) = tab(4) + 5
        End If
        If (bool = False) Then
            tab(0) = tab(0) + 3
            tab(4) = tab(4) + 3
        End If
    End Sub
    Private Sub case3(bool)
        If (bool = True) Then
            tab(0) = tab(0) + 5
            tab(3) = tab(3) + 5
            tab(6) = tab(6) + 5
        End If
        If (bool = False) Then
            tab(0) = tab(0) + 3
            tab(3) = tab(3) + 3
            tab(6) = tab(6) + 3
        End If
    End Sub
    Private Sub case4(bool)
        If (bool = True) Then
            tab(1) = tab(1) + 5
            tab(5) = tab(5) + 5
        End If
        If (bool = False) Then
            tab(1) = tab(1) + 3
            tab(5) = tab(5) + 3
        End If
    End Sub
    Private Sub case5(bool)
        If (bool = True) Then
            tab(1) = tab(1) + 5
            tab(4) = tab(4) + 5
            tab(6) = tab(6) + 5
            tab(7) = tab(7) + 5
        End If
        If (bool = False) Then
            tab(1) = tab(1) + 3
            tab(4) = tab(4) + 3
            tab(6) = tab(6) + 3
            tab(7) = tab(7) + 3
        End If
    End Sub
    Private Sub case6(bool)
        If (bool = True) Then
            tab(1) = tab(1) + 5
            tab(3) = tab(3) + 5
        End If
        If (bool = False) Then
            tab(1) = tab(1) + 3
            tab(3) = tab(3) + 3
        End If
    End Sub
    Private Sub case7(bool)
        If (bool = True) Then
            tab(2) = tab(2) + 5
            tab(5) = tab(5) + 5
            tab(6) = tab(6) + 5
        End If
        If (bool = False) Then
            tab(2) = tab(2) + 3
            tab(5) = tab(5) + 3
            tab(6) = tab(6) + 3
        End If
    End Sub
    Private Sub case8(bool)
        If (bool = True) Then
            tab(2) = tab(2) + 5
            tab(4) = tab(4) + 5
        End If
        If (bool = False) Then
            tab(2) = tab(2) + 3
            tab(4) = tab(4) + 3
        End If
    End Sub
    Private Sub case9(bool)
        If (bool = True) Then
            tab(2) = tab(2) + 5
            tab(3) = tab(3) + 5
            tab(7) = tab(7) + 5
        End If
        If (bool = False) Then
            tab(2) = tab(2) + 3
            tab(3) = tab(3) + 3
            tab(7) = tab(7) + 3
        End If
    End Sub

    '============================================================== RACCOURCI =============================================================='






    '============================================================== AI =============================================================='
    Private Sub random()
        If (égalité = False) And (victoire = False) Then
            number = Int((9 * Rnd()) + 1)
            If (number = 1) And (TextCase1.Enabled = True) And (joueur = False) Then
                TextCase1.Text = "O"
                TextCase1.Enabled = False
                case1(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 1) Then
                clear()
                AI()
            End If
            If (number = 2) And (TextCase2.Enabled = True) And (joueur = False) Then
                TextCase2.Text = "O"
                TextCase2.Enabled = False
                case2(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 2) Then
                clear()
                AI()
            End If
            If (number = 3) And (TextCase3.Enabled = True) And (joueur = False) Then
                TextCase3.Text = "O"
                TextCase3.Enabled = False
                case3(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 3) Then
                clear()
                AI()
            End If
            If (number = 4) And (TextCase4.Enabled = True) And (joueur = False) Then
                TextCase4.Text = "O"
                TextCase4.Enabled = False
                case4(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 4) Then
                clear()
                AI()
            End If
            If (number = 5) And (TextCase5.Enabled = True) And (joueur = False) Then
                TextCase5.Text = "O"
                TextCase5.Enabled = False
                case5(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 5) Then
                clear()
                AI()
            End If
            If (number = 6) And (TextCase6.Enabled = True) And (joueur = False) Then
                TextCase6.Text = "O"
                TextCase6.Enabled = False
                case6(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 6) Then
                clear()
                AI()
            End If
            If (number = 7) And (TextCase7.Enabled = True) And (joueur = False) Then
                TextCase7.Text = "O"
                TextCase7.Enabled = False
                case7(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 7) Then
                clear()
                AI()
            End If
            If (number = 8) And (TextCase8.Enabled = True) And (joueur = False) Then
                TextCase8.Text = "O"
                TextCase8.Enabled = False
                case8(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 8) Then
                clear()
                AI()
            End If
            If (number = 9) And (TextCase9.Enabled = True) And (joueur = False) Then
                TextCase9.Text = "O"
                TextCase9.Enabled = False
                case9(False)
                joueur = Not joueur
                Tableau()
                nombre_coup += 1
            ElseIf (number = 9) Then
                clear()
                AI()
            End If
            If (number < 0) And (number > 9) Then
                random()
            End If
        End If
    End Sub
    Public Sub AI()
        If (joueur = False) And (égalité = False) And (victoire = False) Then
            While (joueur = False) And (égalité = False)
                If (i < 8) Then
                    If (tab(i) = 6) And (i < 8) And (joueur = False) Then
                        If (tab(0) = "6") And (joueur = False) Then
                            If (TextCase1.Enabled = True) And (TextCase1.Text = "") And (joueur = False) Then
                                TextCase1.Text = "O"
                                TextCase1.Enabled = False
                                case1(False)
                                joueur = Not joueur
                                Me.Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase2.Enabled = True) And (TextCase2.Text = "") And (joueur = False) Then
                                TextCase2.Text = "O"
                                TextCase2.Enabled = False
                                case2(False)
                                joueur = Not joueur
                                Me.Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase3.Enabled = True) And (TextCase3.Text = "") And (joueur = False) Then
                                TextCase3.Text = "O"
                                TextCase3.Enabled = False
                                case3(False)
                                joueur = Not joueur
                                Me.Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(1) = "6") And (joueur = False) Then
                            If (TextCase4.Enabled = True) And (TextCase4.Text = "") And (joueur = False) Then
                                TextCase4.Text = "O"
                                TextCase4.Enabled = False
                                case4(False)
                                joueur = Not joueur
                                Me.Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Me.Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase6.Enabled = True) And (TextCase6.Text = "") And (joueur = False) Then
                                TextCase6.Text = "O"
                                TextCase6.Enabled = False
                                case6(False)
                                joueur = Not joueur
                                Me.Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(2) = "6") And (joueur = False) Then
                            If (TextCase7.Enabled = True) And (TextCase7.Text = "") And (joueur = False) Then
                                TextCase7.Text = "O"
                                TextCase7.Enabled = False
                                case7(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase8.Enabled = True) And (TextCase8.Text = "") And (joueur = False) Then
                                TextCase8.Text = "O"
                                TextCase8.Enabled = False
                                case8(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase9.Enabled = True) And (TextCase9.Text = "") And (joueur = False) Then
                                TextCase9.Text = "O"
                                TextCase9.Enabled = False
                                case9(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(3) = "6") And (joueur = False) Then
                            If (TextCase3.Enabled = True) And (TextCase3.Text = "") And (joueur = False) Then
                                TextCase3.Text = "O"
                                TextCase3.Enabled = False
                                case3(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase6.Enabled = True) And (TextCase6.Text = "") And (joueur = False) Then
                                TextCase6.Text = "O"
                                TextCase6.Enabled = False
                                case6(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase9.Enabled = True) And (TextCase9.Text = "") And (joueur = False) Then
                                TextCase9.Text = "O"
                                TextCase9.Enabled = False
                                case9(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(4) = "6") And (joueur = False) Then
                            If (TextCase2.Enabled = True) And (TextCase2.Text = "") And (joueur = False) Then
                                TextCase2.Text = "O"
                                TextCase2.Enabled = False
                                case2(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                            End If
                            If (TextCase8.Enabled = True) And (TextCase8.Text = "") And (joueur = False) Then
                                TextCase8.Text = "O"
                                TextCase8.Enabled = False
                                case8(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                            End If
                        End If
                        If (tab(5) = "6") And (joueur = False) Then
                            If (TextCase1.Enabled = True) And (TextCase1.Text = "") And (joueur = False) Then
                                TextCase1.Text = "O"
                                TextCase1.Enabled = False
                                case1(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase4.Enabled = True) And (TextCase4.Text = "") And (joueur = False) Then
                                TextCase4.Text = "O"
                                TextCase4.Enabled = False
                                case4(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase7.Enabled = True) And (TextCase7.Text = "") And (joueur = False) Then
                                TextCase7.Text = "O"
                                TextCase7.Enabled = False
                                case7(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(6) = "6") And (joueur = False) Then
                            If (TextCase3.Enabled = True) And (TextCase3.Text = "") And (joueur = False) Then
                                TextCase3.Text = "O"
                                TextCase3.Enabled = False
                                case3(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase7.Enabled = True) And (TextCase7.Text = "") And (joueur = False) Then
                                TextCase7.Text = "O"
                                TextCase7.Enabled = False
                                case7(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(7) = "6") And (joueur = False) Then
                            If (TextCase1.Enabled = True) And (TextCase1.Text = "") And (joueur = False) Then
                                TextCase1.Text = "O"
                                TextCase1.Enabled = False
                                case1(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase9.Enabled = True) And (TextCase9.Text = "") And (joueur = False) Then
                                TextCase9.Text = "O"
                                TextCase9.Enabled = False
                                case9(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                    End If
                    i += 1
                End If
                If (i = 8) And (r < 8) Then
                    If (tab(r) = 10) And (r < 8) And (joueur = False) Then
                        If (tab(0) = "10") And (joueur = False) Then
                            If (TextCase1.Enabled = True) And (TextCase1.Text = "") And (joueur = False) Then
                                TextCase1.Text = "O"
                                TextCase1.Enabled = False
                                case1(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase2.Enabled = True) And (TextCase2.Text = "") And (joueur = False) Then
                                TextCase2.Text = "O"
                                TextCase2.Enabled = False
                                case2(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase3.Enabled = True) And (TextCase3.Text = "") And (joueur = False) Then
                                TextCase3.Text = "O"
                                TextCase3.Enabled = False
                                case3(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(1) = "10") And (joueur = False) Then
                            If (TextCase4.Enabled = True) And (TextCase4.Text = "") And (joueur = False) Then
                                TextCase4.Text = "O"
                                TextCase4.Enabled = False
                                case4(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase6.Enabled = True) And (TextCase6.Text = "") And (joueur = False) Then
                                TextCase6.Text = "O"
                                TextCase6.Enabled = False
                                case6(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(2) = "10") And (joueur = False) Then
                            If (TextCase7.Enabled = True) And (TextCase7.Text = "") And (joueur = False) Then
                                TextCase7.Text = "O"
                                TextCase7.Enabled = False
                                case7(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase8.Enabled = True) And (TextCase8.Text = "") And (joueur = False) Then
                                TextCase8.Text = "O"
                                TextCase8.Enabled = False
                                case8(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase9.Enabled = True) And (TextCase9.Text = "") And (joueur = False) Then
                                TextCase9.Text = "O"
                                TextCase9.Enabled = False
                                case9(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(3) = "10") And (joueur = False) Then
                            If (TextCase3.Enabled = True) And (TextCase3.Text = "") And (joueur = False) Then
                                TextCase3.Text = "O"
                                TextCase3.Enabled = False
                                case3(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase6.Enabled = True) And (TextCase6.Text = "") And (joueur = False) Then
                                TextCase6.Text = "O"
                                TextCase6.Enabled = False
                                case6(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase9.Enabled = True) And (TextCase9.Text = "") And (joueur = False) Then
                                TextCase9.Text = "O"
                                TextCase9.Enabled = False
                                case9(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(4) = "10") And (joueur = False) Then
                            If (TextCase2.Enabled = True) And (TextCase2.Text = "") And (joueur = False) Then
                                TextCase2.Text = "O"
                                TextCase2.Enabled = False
                                case2(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase8.Enabled = True) And (TextCase8.Text = "") And (joueur = False) Then
                                TextCase8.Text = "O"
                                TextCase8.Enabled = False
                                case8(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(5) = "10") And (joueur = False) Then
                            If (TextCase1.Enabled = True) And (TextCase1.Text = "") And (joueur = False) Then
                                TextCase1.Text = "O"
                                TextCase1.Enabled = False
                                case1(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase4.Enabled = True) And (TextCase4.Text = "") And (joueur = False) Then
                                TextCase4.Text = "O"
                                TextCase4.Enabled = False
                                case4(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase7.Enabled = True) And (TextCase7.Text = "") And (joueur = False) Then
                                TextCase7.Text = "O"
                                TextCase7.Enabled = False
                                case7(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(6) = "10") And (joueur = False) Then
                            If (TextCase3.Enabled = True) And (TextCase3.Text = "") And (joueur = False) Then
                                TextCase3.Text = "O"
                                TextCase3.Enabled = False
                                case3(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase7.Enabled = True) And (TextCase7.Text = "") And (joueur = False) Then
                                TextCase7.Text = "O"
                                TextCase7.Enabled = False
                                case7(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                        If (tab(7) = "10") And (joueur = False) Then
                            If (TextCase1.Enabled = True) And (TextCase1.Text = "") And (joueur = False) Then
                                TextCase1.Text = "O"
                                TextCase1.Enabled = False
                                case1(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase5.Enabled = True) And (TextCase5.Text = "") And (joueur = False) Then
                                TextCase5.Text = "O"
                                TextCase5.Enabled = False
                                case5(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                            If (TextCase9.Enabled = True) And (TextCase9.Text = "") And (joueur = False) Then
                                TextCase9.Text = "O"
                                TextCase9.Enabled = False
                                case9(False)
                                joueur = Not joueur
                                Tableau()
                                clear()
                                nombre_coup += 1
                            End If
                        End If
                    End If
                    r += 1
                ElseIf (i = 8) And (r = 8) And (victoire = False) And (égalité = False) Then
                    random()
                End If
            End While
            clear()
        End If
        If (victoire = False) And (égalité = False) Then
            egalite()
        End If
    End Sub
    '============================================================== AI =============================================================='






    '============================================================== EFFET =============================================================='
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        cmdBack.Visible = False
        GIFbaby.Visible = False
        GIFartifice.Visible = False
        GIFconfetti.Visible = False
        GIFlicorne.Visible = False
        GIFlicorne1.Visible = False
        GIFlicorne2.Visible = False
        GIFlicorne3.Visible = False
        GIFlicorne4.Visible = False
        cmdQuit.Visible = True
        cmdAgain.Visible = True
        TextCase1.Visible = True
        TextCase2.Visible = True
        TextCase3.Visible = True
        TextCase4.Visible = True
        TextCase5.Visible = True
        TextCase6.Visible = True
        TextCase7.Visible = True
        TextCase8.Visible = True
        TextCase9.Visible = True
        TextJoueurO.Visible = True
        TextJoueurX.Visible = True
        LabelJoueurO.Visible = True
        LabelJoueurX.Visible = True
        cmdQuit.Visible = True
        cmdRestart.Visible = True
        Background.Visible = True
        cmdOption.Visible = True
    End Sub
    Private Sub cmdContinue_Click(sender As Object, e As EventArgs) Handles cmdContinue.Click
        GIFfootball.Visible = False
        GIFducoup.Visible = False
        GIFducoup2.Visible = False
        GIFapple.Visible = False
        GIFgameover.Visible = False
        cmdContinue.Visible = False
        cmdtroll.Visible = False
        cmdQuit.Visible = True
        cmdAgain.Visible = True
        TextCase1.Visible = True
        TextCase2.Visible = True
        TextCase3.Visible = True
        TextCase4.Visible = True
        TextCase5.Visible = True
        TextCase6.Visible = True
        TextCase7.Visible = True
        TextCase8.Visible = True
        TextCase9.Visible = True
        TextJoueurO.Visible = True
        TextJoueurX.Visible = True
        LabelJoueurO.Visible = True
        LabelJoueurX.Visible = True
        cmdQuit.Visible = True
        cmdRestart.Visible = True
        Background.Visible = True
        cmdOption.Visible = True
    End Sub
    Private Sub effect()
        clear_basic()
        cmdBack.Visible = True
        GIFbaby.Visible = True
        GIFartifice.Visible = True
        GIFconfetti.Visible = True
        GIFlicorne.Visible = True
        GIFlicorne1.Visible = True
        GIFlicorne2.Visible = True
        GIFlicorne3.Visible = True
        GIFlicorne4.Visible = True
    End Sub
    Private Sub effect1()
        clear_basic()
        GIFfootball.Visible = True
        GIFducoup.Visible = True
        GIFducoup2.Visible = True
        GIFapple.Visible = True
        GIFgameover.Visible = True
        cmdContinue.Visible = True
        cmdtroll.Visible = True
    End Sub
    Private Sub clear_basic()
        cmdQuit.Visible = False
        cmdAgain.Visible = False
        TextCase1.Visible = False
        TextCase2.Visible = False
        TextCase3.Visible = False
        TextCase4.Visible = False
        TextCase5.Visible = False
        TextCase6.Visible = False
        TextCase7.Visible = False
        TextCase8.Visible = False
        TextCase9.Visible = False
        TextJoueurO.Visible = False
        TextJoueurX.Visible = False
        LabelJoueurO.Visible = False
        LabelJoueurX.Visible = False
        cmdQuit.Visible = False
        cmdRestart.Visible = False
        Background.Visible = False
        cmdOption.Visible = False
    End Sub
    Private Sub show_basic()
        cmdQuit.Visible = True
        cmdAgain.Visible = True
        TextCase1.Visible = True
        TextCase2.Visible = True
        TextCase3.Visible = True
        TextCase4.Visible = True
        TextCase5.Visible = True
        TextCase6.Visible = True
        TextCase7.Visible = True
        TextCase8.Visible = True
        TextCase9.Visible = True
        TextJoueurO.Visible = True
        TextJoueurX.Visible = True
        LabelJoueurO.Visible = True
        LabelJoueurX.Visible = True
        cmdQuit.Visible = True
        cmdRestart.Visible = True
        Background.Visible = True
        cmdOption.Visible = True
    End Sub
    '============================================================== EFFET =============================================================='






    '============================================================== OPTION =============================================================='
    Private Sub cmdOption_Click(sender As Object, e As EventArgs) Handles cmdOption.Click
        clear_basic()
        show_settings()

    End Sub
    Private Sub show_settings()
        cmdBackOption.Visible = True
        Checkeffectvictoire.Visible = True
        Checkeffectdefaite.Visible = True
        cmdScoreReset.Visible = True
    End Sub
    Private Sub cmdBackOption_Click(sender As Object, e As EventArgs) Handles cmdBackOption.Click
        show_basic()
        cmdBackOption.Visible = False
        Checkeffectvictoire.Visible = False
        Checkeffectdefaite.Visible = False
        cmdScoreReset.Visible = False
    End Sub
    '============================================================== OPTION =============================================================='


End Class