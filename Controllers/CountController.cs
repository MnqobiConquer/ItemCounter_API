using ItemCounter_API.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ItemCounter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        [HttpPost]
        public IActionResult CountItems([FromBody] CountItemRequest request)
        {
            if (request == null || request.Items == null || request.Items.Count == 0)
                return BadRequest("No items provided.");

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var item in request.Items)
            {
                string key = item.ToString(); 

                if (counts.ContainsKey(key))
                    counts[key]++;
                else
                    counts[key] = 1;
            }

            return Ok(counts);
        }
    }
}
