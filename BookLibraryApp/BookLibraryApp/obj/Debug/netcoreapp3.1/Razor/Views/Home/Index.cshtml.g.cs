#pragma checksum "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f1bf70fdf76f36cced0bd3ee2f654163620ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.ReservationsViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.BookViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\_ViewImports.cshtml"
using BookLibraryApp.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f1bf70fdf76f36cced0bd3ee2f654163620ba6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f03957f18ce987fa3f516aff9f048053d4c7161", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookLibraryApp.ViewModels.HomeViewModels.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danilo Borozan\Desktop\BookLibraryApp\BookLibraryApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<div class=""jumbotron"" style=""background: rgba(255, 120, 95, 0.6); "">
    <h1 class=""display-4"" style=""color: white; font-weight: bold;"">Book Library!</h1>
    <p class=""lead"" style=""color: white"">Welcome to our free collection of e-books, developed for all ages.</p>
    <hr class=""my-4"" >
    
    <p class=""lead"">

        <button type=""button"" class=""btn btn-info"">
            <span class=""badge badge-light"">2 ");
            WriteLiteral(" </span> Books.\r\n        </button>\r\n        <button type=\"button\" class=\"btn btn-info\">\r\n            <span class=\"badge badge-light\">20 ");
            WriteLiteral(" </span> Reservations.\r\n        </button>\r\n    </p>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibraryApp.ViewModels.HomeViewModels.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
