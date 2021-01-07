namespace pastexamRAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3ndMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Accounts", newName: "Account");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Account", newName: "Accounts");
        }
    }
}
