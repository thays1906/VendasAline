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
                        .ClienteID = c.Int(nullable := False, identity := True),
                        .Nome = c.String(maxLength := 100)
                    }) _
                .PrimaryKey(Function(t) t.ClienteID)
            
            CreateTable(
                "dbo.Produto",
                Function(c) New With
                    {
                        .ProdutoID = c.Int(nullable := False, identity := True),
                        .Nome = c.String(),
                        .Quantidade = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Valor = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Custo = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .EstoqueMin = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Cor = c.String()
                    }) _
                .PrimaryKey(Function(t) t.ProdutoID)
            
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
