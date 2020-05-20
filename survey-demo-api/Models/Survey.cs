using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace survey_demo_api.Models
{
    public class Survey
    {
        
        public Guid SurveyId { get; set; }

        public string QuestionAnswerJson { get; set; }

        public DateTime CreatedDate { get; set; }
        
    }
}