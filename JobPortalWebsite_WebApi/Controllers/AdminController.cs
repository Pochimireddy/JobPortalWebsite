using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class AdminController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<admin> GetDetails()
        {
            var alist = db.admins.ToList();
            return alist;
        }
        [HttpGet] //fetch data from db
        public admin Get(int Id)
        {
            admin a = db.admins.FirstOrDefault(P => P.admin_id == Id);
            return a;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] admin p) //to fetch message from the body
        {
            db.admins.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, admin p)
        {
            var pd = db.admins.FirstOrDefault(P => P.admin_id == ID);
            if (pd != null)
            {
                pd.admin_id = p.admin_id;
                pd.username = p.username;
                pd.password = p.password;
                pd.full_name = p.full_name;
                pd.email = p.email;
                pd.phone_number = p.phone_number;
                pd.address = p.address;
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.admins.FirstOrDefault(P => P.admin_id == ID);
            if (d != null)
            {
                db.admins.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
