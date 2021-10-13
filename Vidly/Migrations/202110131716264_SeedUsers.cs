namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a125a33-beee-41b0-b2e3-632b0a326c86', N'guest@vidly.com', 0, N'AKnZ+45h3Lr8v11lujVnHA2zMEg976f7nnkP6PDCMypZe8OU91sbRN+y6kd5Cs4tdg==', N'9a90eec6-6204-4a50-8df2-079ed8cea4a5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'70a22c51-ce00-4272-8b25-a76829eb00ba', N'admin@vidly.com', 0, N'ANnJ2ce6HeSWKXN7/BHfheTe0+s1XpAZR0nxyPRVFDHI2dcr9woR6CC4iecdxv+bbA==', N'34cba9eb-ba1f-41c4-9ad6-7d1ad4ab364d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c0504fb5-4ba5-4275-9a7d-a9b98a75edfb', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'70a22c51-ce00-4272-8b25-a76829eb00ba', N'c0504fb5-4ba5-4275-9a7d-a9b98a75edfb')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
