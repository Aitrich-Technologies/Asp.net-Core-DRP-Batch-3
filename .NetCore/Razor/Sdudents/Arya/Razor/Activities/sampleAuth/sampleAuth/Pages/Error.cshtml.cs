<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Activities/sampleAuth/sampleAuth/Pages/Error.cshtml.cs
========
﻿using System.Diagnostics;
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Activity/BlazorApp1/BlazorApp1/Pages/Error.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Activities/sampleAuth/sampleAuth/Pages/Error.cshtml.cs
namespace sampleAuth.Pages
========
namespace BlazorApp1.Pages
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Activity/BlazorApp1/BlazorApp1/Pages/Error.cshtml.cs
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
