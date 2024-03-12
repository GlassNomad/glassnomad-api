using Microsoft.AspNetCore.Mvc; 
using GlassNomad_Api.Api.Domain.Catalog;


namespace GlassNomad_Api.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CatalogController: ControllerBase
	{
        [HttpGet]
        public IActionResult GetItems()
        {
        return Ok("hello world.");}
    }
}