using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class companyController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<company> GetDetails()
        {
            var clist = db.companies.ToList();
            return clist;
        }
        [HttpGet] //fetch data from db
        public company Get(int Id)
        {
            company p = db.companies.FirstOrDefault(P => P.company_id == Id);
            return p;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] company p) //to fetch message from the body
        {
            db.companies.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, company p)
        {
            var pd = db.companies.FirstOrDefault(P => P.company_id == ID);
            if (pd != null)
            {
                pd.company_id = p.company_id;
                pd.username = p.username;
                pd.password = p.password;
                pd.company_name = p.company_name;
                pd.email = p.email;
                pd.phone_number = p.phone_number;
                pd.address = p.address;
                pd.description = p.description;
                pd.industry = p.industry;
                
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.companies.FirstOrDefault(P => P.company_id == ID);
            if (d != null)
            {
                db.companies.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
