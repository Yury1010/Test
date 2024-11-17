using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using ABCS.Test.Infrastructure;
using ABCS.Test.Web.Viewer.Models;
using Microsoft.AspNetCore.Mvc;


namespace ABCS.Test.Web.Viewer.Controllers
{
    public sealed class HomeController(ICommunication _service) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetCompanyInfo()
        {
            (CompanyInfo info, string error) = await _service.GetCompanyInfoAsync().ConfigureAwait(false);
            return info == null ? NotFound(JsonSerializer.Serialize(new { detail = error })) : Ok(JsonSerializer.Serialize(new { company = info }));
        }
        public async Task<IActionResult> GetInvoiceInfo()
        {
            (InvoiceInfo info, string error) = await _service.GetInvoiceInfoAsync().ConfigureAwait(false);
            return info == null ? NotFound(JsonSerializer.Serialize(new { detail = error })) : Ok(JsonSerializer.Serialize(new { invoice = info }));
        }
        public async Task<IActionResult> GetItemSalesInfo()
        {
            (ItemSalesInfo info, string error) = await _service.GetItemSalesInfoAsync().ConfigureAwait(false);
            return info == null ? NotFound(JsonSerializer.Serialize(new { detail = error })) : Ok(JsonSerializer.Serialize(new { itemsales = info }));
        }
        public async Task<IActionResult> GetBillInfo()
        {
            (BillInfo info, string error) = await _service.GetBillInfoAsync().ConfigureAwait(false);
            return info == null ? NotFound(JsonSerializer.Serialize(new { detail = error })) : Ok(JsonSerializer.Serialize(new { bill = info }));
        }
        public async Task<IActionResult> GetCheckInfo()
        {
            (CheckInfo info, string error) = await _service.GetCheckInfoAsync().ConfigureAwait(false);
            return info == null ? NotFound(JsonSerializer.Serialize(new { detail = error })) : Ok(JsonSerializer.Serialize(new { check = info }));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
