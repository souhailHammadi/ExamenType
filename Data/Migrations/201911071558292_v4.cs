namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "QuestionID" });
            AlterColumn("dbo.Answers", "QuestionID", c => c.Int());
            AlterColumn("dbo.Questions", "Content", c => c.String());
            CreateIndex("dbo.Answers", "QuestionID");
            AddForeignKey("dbo.Answers", "QuestionID", "dbo.Questions", "QuestionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "QuestionID" });
            AlterColumn("dbo.Questions", "Content", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Answers", "QuestionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Answers", "QuestionID");
            AddForeignKey("dbo.Answers", "QuestionID", "dbo.Questions", "QuestionID", cascadeDelete: true);
        }
    }
}
