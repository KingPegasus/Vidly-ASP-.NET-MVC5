namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(),
                        DateAdded = c.DateTime(nullable: false),
                        StockCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockCount) VALUES ('Avengers','05/11/2012','10/10/2021',5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockCount) VALUES ('Thor','05/20/2011','10/10/2021',8)");
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
