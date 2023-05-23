
namespace JobPortalWebsite1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobSeekertable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobSeekertable()
        {
            this.AppliedJobsTables = new HashSet<AppliedJobsTable>();
        }
    
        public int Jobseeker_Id { get; set; }
        public string Jobseeker_FirstName { get; set; }
        public string Jobseeker_LastName { get; set; }
        public string Jobseeker_Gender { get; set; }
        public Nullable<System.DateTime> Jobseeker_DateofBirth { get; set; }
        public string Jobseeker_EmailId { get; set; }
        public string Jobseeker_PhoneNum { get; set; }
        public string Jobseeker_Skills { get; set; }
        public string Jobseeker_Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppliedJobsTable> AppliedJobsTables { get; set; }
    }
}
