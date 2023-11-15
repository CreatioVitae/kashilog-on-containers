using Front.Kashilog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DomainObject.Kashilog.ConstantValues.Shared;

namespace Front.Kashilog.Controllers;
public class ProductsController : Controller {
    private readonly ILogger<ProductsController> _logger;

    IConfiguration Configuration { get; }

    public ProductsController(ILogger<ProductsController> logger, IConfiguration configuration) => (_logger, Configuration) = (logger, configuration);

    public IActionResult Index() {
        ViewBag.ApiUrl = Configuration["KashilogSettings:ApiUrl"] ?? throw new InvalidOperationException();

        ViewBag.DeviceType = Request.Headers.UserAgent.IsAny(ua => ua.GetDeviceType() == DeviceType.Smartphone) ? DeviceType.Smartphone : DeviceType.Pc;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

static file class StringExtensions {
    internal static DeviceType GetDeviceType(this string? userAgent) {
        if(userAgent == null) {
            return DeviceType.Pc;
        }

        return userAgent.Contains("iPhone") || userAgent.Contains("Android") ? DeviceType.Smartphone : DeviceType.Pc;
    }
}
