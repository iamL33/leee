Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Form1
    Dim user, password, fnames, lnames, pnums, userss, passs, repasss As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        register.Hide()
        change.Hide()
        recover.Hide()

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        'login clear
        users.Clear()
        pass.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'register clear

        fname.Clear()
        lname.Clear()
        pnum.Clear()
        user2.Clear()
        pass2.Clear()
        repass2.Clear()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'change account clear

        fname2.Clear()
        lname2.Clear()
        pnum2.Clear()
        user3.Clear()
        pass3.Clear()
        repass2.Clear()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        fname3.Clear()
        lname3.Clear()
        pnum3.Clear()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

        register.Show()
        login.Hide()

    End Sub



    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

        change.Show()
        login.Hide()
    End Sub



    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        recover.Show()
        login.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        register.Hide()
        login.Show()

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        change.Hide()
        login.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        change.Hide()
        login.Show()
    End Sub

    Private Sub pass2_TextChanged(sender As Object, e As EventArgs) Handles pass2.TextChanged

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        fname.Text = fnames
        lname.Text = lnames
        pnum.Text = pnums
        user2.Text = userss
        pass.Text = passs
        repass.Text = repasss

        If fnames = "" And lnames = "" And pnums = "" And userss = "" And passs = "" Then

            MsgBox("YOU NEED TO FILL UP ALL INFORMATION")

        ElseIf fnames = "" And lnames = "" And pnums = "" Then

            MsgBox("YOU NEED TO FILL UP FIRST NAME, LASTNAME AND PHONE NUMBER")

        ElseIf fnames = "" And lnames = "" Then

            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND LASTNAME")


        ElseIf fnames = "" And pnums = "" Then
            MsgBox("PLEASE ENTER YOUTR FIRSTNAME AND PHONE NUMBER")

        ElseIf lnames = "" And pnums = "" And userss = "" And passs = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATIN BELOW")

        ElseIf pnums = "" And userss = "" And passs = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION BELOW")



        ElseIf fnames = "" Then
            MsgBox("PLEASE ENTER YOUR FIRST NAME")

        ElseIf lnames = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME")

        ElseIf pnums = "" Then
            MsgBox("PLEASE ENTER YOUR CELLPHONE NUMBER")




        ElseIf userss = "" And passs = "" And repasss = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME,PASSWORD AND RE ENTERYOUR PASSWORD")

        ElseIf userss = "" And passs = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")

        ElseIf passs = "" And repasss = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD AND RE ENTERYOUR PASSWORD")

        ElseIf userss = "" And repasss = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND RE ENTER YOUR PASSWORD")




        ElseIf userss = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")

        ElseIf passs = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD")

        ElseIf repasss = "" Then
            MsgBox("PLEASE ENTER YOUR RE ENTER PASSWORD")




        ElseIf repasss = passs Then
            MsgBox("REGISTER SUCCESSFULL")

        Else
            MsgBox("PASSWORD IS NOT MATCH")
        End If






    End Sub










































    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        users.Text = user
        pass.Text = password


        If user = "" And password = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")


        ElseIf user = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")

        ElseIf password = "" Then
            MsgBox("ENTER YOUR PASSWORD")

        ElseIf user = "" And password = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")



        ElseIf user = userss And password = passs Then
            MsgBox("LOGIN SUCCESFULL")


        Else
            MsgBox("WRONG USERNAME AND PASSWORD")

        End If

    End Sub


End Class
