namespace pastexamRAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4thmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Account");
            AddForeignKey("dbo.Account", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Customers");
            AddForeignKey("dbo.Account", "CustomerID", "dbo.Account", "ID");
        }
    }
}
