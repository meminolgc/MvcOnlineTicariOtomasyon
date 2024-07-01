namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "Marka", c => c.String(maxLength: 70, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "Marka", c => c.String(maxLength: 30, unicode: false));
        }
    }
}
