using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantOpinionsController : ControllerBase
    {
        private IRestaurantOpinionService _restaurantOpinionService;

        public RestaurantOpinionsController(IRestaurantOpinionService restaurantOpinionService)
        {
            _restaurantOpinionService = restaurantOpinionService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _restaurantOpinionService.GetAll(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
