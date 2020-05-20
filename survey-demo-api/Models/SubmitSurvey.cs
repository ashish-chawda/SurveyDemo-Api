using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace survey_demo_api.Models
{
    public class SubmitSurvey
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SurveyId { get; set; }

        public string UserName { get; set; }

        public string SurveyJson { get; set; }

        public DateTime SubmittedDate { get; set; }

        public DateTime LastModified { get; set; }

        public Boolean IsCompleted { get; set; }
    }
}