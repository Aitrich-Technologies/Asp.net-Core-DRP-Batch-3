<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Pages/Error.cshtml.cs
========
﻿using System.Diagnostics;
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Activity/Tour/Tour/Pages/Error.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Pages/Error.cshtml.cs
namespace Exercise3.Pages
========
namespace Tour.Pages
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Activity/Tour/Tour/Pages/Error.cshtml.cs
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
