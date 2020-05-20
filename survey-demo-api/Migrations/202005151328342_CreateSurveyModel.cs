namespace survey_demo_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSurveyModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyId = c.Guid(nullable: false),
                        SurveyQuestion = c.String(),
                        SurveyAnswer = c.String(),
                    })
                .PrimaryKey(t => t.SurveyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surveys");
        }
    }
}
