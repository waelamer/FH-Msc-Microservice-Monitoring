namespace DealStoreweb.Backend.Provider
{

    public class ProviderProfile : AutoMapper.Profile
    {
        public ProviderProfile()
        {
            CreateMap<DealStoreweb.Backend.Models.ProviderTbl, Provider>();
            CreateMap<Provider, DealStoreweb.Backend.Models.ProviderTbl>();
        }
    }
}
