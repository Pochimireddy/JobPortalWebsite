using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite1.Models;

namespace JobPortalWebsite1.Controllers
{
    public class JobSeekertableController : ApiController
    {
        JobPortalWebsiteEntities db = new JobPortalWebsiteEntities();
        public IEnumerable<JobSeekertable> GetDetails()
        {
            var plist = db.JobSeekertables.ToList();
            return plist;
        }

        [HttpGet] //fetch data from db
        public JobSeekertable Get(int Id)
        {
            JobSeekertable p = db.JobSeekertables.FirstOrDefault(P => P.Jobseeker_Id == Id);
            return p;
        }

        [HttpPost] //create a new resource
        public void Post([FromBody] JobSeekertable p) //to fetch message from the body
        {
            db.JobSeekertables.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, JobSeekertable p)
        {
            var pd = db.JobSeekertables.FirstOrDefault(P => P.Jobseeker_Id == ID);
            if (pd != null)
            {
                pd.Jobseeker_Id = p.Jobseeker_Id;
                pd.Jobseeker_FirstName = p.Jobseeker_FirstName;
                pd.Jobseeker_LastName = p.Jobseeker_LastName;
                pd.Jobseeker_Gender = p.Jobseeker_Gender;
                pd.Jobseeker_DateofBirth = p.Jobseeker_DateofBirth;
                pd.Jobseeker_EmailId = p.Jobseeker_EmailId;
                pd.Jobseeker_PhoneNum = p.Jobseeker_PhoneNum;
                pd.Jobseeker_Skills = p.Jobseeker_Skills;
                pd.Jobseeker_Password = p.Jobseeker_Password;
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.JobSeekertables.FirstOrDefault(P => P.Jobseeker_Id == ID);
            if (d != null)
            {
                db.JobSeekertables.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
