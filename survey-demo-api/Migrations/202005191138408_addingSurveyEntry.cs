namespace survey_demo_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingSurveyEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubmitSurveys",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        SurveyJson = c.String(),
                        SubmittedDate = c.DateTime(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubmitSurveys");
        }
    }
}
