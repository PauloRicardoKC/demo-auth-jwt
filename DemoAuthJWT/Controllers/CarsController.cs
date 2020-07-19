using DemoAuthJWT.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAuthJWT.Controllers
{    
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        [Authorize()]
        public IActionResult GetCarsCurrent()
        {
            var cars = new CarRepository().GetByCurrent();

            return Ok(cars);
        }

        [HttpGet]
        [Route("api/[controller]/all")]
        [Authorize(Roles = "Director,Manager")]
        public IActionResult GetCars()
        {
            var cars = new CarRepository().GetAll();

            return Ok(cars);
        }
    }
}