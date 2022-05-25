namespace DealStoreweb.Backend.System
{
    public class SysProfile : AutoMapper.Profile
    {
        public SysProfile()
        {
            CreateMap<Models.CategoryTbl, Category>();
        }
    }


}
