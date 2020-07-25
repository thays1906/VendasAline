﻿Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class ajusteestoque
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Produto", "EstoqueMin", Function(c) c.Decimal(precision := 18, scale := 2))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Produto", "EstoqueMin", Function(c) c.Decimal(nullable := False, precision := 18, scale := 2))
        End Sub
    End Class
End Namespace
