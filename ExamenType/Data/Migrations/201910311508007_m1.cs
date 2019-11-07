namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claim",
                c => new
                {
                    ClaimId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    DateClaim = c.DateTime(),
                })
                .PrimaryKey(t => t.ClaimId);

            CreateTable(
                "dbo.Payment",
                c => new
                {
                    PaymentId = c.Int(nullable: false, identity: true),
                    Amount = c.Double(),
                    DatePayment = c.DateTime(),
                })
                .PrimaryKey(t => t.PaymentId);

        }
        
        public override void Down()
        {
        }
    }
}
