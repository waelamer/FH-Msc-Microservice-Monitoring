using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DealStoreweb.Backend.Deal
{

    /// <summary>
    /// Deal Controller for Search GUI, Search A service by Category or by Plz or both
    /// </summary>

    [Route("api/deal")]
    [ApiController]
    [SwaggerTag("Deal Controller for Search GUI, Search A service by Category or by Plz or both")]
    public class DealController : ControllerBase
    {
        private readonly IDealProvider dealsProvider;

        public DealController(IDealProvider dealsProvider)
        {
            this.dealsProvider = dealsProvider;
        }


        /*
        API/DEAL/{id} =>Detail by ID
        API/DEAL/=>ALL
        API/DEAL/Search
                 
        API/DEAL/Start
        API/DEAL/Stop
         
         */
        [HttpGet("Islive")]
        public bool IsLive()
        {
            return true;
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetALLAsync(int CategoryID)
        {
            var result = await dealsProvider.Search(CategoryID);
            if (result.IsSuccess) return Ok(result.Deals);
            return NotFound();
        }

        [HttpGet("all")]
        public async Task<IActionResult> Search()
        {
            var result = await dealsProvider.GetALl();
            if (result.IsSuccess) return Ok(result.Deals);
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeal(int id)
        {
            var result = await dealsProvider.GetDetails(id);
            if (result.IsSuccess) return Ok(result.Deal);
            return NotFound();
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddDeal(Deal deal)
        {
            var result = await dealsProvider.Add(deal);
            if (result.IsSuccess) return Ok(result.Deal);
            return NotFound();
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDeal(Deal deal)
        {
            var result = await dealsProvider.Update(deal);
            if (result.IsSuccess) return Ok(result.Deal);
            return NotFound();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteDeal(int id)
        {
            var result = await dealsProvider.Delete(id);
            if (result.IsSuccess) return Ok(result.Deal);
            return NotFound();
        }
        
    }
}