Imports System.Data.Entity.Infrastructure

Public Class ProdutoController

    Private ReadOnly BancoContext As BancoContext

    Sub New()
        BancoContext = New BancoContext()
    End Sub

    Public Function Pesquisar(ByVal nome As String, ByVal cor As String) As List(Of Produto)

        Return BancoContext.Produtos.Where(Function(c) (nome = "" Or c.rNome.Contains(nome)) And (cor = "" Or c.rCor.Contains(cor))).ToList()


    End Function
    Public Function Incluir(ByVal produto As Produto) As Boolean

        BancoContext.Produtos.Add(produto)
        BancoContext.SaveChanges()
        Return True

    End Function

    Public Function Delete(ByVal ProdutoID As Integer) As Boolean

        Dim produto = BancoContext.Produtos.Find(ProdutoID)
        BancoContext.Entry(produto).State = Entity.EntityState.Deleted
        BancoContext.SaveChanges()
        Return True

    End Function

    Public Function Alterar(ByVal ProdutoID As Integer, ByVal produto As Produto) As Boolean

        Dim produtoBanco = BancoContext.Produtos.Find(ProdutoID)

        '.State = entity.EntityState.Modified
        produto.cProduto = produtoBanco.cProduto
        Dim entity As DbEntityEntry(Of Produto) = BancoContext.Entry(produtoBanco)
        entity.CurrentValues.SetValues(produto)
        'produtoBanco.ProdutoID = ProdutoID
        BancoContext.SaveChanges()
        Return True

    End Function
End Class
