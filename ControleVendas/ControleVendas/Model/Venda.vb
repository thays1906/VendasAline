Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Venda
    <Key()>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property VendaID As Integer
End Class
