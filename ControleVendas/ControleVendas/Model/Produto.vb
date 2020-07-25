Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Produto

    <Key()>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property ProdutoID As Integer

    Public Property Nome As String
    Public Property Quantidade As Decimal
    Public Property Valor As Decimal
    Public Property Custo As Decimal
    Public Property EstoqueMin As Decimal?
    Public Property Cor As String

End Class
