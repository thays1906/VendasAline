Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Produto

    <Key()>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property cProduto As Integer

    Public Property rNome As String
    Public Property cQuantidade As Decimal
    Public Property cValor As Decimal
    Public Property cCusto As Decimal
    Public Property cEstoqueMin As Decimal?
    Public Property rCor As String

End Class
