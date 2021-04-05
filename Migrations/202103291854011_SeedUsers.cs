namespace Vydly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'11a4739e-ecc8-46b0-a9b1-7d663a6268dd', N'kevin@miel.com', 0, N'ABDyVMlmhQhm0L/o2k0kvuGTmmPEbmLpHGSMywzMzy5YmrO9bYl3IqvNG86kG5Yhwg==', N'48a5b1f6-1cd3-48bf-8b93-d321fed6ab95', NULL, 0, 0, NULL, 1, 0, N'kevin@miel.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'79dbf318-c381-4840-bb52-f3ebdf9c54e3', N'admin@miel.com', 0, N'AMB1jICBWFAXWWqo+J2y62ar2ur/kJEJaQTCQewhOZokp+P1scjP596Pygn1Tj/9uw==', N'638e9c3b-e028-4696-9375-1bd1199b8ddd', NULL, 0, 0, NULL, 1, 0, N'admin@miel.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd6287f6a-edb8-45cb-a593-3477f610f18a', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'79dbf318-c381-4840-bb52-f3ebdf9c54e3', N'd6287f6a-edb8-45cb-a593-3477f610f18a')

");
        }
        
        public override void Down()
        {
        }
    }
}
