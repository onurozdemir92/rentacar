namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kiraveritabani1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.kiras", "araclar_id", c => c.Int());
            AddColumn("dbo.kiras", "musteriler_id", c => c.Int());
            CreateIndex("dbo.kiras", "araclar_id");
            CreateIndex("dbo.kiras", "musteriler_id");
            AddForeignKey("dbo.kiras", "araclar_id", "dbo.araclars", "id");
            AddForeignKey("dbo.kiras", "musteriler_id", "dbo.musterilers", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.kiras", "musteriler_id", "dbo.musterilers");
            DropForeignKey("dbo.kiras", "araclar_id", "dbo.araclars");
            DropIndex("dbo.kiras", new[] { "musteriler_id" });
            DropIndex("dbo.kiras", new[] { "araclar_id" });
            DropColumn("dbo.kiras", "musteriler_id");
            DropColumn("dbo.kiras", "araclar_id");
        }
    }
}
