Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Cliente

    <Key()>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property cCliente As Integer

    <Column()>
    <MaxLength(100, ErrorMessage:="Informar o Nome")>
    Public Property rNome As String








End Class
