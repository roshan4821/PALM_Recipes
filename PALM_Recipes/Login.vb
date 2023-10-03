Public Class Login
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Textpassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If Textuser.Text = "" Or Textpassword.Text = "" Then
            MsgBox("Please enter user and password")
            ' ElseIf txtuser.Text = "admin" And txtpassword.Text = "password" Then
            'Dim obj = New cmsfrm
            'obj.Show()
            'Me.Hide()
            ' Else
            'MsgBox("You have entered wrong user and password")
            'txtuser.Text = ""
            'txtpassword.Text = ""
            'txtuser.Focus()

        ElseIf users.checklogin(Textuser.Text, Textpassword.Text) = True Then
            Dim obj = New cmsfrm
            obj.Show()
            Me.Hide()
        Else
            MsgBox("You have entered wrong user and password")
            Textuser.Text = ""
            Textpassword.Text = ""
            Textuser.Focus()
        End If
    End Sub
End Class
