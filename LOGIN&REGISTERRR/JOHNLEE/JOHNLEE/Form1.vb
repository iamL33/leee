Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim user, nuser, npass, pass, fname, lname, pno, re As String
    Dim refname, relname, repno

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Cancel4.Click
        Firstname3.Clear()
        Lastname3.Clear()
        Contact3.Clear()
        Username3.Clear()
        NewPass.Clear()
        ReEnterpass2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles RegisterA.Click
        register.Show()
        login.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles RecoverA.Click
        recovery.Show()
        login.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ChangeA.Click
        change.Show()
        login.Hide()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Login2.Click
        recovery.Hide()
        login.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Login3.Click
        register.Hide()
        login.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Login4.Click
        change.Hide()
        login.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recovery.Hide()
        register.Hide()
        change.Hide()
    End Sub

    Private Sub login_Enter(sender As Object, e As EventArgs) Handles login.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username1.TextChanged

    End Sub

    Private Sub Firstname3_TextChanged(sender As Object, e As EventArgs) Handles Firstname3.TextChanged

    End Sub

    Private Sub Lastname3_TextChanged(sender As Object, e As EventArgs) Handles Lastname3.TextChanged

    End Sub

    Private Sub NewUser_TextChanged(sender As Object, e As EventArgs) Handles NewUser.TextChanged

    End Sub

    Private Sub Password3_TextChanged(sender As Object, e As EventArgs) Handles NewPass.TextChanged

    End Sub

    Private Sub NewPass_TextChanged(sender As Object, e As EventArgs) Handles Password3.TextChanged

    End Sub

    Private Sub change_Enter(sender As Object, e As EventArgs) Handles change.Enter

    End Sub

    Private Sub recovery_Enter(sender As Object, e As EventArgs) Handles recovery.Enter

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Update.Click
        fname = Firstname3.Text
        lname = Lastname3.Text
        pno = Contact3.Text
        user = Username3.Text
        pass = Password3.Text
        nuser = NewUser.Text
        npass = NewPass.Text
        re = ReEnterpass2.Text



        If fname = "" And lname = "" And pno = "" And user = "" And pass = "" And re = "" And nuser = "" And npass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION")
        ElseIf user = "" And pass = "" And re = "" Then
            MsgBox("PLEASE FILL UP ALL INFROMATION NEEDED")
        ElseIf fname = "" And lname = "" And pno = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION NEEDED")
        ElseIf fname = "" And lname = "" And pno = "" And user = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION NEEDED")
        ElseIf fname = "" And lname = "" And pno = "" And user = "" And pass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION NEEDED")

        ElseIf fname = "" And lname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PASSWORD")
        ElseIf fname = "" And pno = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PHONE NUMBER")
        ElseIf fname = "" And user = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND USERNAME")
        ElseIf fname = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PASSWORD")
        ElseIf fname = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND RE-ENTERED PASSWORD")

        ElseIf lname = "" And pno = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND PHONE NUMBER")
        ElseIf lname = "" And user = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND USERNAME")
        ElseIf lname = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND PASSWORD")
        ElseIf lname = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND RE-ENTERED PASSWORD")


        ElseIf pno = "" And user = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER AND USERNAME")
        ElseIf pno = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER AND PASSWORD")

        ElseIf nuser = "" And npass = "" Then
            MsgBox("PLEASE ENTER YOUR NEW USERNAME AND NEW PASSWORD")

        ElseIf pno = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER AND RE-ENTERED PASSWORD")


        ElseIf user = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")
        ElseIf user = "" And re = "" Then
            MsgBox("PLEASE ENTER USERNAME AND RE-ENTERED PASSWORD")
        ElseIf pass = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD AND RE-ENTERED PASSWORD")






        ElseIf fname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME")
        ElseIf lname = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME")
        ElseIf pno = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER")
        ElseIf user = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")
        ElseIf pass = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD")

        ElseIf nuser = "" Then
            MsgBox("PLEASE ENTER YOUR NEW USERNAME!")
        ElseIf npass = "" Then
            MsgBox("PLEASE ENTER YOUR NEW PASSWORD!")

        ElseIf re = "" Then
            MsgBox("PLEASE ENTER YOUR RE-ENTERED PASSWORD")


        ElseIf re = pass Then
            MsgBox("CHANGED SUCCESSFULLY")


        Else
            MsgBox("YOUR PASSWORD IS NOT MATCH")

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Cancel2.Click
        Firstname1.Clear()
        Lastname1.Clear()
        Contact1.Clear()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Recover.Click
        refname = Firstname1.Text
        relname = Lastname1.Text
        repno = Contact1.Text

        If refname = "" And relname = "" And repno = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION")
        ElseIf refname = "" And relname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND LASTNAME")
        ElseIf relname = "" And repno = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND PHONE NUMBER")
        ElseIf refname = "" And repno = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PHONE NUMBER")

        ElseIf refname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME")
        ElseIf relname = "" Then
            MsgBox("PLEASE ENTER YOU LASTNAME")
        ElseIf repno = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER")

        ElseIf refname = fname And relname = lname And repno = pno Then
            MsgBox("YOUR ACCOUNT HAS BEEN RECOVERED")

        Else
            MsgBox("NOT MATCH")

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Cancel3.Click
        Firstname2.Clear()
        Lastname2.Clear()
        Contact2.Clear()
        Username2.Clear()
        Password2.Clear()
        ReEnterpass1.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Registerr.Click
        fname = Firstname2.Text
        lname = Lastname2.Text
        pno = Contact2.Text
        user = Username2.Text
        pass = Password2.Text
        re = ReEnterpass1.Text

        If fname = "" And lname = "" And pno = "" And user = "" And pass = "" And re = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION")
        ElseIf user = "" And pass = "" And re = "" Then
            MsgBox("PLEASE FILL UP ALL INFROMATION NEEDED")
        ElseIf fname = "" And lname = "" And pno = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION NEEDED")
        ElseIf fname = "" And lname = "" And pno = "" And user = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION NEEDED")
        ElseIf fname = "" And lname = "" And pno = "" And user = "" And pass = "" Then
            MsgBox("PLEASE FILL UP ALL INFORMATION NEEDED")

        ElseIf fname = "" And lname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PASSWORD")
        ElseIf fname = "" And pno = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PHONE NUMBER")
        ElseIf fname = "" And user = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND USERNAME")
        ElseIf fname = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND PASSWORD")
        ElseIf fname = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME AND RE-ENTERED PASSWORD")

        ElseIf lname = "" And pno = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND PHONE NUMBER")
        ElseIf lname = "" And user = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND USERNAME")
        ElseIf lname = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND PASSWORD")
        ElseIf lname = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME AND RE-ENTERED PASSWORD")


        ElseIf pno = "" And user = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER AND USERNAME")
        ElseIf pno = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER AND PASSWORD")
        ElseIf pno = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER AND RE-ENTERED PASSWORD")


        ElseIf user = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")
        ElseIf user = "" And re = "" Then
            MsgBox("PLEASE ENTER USERNAME AND RE-ENTERED PASSWORD")

        ElseIf pass = "" And re = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD AND RE-ENTERED PASSWORD")




        ElseIf fname = "" Then
            MsgBox("PLEASE ENTER YOUR FIRSTNAME")
        ElseIf lname = "" Then
            MsgBox("PLEASE ENTER YOUR LASTNAME")
        ElseIf pno = "" Then
            MsgBox("PLEASE ENTER YOUR PHONE NUMBER")
        ElseIf user = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")
        ElseIf pass = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD")
        ElseIf re = "" Then
            MsgBox("PLEASE ENTER YOUR RE-ENTERED PASSWORD")


        ElseIf re = pass Then
            MsgBox("REGISTER SUCCESSFULLY")


        Else
            MsgBox("YOUR PASSWORD IS NOT MATCH")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel1.Click
        Username1.Clear()
        Password1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login1.Click

        user = Username1.Text
        pass = Password1.Text

        If user = "" And pass = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD")
        ElseIf user = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME")
        ElseIf pass = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD")
        ElseIf user = user And re = pass Then
            MsgBox("LOGIN SUCCESSFUL")
        ElseIf fname = "" And lname = "" And pno = "" Then
            MsgBox("UNDEFINED ACCOUNT")
        Else
            MsgBox("WRONG USERNAME AND PASSWORD")
        End If
    End Sub
End Class
