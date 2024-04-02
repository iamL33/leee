Imports System.Net.Security
Imports System.Reflection.Emit
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim user, pass, ret, fname, lname, pno, user2, pass2 As String
    Dim recfname, reclname, recpno As String

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

        'pag pinindot yong register button magshoshow ang register and mag hihide ang log in
        register.Show()
        login.Hide()


    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        'pag pinindot yong  recover button magshoshow ang  recover and mag hihide ang log in
        recover.Show()
        login.Hide()

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        'pag pinindot yong   change acc button magshoshow ang  change acc and mag hihide ang log in
        change.Show()
        login.Hide()


    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        'pag pinindot yong   login  button magshoshow ang  login and mag hihide ang register


        login.Show()
        register.Hide()

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        'pag pinindot yong   login  button magshoshow ang  login and mag hihide ang change
        change.Hide()
        login.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        'register box list
        fname = Textbox1.Text
        lname = TextBox2.Text
        pno = TextBox3.Text
        user = TextBox4.Text
        pass = TextBox5.Text
        ret = TextBox6.Text




        If fname = "" And lname = "" And pno = "" And user = "" And pass = "" Then

            MsgBox("YOU NEED TO FILL UP ALL INFORMATION")

        ElseIf fname = "" And lname = "" And pno = "" Then

            MsgBox("YOU NEED TO FILL UP FIRST NAME, LASTNAME AND PHONE NUMBER")

        ElseIf fname = "" And lname = "" Then

            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND LASTNAME")


        ElseIf fname = "" And pno = "" Then
            MsgBox("PLEASE ENTER YOUTR FIRSTNAME AND PHONE NUMBER")

        ElseIf lname = "" And pno = "" And user = "" And pass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATIN BELOW")

        ElseIf pno = "" And user = "" And pass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION BELOW")



        ElseIf fname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRST NAME")

        ElseIf lname = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME")

        ElseIf pno = "" Then
            MsgBox("PLEASE ENTER YOUR CELLPHONE NUMBER")




        ElseIf user = "" And pass = "" And ret = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME,PASSWORD AND RE ENTERYOUR PASSWORD")

        ElseIf user = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")

        ElseIf pass = "" And ret = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD AND RE ENTERYOUR PASSWORD")

        ElseIf user = "" And ret = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND RE ENTER YOUR PASSWORD")




        ElseIf user = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")

        ElseIf pass = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD")

        ElseIf ret = "" Then
            MsgBox("PLEASE ENTER YOUR RE ENTER PASSWORD")




        ElseIf ret = pass Then
            MsgBox("REGISTER SUCCESSFULL")

        Else
            MsgBox("PASSWORD IS NOT MATCH")
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        'pag pinindot yong   login  button magshoshow ang  login and mag hihide ang  recover
        recover.Hide()
        login.Show()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pagload ng form  lahat ng register, change, recover ay mahihide
        register.Hide()
        change.Hide()
        recover.Hide()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        'register button clear
        Textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'log in button clear
        TextBox8.Clear()
        TextBox9.Clear()

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)
        'Change account clear button 
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        TextBox7.Clear()
        TextBox10.Clear()
        TextBox11.Clear()




    End Sub

    'LOGIN FORM CODES.................................................................
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'log in box list
        user2 = TextBox8.Text
        pass2 = TextBox9.Text


        If user2 = "" And pass2 = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")

        ElseIf user2 = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")

        ElseIf pass2 = "" Then
            MsgBox("ENTER YOUR PASSWORD")

        ElseIf user = user2 And pass = pass2 Then
            MsgBox("LOGIN SUCCESSFUL")


        ElseIf fname = "" And lname = "" And pno = "" Then
            MsgBox("UNDEFINED  ACCOUNT")
        Else
            MsgBox("WRONG USERNAME AND PASSWORD")

        End If
    End Sub  'END OF CODES................................................................................................




    'CHANGE ACCOUNT FORM CODES..............................................................................
    Private Sub Button8_Click(sender As Object, e As EventArgs)


        'change acount listbox
        fname = txt1.Text
        lname = txt2.Text
        pno = txt3.Text
        user = txt4.Text
        pass = txt5.Text
        ret = txt6.Text



        If fname = "" And lname = "" And pno = "" And user = "" And pass = "" Then

            MsgBox("YOU NEED TO FILL UP ALL INFORMATION")

        ElseIf fname = "" And lname = "" And pno = "" Then

            MsgBox("YOU NEED TO FILL UP FIRST NAME, LASTNAME AND PHONE NUMBER")

        ElseIf fname = "" And lname = "" Then

            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND LASTNAME")


        ElseIf fname = "" And pno = "" Then
            MsgBox("PLEASE ENTER YOUTR FIRSTNAME AND PHONE NUMBER")

        ElseIf lname = "" And pno = "" And user = "" And pass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATIN BELOW")

        ElseIf pno = "" And user = "" And pass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION BELOW")



        ElseIf fname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRST NAME")

        ElseIf lname = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME")

        ElseIf pno = "" Then
            MsgBox("PLEASE ENTER YOUR CELLPHONE NUMBER")




        ElseIf user = "" And pass = "" And ret = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME,PASSWORD AND RE ENTERYOUR PASSWORD")

        ElseIf user = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")

        ElseIf pass = "" And ret = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD AND RE ENTERYOUR PASSWORD")

        ElseIf user = "" And ret = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND RE ENTER YOUR PASSWORD")




        ElseIf user = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")

        ElseIf pass = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD")

        ElseIf ret = "" Then
            MsgBox("PLEASE ENTER YOUR RE ENTER PASSWORD")






        ElseIf ret = pass Then
            MsgBox("REGISTER SUCCESSFULL")

        Else
            MsgBox("PASSWORD IS NOT MATCH")
        End If

        '"All information in the registration form is clear and you can now change your information."
        Textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub 'END OF CODES................................................................................................



    'RECOVER ACCOUNT CODES...........................................................................................
    Private Sub Button6_Click(sender As Object, e As EventArgs)

        'recover acount

        recfname = TextBox7.Text
        reclname = TextBox10.Text
        recpno = TextBox11.Text



        If recfname = "" And reclname = "" And recpno = "" Then

            MsgBox("PLEASE FILL UP ALL INFORMATION")

        ElseIf recfname = "" And reclname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND LASTNAME")

        ElseIf reclname = "" And recpno = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND PHONE NUMBER")

        ElseIf recfname = "" And recpno = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PHONE NUMBER")



        ElseIf recfname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME")

        ElseIf reclname = "" Then
            MsgBox("PLEASE ENTER YOU LASTNAME")

        ElseIf recpno = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER")


        ElseIf recfname = fname And reclname = lname And recpno = pno Then

            MsgBox("ACOUNT RECOVERED")

        Else
            MsgBox("NOT MATCH")

        End If




    End Sub 'END OF CODES................................................................................................


End Class
