using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DealStoreweb.Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DealStoreweb.Backend.System
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysController : ControllerBase
    {
        private readonly ISysAPI _sysAPI;

        public SysController(ISysAPI providerAPI)
        {
            this._sysAPI = providerAPI;
        }

        [HttpGet("Category")]
        public IActionResult GetCategory()
        {
            try
            {
               
                return Ok(_sysAPI.GetAllCategory());
            }
            catch
            {
                return NotFound();
            }




        }
    }
}
