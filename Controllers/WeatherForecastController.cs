using DB;
using Microsoft.AspNetCore.Mvc;

namespace CodeFisrt_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeerController : ControllerBase
    {
     
        private BarContext _context;

        public BeerController(BarContext context) 
        { 
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Beer> Get() => _context.Beers.ToList();
            

    
    }
}
