using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class InterviewController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<interview> GetDetails()
        {
            var ilist = db.interviews.ToList();
            return ilist;
        }
        [HttpGet] //fetch data from db
        public interview Get(int Id)
        {
            interview p = db.interviews.FirstOrDefault(P => P.interview_id == Id);
            return p;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] interview p) //to fetch message from the body
        {
            db.interviews.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, interview p)
        {
            var pd = db.interviews.FirstOrDefault(P => P.interview_id == ID);
            if (pd != null)
            {
                pd.interview_id = p.interview_id;
                pd.application_id = p.application_id;
                pd.interviewer_id = p.interviewer_id;
                pd.interview_date = p.interview_date;
                pd.interview_time = p.interview_time;
                pd.interview_location = p.interview_location;
                pd.interview_notes = p.interview_notes;
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.interviews.FirstOrDefault(P => P.interview_id == ID);
            if (d != null)
            {
                db.interviews.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
