using Microsoft.AspNetCore.Mvc;
using movilidades.Model;

namespace movilidades.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CompoundController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCompound()
        {
            Compound unknown = new Compound();
            Compound water = new RichCompound("Water");
            Compound benzene = new RichCompound("Benzene");
            Compound ethanol = new RichCompound("Ethanol");

            string[] Unknown = unknown.Display();
            string[] Water = water.Display();
            string[] Benzene = benzene.Display();
            string[] Ethanol = ethanol.Display();

            return Ok(Ethanol);
        }

    }
}