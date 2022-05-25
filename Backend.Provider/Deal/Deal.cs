using System;

namespace DealStoreweb.Backend.Deal
{
    public class Deal
    {
        public int Id { get; set; }
        public Guid UserRef { get; set; }
        public string Name { get; set; }
        public string Description_Short { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreatedDatetimeOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDatetimeOn { get; set; }
        public int? UpdatedBy { get; set; }

        //public virtual CategoryTbl Category { get; set; }
        //public virtual UserTbl UserRefNavigation { get; set; }
        //public virtual ICollection<RequestTbl> RequestTbls { get; set; }
    }
}