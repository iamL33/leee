Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim user, pass, fname, lname, pno, re As String
    Dim refname, relname, repno

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        register.Show()
        login.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        recovery.Show()
        login.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        change.Show()
        login.Hide()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        recovery.Hide()
        login.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        register.Hide()
        login.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        fname = TextBox9.Text
        lname = TextBox10.Text
        pno = TextBox11.Text
        user = TextBox12.Text
        pass = TextBox13.Text
        re = TextBox14.Text



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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        refname = TextBox15.Text
        relname = TextBox16.Text
        repno = TextBox17.Text

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        fname = TextBox3.Text
        lname = TextBox4.Text
        pno = TextBox5.Text
        user = TextBox6.Text
        pass = TextBox7.Text
        re = TextBox8.Text

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        user = TextBox1.Text
        pass = TextBox2.Text

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
