namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLengthToRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "Length", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Length");
        }
    }
}
