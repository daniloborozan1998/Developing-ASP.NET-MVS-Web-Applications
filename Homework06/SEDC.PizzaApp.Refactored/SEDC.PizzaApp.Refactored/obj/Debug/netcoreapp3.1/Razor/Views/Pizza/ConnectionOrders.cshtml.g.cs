#pragma checksum "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\ConnectionOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "871ecdca2d5ec4f1b759cec6e6fc3f24b1debb6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_ConnectionOrders), @"mvc.1.0.view", @"/Views/Pizza/ConnectionOrders.cshtml")]
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
#line 1 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.OrderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.FeedbackViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871ecdca2d5ec4f1b759cec6e6fc3f24b1debb6d", @"/Views/Pizza/ConnectionOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628af6b102fa6929dfff16ec6bb091030bfa064f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_ConnectionOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\ConnectionOrders.cshtml"
     foreach (OrderListViewModel order in Model)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-white bg-success mb-3\" style=\"max-width: 18rem; margin-left:10px;\">\r\n            \r\n            <div class=\"card-header\">Id: ");
#nullable restore
#line 10 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\ConnectionOrders.cshtml"
                                    Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">User: ");
#nullable restore
#line 12 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\ConnectionOrders.cshtml"
                                        Write(order.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <ul>\r\n                    Delivered:  ");
#nullable restore
#line 14 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\ConnectionOrders.cshtml"
                           Write(order.Delivered);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\Danilo Borozan\Downloads\skwd9-net-08-aspnetmvc-main\skwd9-net-08-aspnetmvc-main\G2\Class10 - Final App\Code\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\ConnectionOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591