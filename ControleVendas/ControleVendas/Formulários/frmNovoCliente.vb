Public Class frmNovoCliente
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbDadosCliente.Enter

    End Sub

    Private Sub frmNovoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
    End Sub
End Class