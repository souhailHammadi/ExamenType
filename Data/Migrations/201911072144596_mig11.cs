namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evenements",
                c => new
                    {
                        evenementId = c.Int(nullable: false, identity: true),
                        entrepriseId = c.Int(),
                        titre = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.evenementId)
                .ForeignKey("dbo.Entreprises", t => t.entrepriseId)
                .Index(t => t.entrepriseId);
            
            AddColumn("dbo.Entreprises", "nbEmployes", c => c.Int(nullable: false));
            DropColumn("dbo.Entreprises", "adminEntId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entreprises", "adminEntId", c => c.Int());
            DropForeignKey("dbo.Evenements", "entrepriseId", "dbo.Entreprises");
            DropIndex("dbo.Evenements", new[] { "entrepriseId" });
            DropColumn("dbo.Entreprises", "nbEmployes");
            DropTable("dbo.Evenements");
        }
    }
}
