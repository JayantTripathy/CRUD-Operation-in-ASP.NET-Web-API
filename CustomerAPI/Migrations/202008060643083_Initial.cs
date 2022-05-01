namespace CustomerAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CustId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customer");
        }
    }
}
