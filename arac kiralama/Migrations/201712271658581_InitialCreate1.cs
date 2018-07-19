namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.kullanicis", "TC", c => c.String());
            AddColumn("dbo.musterilers", "TC", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.musterilers", "TC");
            DropColumn("dbo.kullanicis", "TC");
        }
    }
}
