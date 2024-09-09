using Microsoft.AspNetCore.Mvc;

namespace RecipeAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionsController : ControllerBase
    {
        /// <summary>
        /// Convert Teaspoons to Milliliters
        /// </summary>
        /// <param name="teaspoons">The amount in teaspoons.</param>
        /// <returns>The equivalent amount in milliliters.</returns>
        [HttpGet("teaspoons-to-milliliters")]
        public ActionResult<double> ConvertTeaspoonsToMilliliters(double teaspoons)
        {
            const double millilitersPerTeaspoon = 4.92892;
            double milliliters = Math.Round(teaspoons * millilitersPerTeaspoon, 2);
            return Ok(milliliters);
        }
    }
}
