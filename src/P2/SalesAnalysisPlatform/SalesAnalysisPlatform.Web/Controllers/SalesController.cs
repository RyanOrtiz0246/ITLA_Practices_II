using Microsoft.AspNetCore.Mvc;
using SalesAnalysisPlatform.Application.Interfaces;
using SalesAnalysisPlatform.Domain.Entities;

namespace SalesAnalysisPlatform.Web.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISaleService _saleService;

        public SalesController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        public async Task<IActionResult> Index()
        {
            var sales = await _saleService.GetAllSalesAsync();
            return View(sales);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Sale sale)
        {
            if (ModelState.IsValid)
            {
                await _saleService.AddSaleAsync(sale);
                return RedirectToAction(nameof(Index));
            }
            return View(sale);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var sale = await _saleService.GetSaleByIdAsync(id);
            if (sale == null) return NotFound();
            return View(sale);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Sale sale)
        {
            if (ModelState.IsValid)
            {
                await _saleService.UpdateSaleAsync(sale);
                return RedirectToAction(nameof(Index));
            }
            return View(sale);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var sale = await _saleService.GetSaleByIdAsync(id);
            if (sale == null) return NotFound();
            return View(sale);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _saleService.DeleteSaleAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
