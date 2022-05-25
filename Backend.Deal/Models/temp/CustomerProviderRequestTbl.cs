using System;
using System.Collections.Generic;

#nullable disable

namespace DealStoreweb.Backend.Models
{
    public partial class CustomerProviderRequestTbl
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProviderId { get; set; }
        public int RequestId { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsDenied { get; set; }
        public bool IsHandled { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedDatetimeOn { get; set; }

        public virtual CustomerTbl Customer { get; set; }
        public virtual ProviderTbl Provider { get; set; }
        public virtual RequestTbl Request { get; set; }
    }
}
