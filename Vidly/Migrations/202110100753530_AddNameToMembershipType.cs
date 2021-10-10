namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes SET  Name='Mem0' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET  Name='Mem10' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET  Name='Mem15' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET  Name='Mem20' WHERE Id = 4");
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
