namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kiraveritabani2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.kiras", "kullanicilar_id", c => c.Int());
            AddColumn("dbo.kullanicis", "kullanici_id", c => c.Int());
            CreateIndex("dbo.kiras", "kullanicilar_id");
            CreateIndex("dbo.kullanicis", "kullanici_id");
            AddForeignKey("dbo.kullanicis", "kullanici_id", "dbo.kullanicis", "id");
            AddForeignKey("dbo.kiras", "kullanicilar_id", "dbo.kullanicis", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.kiras", "kullanicilar_id", "dbo.kullanicis");
            DropForeignKey("dbo.kullanicis", "kullanici_id", "dbo.kullanicis");
            DropIndex("dbo.kullanicis", new[] { "kullanici_id" });
            DropIndex("dbo.kiras", new[] { "kullanicilar_id" });
            DropColumn("dbo.kullanicis", "kullanici_id");
            DropColumn("dbo.kiras", "kullanicilar_id");
        }
    }
}
