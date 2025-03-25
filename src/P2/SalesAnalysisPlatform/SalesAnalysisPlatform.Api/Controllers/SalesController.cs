using Microsoft.AspNetCore.Mvc;
using SalesAnalysisPlatform.Application.Interfaces;
using SalesAnalysisPlatform.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesAnalysisPlatform.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SalesController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetAllSales()
        {
            var sales = await _saleService.GetAllSalesAsync();
            return Ok(sales);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSaleById(int id)
        {
            var sale = await _saleService.GetSaleByIdAsync(id);
            if (sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }

        [HttpPost]
        public async Task<ActionResult> CreateSale([FromBody] Sale sale)
        {
            if (sale == null)
            {
                return BadRequest();
            }

            await _saleService.AddSaleAsync(sale);
            return CreatedAtAction(nameof(GetSaleById), new { id = sale.Id }, sale);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSale(int id, [FromBody] Sale sale)
        {
            if (id != sale.Id)
            {
                return BadRequest();
            }

            await _saleService.UpdateSaleAsync(sale);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSale(int id)
        {
            await _saleService.DeleteSaleAsync(id);
            return NoContent();
        }
    }
}
