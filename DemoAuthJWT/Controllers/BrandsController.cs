using DemoAuthJWT.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAuthJWT.Controllers
{    
    [ApiController]
    public class BrandsController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        [Authorize(Roles = "Director,Manager")]
        public IActionResult GetBrands()
        {
            var brands = new BrandRepository().GetAll();

            return Ok(brands);
        }
    }
}