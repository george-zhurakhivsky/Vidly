namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c94f481b-7eb5-419d-97df-9c0812ef50ac', N'admin@vidly.com', 0, N'APTQdlpOz4g6MSsY9q3F2QCqs4IL4yMSHb9gcVEmLf/ZFBTLoF2HVhVXC62s/SbdLA==', N'9e43c8f4-922b-4960-a1b4-455c2edd9a7e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e54da886-a1ae-40f6-b5f1-b39771a4a490', N'guest@vidly.com', 0, N'AITcoOC5nApAxinmdiQgwd6Gduvf/FJkxJv9qqbkruU2tbPyl6inlih7grLJSyj3Zw==', N'b2db945e-cd9f-4989-bc34-bc5ff761a6ed', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'40fb4e09-e896-47f9-8a16-aab673b59fdd', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c94f481b-7eb5-419d-97df-9c0812ef50ac', N'40fb4e09-e896-47f9-8a16-aab673b59fdd')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
