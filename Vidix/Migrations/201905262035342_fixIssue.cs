namespace Vidix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixIssue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Byte(nullable: false));
        }
    }
}
