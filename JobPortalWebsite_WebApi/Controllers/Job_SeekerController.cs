using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class Job_SeekerController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<job_seeker> GetDetails()
        {
            var jlist = db.job_seeker.ToList();
            return jlist;
        }
        [HttpGet] //fetch data from db
        public job_seeker Get(int Id)
        {
            job_seeker p = db.job_seeker.FirstOrDefault(P => P.job_seeker_id == Id);
            return p;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] job_seeker p) //to fetch message from the body
        {
            db.job_seeker.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, job_seeker p)
        {
            var pd = db.job_seeker.FirstOrDefault(P => P.job_seeker_id == ID);
            if (pd != null)
            {
                pd.job_seeker_id = p.job_seeker_id;
                pd.username = p.username;
                pd.password = p.password;
                pd.full_name = p.full_name;
                pd.email = p.email;
                pd.phone_number = p.phone_number;
                pd.address = p.address;
                pd.education_level = p.education_level;
                pd.experience = p.experience;
                pd.resume = p.resume;
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.job_seeker.FirstOrDefault(P => P.job_seeker_id == ID);
            if (d != null)
            {
                db.job_seeker.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
