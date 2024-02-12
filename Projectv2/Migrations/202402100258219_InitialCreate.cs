namespace Projectv2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AmountOfBooks = c.Int(nullable: false),
                        TotalReaders = c.String(),
                        Grade = c.Int(),
                        Book_ID = c.Int(),
                        Genre_GenreID = c.Int(),
                    })
                .PrimaryKey(t => t.AuthorID)
                .ForeignKey("dbo.Book", t => t.Book_ID)
                .ForeignKey("dbo.Genre", t => t.Genre_GenreID)
                .Index(t => t.Book_ID)
                .Index(t => t.Genre_GenreID);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        OriginalLanguage = c.String(),
                        Writer = c.String(),
                        PublishingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreID = c.Int(nullable: false),
                        Name = c.String(),
                        MostPopularBook = c.String(),
                        MonthReaders = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Author", "Genre_GenreID", "dbo.Genre");
            DropForeignKey("dbo.Author", "Book_ID", "dbo.Book");
            DropIndex("dbo.Author", new[] { "Genre_GenreID" });
            DropIndex("dbo.Author", new[] { "Book_ID" });
            DropTable("dbo.Genre");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
