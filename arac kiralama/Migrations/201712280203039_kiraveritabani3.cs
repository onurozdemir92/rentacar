namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kiraveritabani3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.araclars", "marka_id1", c => c.Int());
            CreateIndex("dbo.araclars", "marka_id1");
            AddForeignKey("dbo.araclars", "marka_id1", "dbo.markas", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.araclars", "marka_id1", "dbo.markas");
            DropIndex("dbo.araclars", new[] { "marka_id1" });
            DropColumn("dbo.araclars", "marka_id1");
        }
    }
}
