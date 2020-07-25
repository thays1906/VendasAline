Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Public Class BancoContext
    Inherits DbContext

    Sub New()
        MyBase.New("BancoContext")


    End Sub



    Public Property Clientes() As DbSet(Of Cliente)
    Public Property Produtos() As DbSet(Of Produto)
    Public Property Vendas() As DbSet(Of Venda)


    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub


End Class
