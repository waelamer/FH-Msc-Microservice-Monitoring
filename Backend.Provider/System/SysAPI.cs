using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using DealStoreweb.Backend.Models;
using Microsoft.Extensions.Logging;
using NotImplementedException = System.NotImplementedException;

namespace DealStoreweb.Backend.System
{
    public class SysAPI : ISysAPI
    {
        private readonly dealstoreDBContext dbContext;
        private readonly ILogger<SysAPI> logger;
        private readonly IMapper mapper;
        public SysAPI(dealstoreDBContext dbContext, ILogger<SysAPI> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }



        public List<Category> GetAllCategory()
        {
            ;
            return new List<Category>(mapper.Map<IEnumerable<CategoryTbl>, IEnumerable<Category>>(dbContext.CategoryTbls.ToList()));
        }
    }

    public interface ISysAPI
    {
        public List<Category> GetAllCategory();
    }
}
