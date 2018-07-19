namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kiraveritabani : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.models", "marka_id1", c => c.Int());
            CreateIndex("dbo.models", "marka_id1");
            AddForeignKey("dbo.models", "marka_id1", "dbo.markas", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.models", "marka_id1", "dbo.markas");
            DropIndex("dbo.models", new[] { "marka_id1" });
            DropColumn("dbo.models", "marka_id1");
        }
    }
}
