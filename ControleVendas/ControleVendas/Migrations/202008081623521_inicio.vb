Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class inicio
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Cliente",
                Function(c) New With
                    {
                        .cCliente = c.Int(nullable := False, identity := True),
                        .rNome = c.String(maxLength := 100)
                    }) _
                .PrimaryKey(Function(t) t.cCliente)
            
            CreateTable(
                "dbo.Produto",
                Function(c) New With
                    {
                        .cProduto = c.Int(nullable := False, identity := True),
                        .rNome = c.String(),
                        .cQuantidade = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .cValor = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .cCusto = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .cEstoqueMin = c.Decimal(precision := 18, scale := 2),
                        .rCor = c.String()
                    }) _
                .PrimaryKey(Function(t) t.cProduto)
            
            CreateTable(
                "dbo.Venda",
                Function(c) New With
                    {
                        .VendaID = c.Int(nullable := False, identity := True)
                    }) _
                .PrimaryKey(Function(t) t.VendaID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Venda")
            DropTable("dbo.Produto")
            DropTable("dbo.Cliente")
        End Sub
    End Class
End Namespace
