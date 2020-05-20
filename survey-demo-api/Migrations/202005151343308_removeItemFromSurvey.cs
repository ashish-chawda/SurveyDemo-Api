namespace survey_demo_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeItemFromSurvey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "QuestionAnswerJson", c => c.String());
            DropColumn("dbo.Surveys", "SurveyQuestion");
            DropColumn("dbo.Surveys", "SurveyAnswer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "SurveyAnswer", c => c.String());
            AddColumn("dbo.Surveys", "SurveyQuestion", c => c.String());
            DropColumn("dbo.Surveys", "QuestionAnswerJson");
        }
    }
}
