using System;

namespace DealStoreweb.Backend.Provider
{
    public class Provider
    {
        public Provider()
        {
            Id = -1;
        }

        public int Id { get; set; }
        public Guid UserRef { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyLogo { get; set; }
        public string Occupation { get; set; }
        public DateTime CreatedDatetimeOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDatetimeOn { get; set; }
        public int? UpdatedBy { get; set; }

        //public virtual UserTbl UserRefNavigation { get; set; }



    }
}
