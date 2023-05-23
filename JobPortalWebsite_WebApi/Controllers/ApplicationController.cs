using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class ApplicationController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<application> GetDetails()
        {
            var alist = db.applications.ToList();
            return alist;
        }
        [HttpGet] //fetch data from db
        public application Get(int Id)
        {
            application p = db.applications.FirstOrDefault(P => P.application_id == Id);
            return p;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] application p) //to fetch message from the body
        {
            db.applications.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, application p)
        {
            var pd = db.applications.FirstOrDefault(P => P.application_id == ID);
            if (pd != null)
            {
                pd.application_id = p.application_id;
                pd.job_id = p.job_id;
                pd.job_seeker_id = p.job_seeker_id;
                pd.cover_letter = p.cover_letter;
                pd.resume = p.resume;
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.applications.FirstOrDefault(P => P.application_id == ID);
            if (d != null)
            {
                db.applications.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
