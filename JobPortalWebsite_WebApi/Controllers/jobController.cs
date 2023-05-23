using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class jobController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<job> GetDetails()
        {
            var jlist = db.jobs.ToList();
            return jlist;
        }
        [HttpGet] //fetch data from db
        public job Get(int Id)
        {
            job p = db.jobs.FirstOrDefault(P => P.job_id == Id);
            return p;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] job p) //to fetch message from the body
        {
            db.jobs.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, job p)
        {
            var pd = db.jobs.FirstOrDefault(P => P.job_id == ID);
            if (pd != null)
            {
                pd.job_id = p.job_id;
                pd.company_id = p.company_id;
                pd.job_title = p.job_title;
                pd.job_description = p.job_description;
                pd.job_requirements = p.job_requirements;
                pd.job_location = p.job_location;
                pd.salary_range = p.salary_range;
                pd.employment_type = p.employment_type;
                pd.created_at = p.created_at;
                pd.expiration_date = p.expiration_date;

                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.jobs.FirstOrDefault(P => P.job_id == ID);
            if (d != null)
            {
                db.jobs.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
