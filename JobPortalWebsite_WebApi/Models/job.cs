//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobPortalWebsite_WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class job
    {
        public int job_id { get; set; }
        public int company_id { get; set; }
        public string job_title { get; set; }
        public string job_description { get; set; }
        public string job_requirements { get; set; }
        public string job_location { get; set; }
        public string salary_range { get; set; }
        public string employment_type { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime expiration_date { get; set; }
    }
}