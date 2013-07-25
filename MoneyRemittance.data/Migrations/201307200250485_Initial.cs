namespace MoneyRemittance.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "DateRegistered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateRegistered", c => c.DateTime(nullable: false));
        }
    }
}
