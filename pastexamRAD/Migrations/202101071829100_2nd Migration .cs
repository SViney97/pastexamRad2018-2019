namespace pastexamRAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2ndMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "TransactionType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "TransactionType");
        }
    }
}
