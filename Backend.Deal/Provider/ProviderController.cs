using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DealStoreweb.Backend.Provider
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderAPI _providerAPI;

        public ProviderController(IProviderAPI providerAPI)
        {
            this._providerAPI = providerAPI;
        }


        /*
        API/Provider/{id} =>Detail by ID
        API/Provider/=>ALL
        API/Provider/Search
                 
        API/Provider/Start
        API/Provider/Stop
         
         */
        [HttpGet("Islive")]
        public bool IsLive()
        {
            return true;
        }


        //[HttpGet]
        //public async Task<IActionResult> GetALLAsync()
        //{
        //    var result = await dealsProvider.GetALl();
        //    if (result.IsSuccess)
        //    {
        //        return Ok(result.Deals);
        //    }
        //    return NotFound();
        //}

        [HttpGet("all")]
        public async Task<IActionResult> Search()
        {
            var result = await _providerAPI.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result.Deals);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDealAsync(int id)
        {
            var result = await _providerAPI.GetDetails(id);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProvider(Provider provider)
        {
            var result = await _providerAPI.ADD(provider);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateProvider(Provider provider)
        {
            var result = await _providerAPI.Update(provider);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteProvider(int id)
        {
            var result = await _providerAPI.Delete(id);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }
    }
}
