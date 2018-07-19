namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.araclars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        arac_adi = c.String(),
                        marka_id = c.Int(nullable: false),
                        model_id = c.Int(nullable: false),
                        yil = c.String(),
                        koltuk = c.String(),
                        kapi = c.String(),
                        klima = c.String(),
                        yakit = c.String(),
                        vites = c.String(),
                        gun_fiyat = c.String(),
                        hasar = c.String(),
                        plaka = c.String(),
                        arackullanim = c.Int(nullable: false),
                        arackullanim1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.kiras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        arac_id = c.Int(nullable: false),
                        mus_id = c.Int(nullable: false),
                        kul_id = c.Int(nullable: false),
                        alis_tarih = c.DateTime(nullable: false),
                        alis_saat = c.String(),
                        teslim_tarih = c.DateTime(nullable: false),
                        teslim_saat = c.String(),
                        teslim_kontrol = c.Int(nullable: false),
                        odenecek_tutar = c.String(),
                        odeme_turu = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.kullanicis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        kullanici_adi = c.String(),
                        sifre = c.String(),
                        durum = c.String(),
                        isim = c.String(),
                        d_tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.markas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        markaadi = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.models",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        marka_id = c.Int(nullable: false),
                        modeladi = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.musterilers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tel = c.String(),
                        eh_no = c.String(),
                        eh_tarih = c.DateTime(nullable: false),
                        cinsiyet = c.String(),
                        adres = c.String(),
                        isim = c.String(),
                        d_tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.musterilers");
            DropTable("dbo.models");
            DropTable("dbo.markas");
            DropTable("dbo.kullanicis");
            DropTable("dbo.kiras");
            DropTable("dbo.araclars");
        }
    }
}
