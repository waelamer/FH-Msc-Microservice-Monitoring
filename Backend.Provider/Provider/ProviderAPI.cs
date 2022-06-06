using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
//using DealStoreweb.Backend.Deal;
using DealStoreweb.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DealStoreweb.Backend.Provider
{
    public class ProviderAPI : IProviderAPI
    {
        private readonly dealstoreDBContext dbContext;
        private readonly ILogger<ProviderAPI> logger;
        private readonly IMapper mapper;

        public ProviderAPI(dealstoreDBContext dbContext, ILogger<ProviderAPI> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }
        public async Task<(bool IsSuccess, IEnumerable<Provider> Deals, string ErrorMessage)> GetAll()
        {
            try
            {
                logger?.LogInformation("Querying Deals");
                var providers = await dbContext.ProviderTbls.ToListAsync();

                if (providers != null && providers.Any())
                {
                    logger?.LogInformation($"{providers.Count} Providers(s) found");
                    var result = mapper.Map<IEnumerable<ProviderTbl>, IEnumerable<Provider>>(providers);

                    Meter s_meter = new Meter("DealStore.ProvidersMetrics", "1.0.0");
                    Counter<int> ProviderCount = s_meter.CreateCounter<int>(name: "Providers-inDB",
                                                                                unit: "Deals",
                                                                              description: "The number of Providers in our store");
                    ProviderCount.Add(providers.Count);
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

        public async Task<(bool IsSuccess, Provider, string ErrorMessage)> GetDetails(int id)
        {
            try
            {
                logger?.LogInformation("Querying Deals by id ");
                var items = await dbContext.ProviderTbls.FirstOrDefaultAsync(c => c.Id == id);
                if (items != null)
                {
                    logger?.LogInformation("Deals found");
                    var result = mapper.Map<ProviderTbl, Provider>(items);
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

        public async Task<(bool IsSuccess, Provider, string ErrorMessage)> ADD(Provider provider)
        {
            try
            {
                logger?.LogInformation("Add Provider");
                var Dto = mapper.Map<Provider, ProviderTbl>(provider);
                dbContext.ProviderTbls.Add(Dto);
                var result = await dbContext.SaveChangesAsync();
                if (result > 0)
                {
                    logger?.LogInformation("Provider Inserted");
                    provider.Id = Dto.Id;
                    return (true, provider, null);

                }
                return (false, null, "Insert error");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Provider, string ErrorMessage)> Update(Provider provider)
        {
            try
            {
                logger?.LogInformation("update Provider");
                var founded = await dbContext.ProviderTbls.FindAsync(provider.Id);
                if (founded != null)
                {
                    founded.CompanyDescription = provider.CompanyDescription;
                    founded.CompanyLogo = provider.CompanyLogo;
                    founded.CompanyName = provider.CompanyName;
                    founded.Occupation = provider.Occupation;
                    founded.UserRef = provider.UserRef;
                    var result = await dbContext.SaveChangesAsync();
                    if (result > 0)
                    {
                        logger?.LogInformation("Provider updated");

                        return (true, provider, null);

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

        public async Task<(bool IsSuccess, Provider, string ErrorMessage)> Delete(int id)
        {
            try
            {
                logger?.LogInformation("Provider Delete by id.");
                var items = await dbContext.ProviderTbls.FirstOrDefaultAsync(c => c.Id == id);
                if (items != null)
                {
                    logger?.LogInformation("Provider found");
                    dbContext.Remove(items);
                    var saved = await dbContext.SaveChangesAsync();
                    if (saved > 0)
                    {
                        var result = mapper.Map<ProviderTbl, Provider>(items);
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
