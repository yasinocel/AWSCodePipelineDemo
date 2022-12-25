using Microsoft.AspNetCore.Mvc;

namespace AWSCodePipelineDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        [HttpGet("get-products")]
        public IActionResult GetProducts()
        {

            var products = new List<String>
            {
                "Pantolon",
                "Ayakkabı",
                "Gömlek"
            };

            return Ok(products);

        }

    }
}
