Public Class Form1

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Label2.Text + 1

    End Sub

    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        If Label2.Text = 10 Then
            ProgressBar1.Value = 10
        End If
        If Label2.Text = 20 Then
            ProgressBar1.Value = 20
        End If
        If Label2.Text = 30 Then
            ProgressBar1.Value = 30
        End If
        If Label2.Text = 40 Then
            ProgressBar1.Value = 40
        End If
        If Label2.Text = 50 Then
            ProgressBar1.Value = 50
        End If
        If Label2.Text = 60 Then
            ProgressBar1.Value = 60
        End If
        If Label2.Text = 70 Then
            ProgressBar1.Value = 70
        End If
        If Label2.Text = 80 Then
            ProgressBar1.Value = 80
        End If
        If Label2.Text = 90 Then
            ProgressBar1.Value = 90
        End If
        If Label2.Text = 100 Then
            ProgressBar1.Value = 100
            form2.show()
            Me.Hide()
        End If

    End Sub

   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell("C:\Program Files\Native Instruments\Traktor 2\Traktor.exe")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
