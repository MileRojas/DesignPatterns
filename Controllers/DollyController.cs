using Microsoft.AspNetCore.Mvc;
using movilidades.Model;

namespace movilidades.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class DollyController : ControllerBase
    {


        [HttpGet]
        public IActionResult CloneDolly()
        {
            DollyFirstPrototype dollyoriginal = new DollyFirstPrototype("celula somática I");
            DollyFirstPrototype firstclone = (DollyFirstPrototype)dollyoriginal.Clone();

            string clone1 = "Clone 1: " + firstclone.Id;

            DollySecondPrototype dollyclone = new DollySecondPrototype("celula somática II");
            DollySecondPrototype secondclone = (DollySecondPrototype)dollyclone.Clone();

            string clone2 = "Clone 2: " + secondclone.Id;

            string[] result = {clone1, clone2}; 

            return Ok(result);
        }
    }

}