using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Session4.Models;
using Session4.ResponseModel;
using Session4.Service;
using System;

namespace Session4.Controllers.v2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.2")]
    public class DishController : ControllerBase
    {
        readonly IDishService _dishService;
        readonly ILogger<DishController> _logger;
        readonly IDataProtector _dataProtector;
        public DishController(IDishService dishService, ILogger<DishController> logger,IDataProtectionProvider provider)
        {
            _dishService = dishService;
            _logger = logger;
            _dataProtector = provider.CreateProtector("");
        }
        [HttpGet]

        public ActionResult GetAllDishes()
        {
            _logger.Log(LogLevel.Information, $"List of Dishes Returned V--2.2");
            List<Dish2> dishesV2 = _dishService.GetAllDishesV2();
            dishesV2.ForEach(c =>
            {
                c.Id = _dataProtector.Protect((c.Id).ToString());
            });
            Response ResData = new Response()
            {
                Errors = null,
                Message = "Success",
                Data = dishesV2,
                Succeeded = true
            };
            return Ok(ResData);
        }
    }
}
