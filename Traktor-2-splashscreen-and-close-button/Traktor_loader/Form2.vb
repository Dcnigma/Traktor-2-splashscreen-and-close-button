Public Class Form2
    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        Dim proc = Process.GetProcessesByName("Traktor")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
        Form1.Close()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim proc = Process.GetProcessesByName("Traktor")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class