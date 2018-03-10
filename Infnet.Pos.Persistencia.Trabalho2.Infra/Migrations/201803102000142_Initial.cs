namespace Infnet.Pos.Persistencia.Trabalho2.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        Genre_GenreId = c.Int(),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Genre_GenreId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Albums", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Albums", "Genre_GenreId", "dbo.Genres");
            DropIndex("dbo.Orders", new[] { "User_UserId" });
            DropIndex("dbo.Albums", new[] { "Order_OrderId" });
            DropIndex("dbo.Albums", new[] { "Genre_GenreId" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Genres");
            DropTable("dbo.Albums");
        }
    }
}
