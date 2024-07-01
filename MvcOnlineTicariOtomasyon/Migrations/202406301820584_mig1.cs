namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "UrunAd", c => c.String(maxLength: 70, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "UrunAd", c => c.String(maxLength: 30, unicode: false));
        }
    }
}
