﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DealStoreweb.Backend.Models
{
    public partial class CategoryTbl
    {
        public CategoryTbl()
        {
            ServiceTbls = new HashSet<ServiceTbl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServiceTbl> ServiceTbls { get; set; }
    }
}