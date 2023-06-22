using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session4.Models;
using Session4.ResponseModel;
using Session4.Service;

namespace Session4.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.1")]
    public class DishController : ControllerBase
    {
        readonly IDishService _dishService;
        readonly ILogger<DishController> _logger;
        readonly IDataProtector _dataProtector;
        public DishController(IDishService dishService, ILogger<DishController> logger1, IDataProtectionProvider provider)
        {
            _dishService = dishService;
            _logger = logger1;
            _dataProtector = provider.CreateProtector("");
        }

        [HttpGet]

        public ActionResult GetAllDishes()
        {
            _logger.Log(LogLevel.Information, "List of Dishes Returned V--1.1");
            List<Dish1> dishesV1= _dishService.GetAllDishesV1();
            dishesV1.ForEach(c =>
            {
                c.Id = _dataProtector.Protect((c.Id).ToString());
            });
            Response ResData= new Response()
           {
               Errors=null,
               Message="Success",
               Data=dishesV1,
               Succeeded=true   
           };
            return Ok(ResData);
        }
    }
}
