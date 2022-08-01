using Microsoft.AspNetCore.Mvc;
using movilidades.Model;

namespace movilidades.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class FactoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHi()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();
            
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            return Ok("resultado en la consola");

        }
    }
}