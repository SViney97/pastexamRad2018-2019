namespace pastexamRAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8thmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Transactions", "AccountID", "dbo.Transactions");
            DropIndex("dbo.Account", new[] { "CustomerID" });
            DropIndex("dbo.Transactions", new[] { "AccountID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Transactions", "AccountID");
            CreateIndex("dbo.Account", "CustomerID");
            AddForeignKey("dbo.Transactions", "AccountID", "dbo.Transactions", "ID");
            AddForeignKey("dbo.Account", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
        }
    }
}
