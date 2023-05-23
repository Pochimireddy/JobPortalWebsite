using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobPortalWebsite_WebApi.Models;

namespace JobPortalWebsite_WebApi.Controllers
{
    public class MessageController : ApiController
    {
        JobPortalWebsite2 db = new JobPortalWebsite2();

        public IEnumerable<message> GetDetails()
        {
            var mlist = db.messages.ToList();
            return mlist;
        }
        [HttpGet] //fetch data from db
        public message Get(int Id)
        {
            message p = db.messages.FirstOrDefault(P => P.message_id == Id);
            return p;
        }
        [HttpPost] //create a new resource
        public void Post([FromBody] message p) //to fetch message from the body
        {
            db.messages.Add(p);
            db.SaveChanges();
        }

        [HttpPut] //update the existing data
        public void Put(int ID, message p)
        {
            var pd = db.messages.FirstOrDefault(P => P.message_id == ID);
            if (pd != null)
            {
                pd.message_id = p.message_id;
                pd.sender_id = p.sender_id;
                pd.receiver_id = p.receiver_id;
                pd.message_body = p.message_body;
                pd.sent_date = p.sent_date;
                db.SaveChanges();
            }
        }
        [HttpDelete] //delete the data
        public void Delete(int ID)
        {
            var d = db.messages.FirstOrDefault(P => P.message_id == ID);
            if (d != null)
            {
                db.messages.Remove(d); //we use .remove
                db.SaveChanges();
            }
        }
    }
}
