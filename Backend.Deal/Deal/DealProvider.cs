using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DealStoreweb.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DealStoreweb.Backend.Deal
{
    public class DealProvider : IDealProvider
    {
        private readonly dealstoreDBContext dbContext;
        private readonly ILogger<DealProvider> logger;
        private readonly IMapper mapper;

        public DealProvider(dealstoreDBContext dbContext, ILogger<DealProvider> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<(bool IsSuccess, IEnumerable<Deal> Deals, string ErrorMessage)> Search(int CatID)
        {
            try
            {
                logger?.LogInformation("Querying Deals");
                var deals = await dbContext.ServiceTbls.Where(d => d.CategoryId == CatID).ToListAsync();

                if (deals != null && deals.Any())
                {
                    logger?.LogInformation($"{deals.Count} Deals(s) found");
                    var result = mapper.Map<IEnumerable<ServiceTbl>, IEnumerable<Deal>>(deals);
                    return (true, result, null);
                }

                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, IEnumerable<Deal> Deals, string ErrorMessage)> GetALl()
        {
            try
            {
                logger?.LogInformation("Querying Deals");
                var deals = await dbContext.ServiceTbls.ToListAsync();

                if (deals != null && deals.Any())
                {
                    logger?.LogInformation($"{deals.Count} Deals(s) found");
                    var result = mapper.Map<IEnumerable<ServiceTbl>, IEnumerable<Deal>>(deals);
                    return (true, result, null);
                }

                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> GetDetails(int id)
        {
            try
            {
                logger?.LogInformation("Querying Deals");
                var deal = await dbContext.ServiceTbls.FirstOrDefaultAsync(c => c.Id == id);
                if (deal != null)
                {
                    logger?.LogInformation("Deals found");
                    var result = mapper.Map<ServiceTbl, Deal>(deal);
                    return (true, result, null);
                }

                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> Add(Deal deal)
        {
            try
            {
                logger?.LogInformation("Add Deal");
                var Dto = mapper.Map<Deal, ServiceTbl>(deal);
                dbContext.ServiceTbls.Add(Dto);
                var result = await dbContext.SaveChangesAsync();
                if (result > 0)
                {
                    logger?.LogInformation("Deal Inserted");
                    deal.Id = Dto.Id;
                    return (true, deal, null);
                }
                return (false, null, "Insert error");
            }

            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> Update(Deal deal)
        {
            try
            {
                logger?.LogInformation("update deal");
                var founded = await dbContext.ServiceTbls.FindAsync(deal.Id);
                if (founded != null)
                {
                    founded = mapper.Map<Deal, ServiceTbl>(deal);

                    var result = await dbContext.SaveChangesAsync();
                    if (result > 0)
                    {
                        logger?.LogInformation("deal updated");

                        return (true, deal, null);

                    }
                }
                return (false, null, "update error");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> Delete(int id)
        {
            try
            {
                logger?.LogInformation("Deal Delete by id.");
                var founded = await dbContext.ServiceTbls.FirstOrDefaultAsync(c => c.Id == id);
                if (founded != null)
                {
                    logger?.LogInformation("Deal found");
                    dbContext.Remove(founded);
                    var saved = await dbContext.SaveChangesAsync();
                    if (saved > 0)
                    {
                        var result = mapper.Map<ServiceTbl, Deal>(founded);
                        return (true, result, null);
                    }
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }
    }
}