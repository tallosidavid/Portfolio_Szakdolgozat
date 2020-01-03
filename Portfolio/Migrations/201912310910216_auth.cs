namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auth : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'46a6e8e4-8b37-4af9-bdc0-3fc317176bd8', N'tallosi.david69@gmail.com', 0, N'AGH42phr85DlDdZ6ry/ujcyNgdB0oqv/b/Gwdyqa5KQYUMq0/YYiCiYXNotQkyR6Pw==', N'beff235d-0b35-402f-9ff5-8c63da9fa1ad', NULL, 0, 0, NULL, 1, 0, N'tallosi.david69@gmail.com')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bc2014e5-7eec-4e99-a060-7708341e106f', N'Admin')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'46a6e8e4-8b37-4af9-bdc0-3fc317176bd8', N'bc2014e5-7eec-4e99-a060-7708341e106f')");

        }

        public override void Down()
        {
        }
    }
}
