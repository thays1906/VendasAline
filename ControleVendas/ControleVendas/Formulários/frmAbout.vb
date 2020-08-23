Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CorButton(btnFechar, Collor.Gelo, Color.White, Color.White, Color.WhiteSmoke)

        txtLei.Text = "Aviso: Este programa de computador é protegido por leis de direitos autorais e tratados internacionais." & vbNewLine &
                      "A reprodução ou distribuição não-autorizada " &
                      "deste programa, ou qualquer parte dele, " &
                      "poderá resultar em severas punições civis e criminais, " &
                      "e os infratores serão punidos dentro do máximo rigor permitido por lei."

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub



End Class