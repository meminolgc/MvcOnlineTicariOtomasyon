namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Uruns", "Kategori_KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "Kategori_KategoriID" });
            RenameColumn(table: "dbo.Uruns", name: "Kategori_KategoriID", newName: "KategoriiD");
            AlterColumn("dbo.Uruns", "KategoriiD", c => c.Int(nullable: false));
            CreateIndex("dbo.Uruns", "KategoriiD");
            AddForeignKey("dbo.Uruns", "KategoriiD", "dbo.Kategoris", "KategoriID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "KategoriiD", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "KategoriiD" });
            AlterColumn("dbo.Uruns", "KategoriiD", c => c.Int());
            RenameColumn(table: "dbo.Uruns", name: "KategoriiD", newName: "Kategori_KategoriID");
            CreateIndex("dbo.Uruns", "Kategori_KategoriID");
            AddForeignKey("dbo.Uruns", "Kategori_KategoriID", "dbo.Kategoris", "KategoriID");
        }
    }
}
