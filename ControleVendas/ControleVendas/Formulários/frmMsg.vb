Public Class frmMsg
    Public iTimer As Integer = 10
    Private Sub frmMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Temporizador()
        Try

            lblTempo.Text = "( " & iTimer.ToString & " )"
            lblTempo.Refresh()
            iTimer = iTimer - 1


            If iTimer = -2 Then
                Timer1.Stop()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Temporizador()

    End Sub
End Class