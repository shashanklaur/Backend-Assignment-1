using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : Controller
    {
        // Prices
        private const decimal SmallPrice = 25.50m;
        private const decimal LargePrice = 40.50m; // 45.50 if needed
        private const decimal TaxRate = 0.13m;

        /// <summary>
        /// Returns the checkout summary for an order of SquashFellows plushies.
        /// </summary>
        /// <param name="Small">The number of Small plushies ordered.</param>
        /// <param name="Large">The number of Large plushies ordered.</param>
        /// <returns>A string detailing the order summary, including subtotal, tax, and total.</returns>
        [HttpPost("squashfellows")]
        public ActionResult<string> GetOrderSummary([FromForm] int Small, [FromForm] int Large)
        {
            // Calculate subtotal
            decimal smallTotal = Small * SmallPrice;
            decimal largeTotal = Large * LargePrice;
            decimal subtotal = smallTotal + largeTotal;

            // Calculate tax and total
            decimal tax = subtotal * TaxRate;
            decimal total = subtotal + tax;

            // Format the result string
            string result = $"{Small} Small @ ${SmallPrice.ToString("F2", CultureInfo.InvariantCulture)} = ${smallTotal.ToString("F2", CultureInfo.InvariantCulture)}; " +
                            $"{Large} Large @ ${LargePrice.ToString("F2", CultureInfo.InvariantCulture)} = ${largeTotal.ToString("F2", CultureInfo.InvariantCulture)}; " +
                            $"Subtotal = ${subtotal.ToString("F2", CultureInfo.InvariantCulture)}; " +
                            $"Tax = ${tax.ToString("F2", CultureInfo.InvariantCulture)}; " +
                            $"Total = ${total.ToString("F2", CultureInfo.InvariantCulture)}";

            return Ok(result);
        }
    }
}
