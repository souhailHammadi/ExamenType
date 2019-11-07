namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "QuestionID" });
            AlterColumn("dbo.Answers", "QuestionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Answers", "QuestionID");
            AddForeignKey("dbo.Answers", "QuestionID", "dbo.Questions", "QuestionID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "QuestionID" });
            AlterColumn("dbo.Answers", "QuestionID", c => c.Int());
            CreateIndex("dbo.Answers", "QuestionID");
            AddForeignKey("dbo.Answers", "QuestionID", "dbo.Questions", "QuestionID");
        }
    }
}
