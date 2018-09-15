namespace FrankenApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pluralizacija : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jednina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jednina");
        }
    }
}
