using Newtonsoft.Json;
using survey_demo_api.Context;
using survey_demo_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace survey_demo_api.Controllers
{
    public class SurveyController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        [Route("api/Survey/AddQuestion")]
        [HttpPost]        
        public HttpResponseMessage AddQuestionToDb(Survey model)
        {
            model.SurveyId = Guid.NewGuid();
            model.CreatedDate = DateTime.Now;
            var result = this._db.Survey.Add(model);            

            this._db.SaveChangesAsync();            
            return this.Request.CreateResponse(HttpStatusCode.OK, result);            
        }

        [Route("api/Survey/EditQuestion")]
        [HttpPut]
        public HttpResponseMessage EditQuestion(Survey model)
        {
            Survey result = this._db.Survey.Where(x => x.SurveyId == model.SurveyId).FirstOrDefault();

            result.CreatedDate = DateTime.Now;
            result.QuestionAnswerJson = model.QuestionAnswerJson;

            this._db.Entry(result).State = System.Data.Entity.EntityState.Modified;
            this._db.SaveChangesAsync();

            return this.Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted");
        }

        [Route("api/Survey/DeleteQuestion")]
        [HttpPut]
        public HttpResponseMessage DeleteQuestion(Survey model)
        {
            Survey result = this._db.Survey.Where(x => x.SurveyId == model.SurveyId).FirstOrDefault();

            if(result != null)
            {
                this._db.Survey.Remove(result);
                this._db.SaveChangesAsync();
                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }

            return this.Request.CreateResponse(HttpStatusCode.NotFound, "Record doesnt exists");


        }


        [Route("api/Survey/SubmitSurvey")]
        [HttpPost]
        public HttpResponseMessage SubmitSurveyEntry(SubmitSurvey model)
        {            
            model.SubmittedDate = DateTime.Now;
            model.LastModified = DateTime.Now;
            
            var result = this._db.SurveyEntries.Add(model);

            this._db.SaveChangesAsync();
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("api/Survey/GetSurvey")]
        [HttpGet]
        public HttpResponseMessage GetAllSurvey()
        {
            var result = this._db.Survey.ToArray().OrderBy(x => x.CreatedDate);
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }       

    }
}
