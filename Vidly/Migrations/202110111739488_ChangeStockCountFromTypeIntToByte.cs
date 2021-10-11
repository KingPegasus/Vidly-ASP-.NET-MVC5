namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStockCountFromTypeIntToByte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "StockCount", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "StockCount", c => c.Int(nullable: false));
        }
    }
}
