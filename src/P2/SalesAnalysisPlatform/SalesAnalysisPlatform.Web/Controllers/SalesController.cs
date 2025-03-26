using Microsoft.AspNetCore.Mvc;
using SalesAnalysisPlatform.Domain.Entities;
using SalesAnalysisPlatform.Web.Services;

namespace SalesAnalysisPlatform.Web.Controllers
{
    public class SalesController : Controller
    {
        private readonly SalesApiService _salesApiService;
        private readonly ILogger<SalesController> _logger;

        public SalesController(SalesApiService salesApiService, ILogger<SalesController> logger)
        {
            _salesApiService = salesApiService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var sales = await _salesApiService.GetAllSalesAsync();
                return View(sales);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al cargar ventas");
                TempData["ErrorMessage"] = "Error al cargar las ventas. Intente más tarde.";
                return View(new List<Sale>());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Sale sale)
        {
            if (!ModelState.IsValid)
                return View(sale);

            try
            {
                if (await _salesApiService.AddSaleAsync(sale))
                    return RedirectToAction(nameof(Index));

                ModelState.AddModelError("", "No se pudo crear la venta.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear venta");
                ModelState.AddModelError("", "Error interno al crear la venta.");
            }

            return View(sale);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var sale = await _salesApiService.GetSaleByIdAsync(id);
            return sale == null ? NotFound() : View(sale);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Sale sale)
        {
            if (!ModelState.IsValid)
                return View(sale);

            try
            {
                if (await _salesApiService.UpdateSaleAsync(sale))
                    return RedirectToAction(nameof(Index));

                ModelState.AddModelError("", "No se pudo actualizar la venta.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar venta");
                ModelState.AddModelError("", "Error interno al actualizar la venta.");
            }

            return View(sale);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var sale = await _salesApiService.GetSaleByIdAsync(id);
            return sale == null ? NotFound() : View(sale);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                if (await _salesApiService.DeleteSaleAsync(id))
                    return RedirectToAction(nameof(Index));

                TempData["ErrorMessage"] = "No se pudo eliminar la venta.";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar venta");
                TempData["ErrorMessage"] = "Error interno al eliminar la venta.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
