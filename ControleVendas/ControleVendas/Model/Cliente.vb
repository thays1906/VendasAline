Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Cliente

    <Key()>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property ClienteID As Integer

    <Column()>
    <MaxLength(100, ErrorMessage:="Informar o Nome")>
    Public Property Nome As String








End Class
