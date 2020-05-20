namespace survey_demo_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesSurveyIdToGuid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Surveys");
            AlterColumn("dbo.Surveys", "SurveyId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Surveys", "SurveyId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Surveys");
            AlterColumn("dbo.Surveys", "SurveyId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Surveys", "SurveyId");
        }
    }
}
