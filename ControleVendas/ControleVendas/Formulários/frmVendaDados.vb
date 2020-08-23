Imports GFT.Util
Public Class frmVendaDados
    Private Sub frmVendaDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaAzulado)
        Cor(CType(pnlTopo, Control), Collor.Rosa)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class