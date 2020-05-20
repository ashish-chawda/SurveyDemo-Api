namespace survey_demo_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDateToSurvey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "CreatedDate");
        }
    }
}
