using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rawaa_Api.Models;
using Rawaa_Api.Services;
using Rawaa_Api.Services.Interfaces;

namespace Rawaa_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase 
    {
        
        private readonly IProvider<Restaurant> restaurantData;
        //IProvider<Restaurant> ad = new RestaurantData();

        public RestaurantController(IProvider<Restaurant> _restaurantData)
        {
            restaurantData = _restaurantData;
        }
        
        [HttpPost("addRestaurant")]
        public IActionResult PostRestaurant([FromBody] Restaurant restaurant)
        {
            restaurantData.Add(restaurant);
            return Ok();
        }

        [HttpGet("all")]
        public IActionResult GetRestaurants()
        {
            return Ok(restaurantData.Find(1));
        }

        [HttpGet("Show/{id=1}")]
        public IActionResult GetRestaurant(int id)
        {
            return Ok(restaurantData.Find(1));
        }
    }
}
