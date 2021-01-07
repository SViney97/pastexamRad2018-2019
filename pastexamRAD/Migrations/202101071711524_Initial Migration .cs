namespace pastexamRAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountName = c.String(),
                        InceptionDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        CurrentBalance = c.Single(nullable: false),
                        AccountTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        Conditions = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Transactions", t => t.AccountID)
                .Index(t => t.AccountID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "AccountID", "dbo.Transactions");
            DropForeignKey("dbo.Accounts", "CustomerID", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "AccountID" });
            DropIndex("dbo.Accounts", new[] { "CustomerID" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Customers");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.Accounts");
        }
    }
}
