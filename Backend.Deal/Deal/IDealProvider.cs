using System.Collections.Generic;
using System.Threading.Tasks;

namespace DealStoreweb.Backend.Deal
{
    public interface IDealProvider
    {
        Task<(bool IsSuccess, IEnumerable<Deal> Deals, string ErrorMessage)> Search(int CatID);

        Task<(bool IsSuccess, IEnumerable<Deal> Deals, string ErrorMessage)> GetALl();

        Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> GetDetails(int id);

        Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> Add(Deal deal);

        Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> Update(Deal deal);

        Task<(bool IsSuccess, Deal Deal, string ErrorMessage)> Delete(int id);
    }
}