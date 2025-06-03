using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ItemCounter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        [HttpPost]
        public IActionResult CountItems([FromBody] List<object> items)
        {
            if (items == null || items.Count == 0)
                return BadRequest("No items provided.");

            Dictionary<object, int> counts = new Dictionary<object, int>();

            foreach (var item in items)
            {
                if (counts.ContainsKey(item))
                    counts[item]++;
                else
                    counts[item] = 1;
            }

            return Ok(counts);
        }
    }
}
