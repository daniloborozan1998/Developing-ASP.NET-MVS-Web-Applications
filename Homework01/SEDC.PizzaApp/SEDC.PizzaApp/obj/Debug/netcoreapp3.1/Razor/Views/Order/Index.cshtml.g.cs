#pragma checksum "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1357aa7011898d8f2512f375f3a0596107fbd2db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1357aa7011898d8f2512f375f3a0596107fbd2db", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SEDC.PizzaApp.Models.Domain.Orders>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Order List:</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
 for (int i = 0; i < Model.Count(); i++) 
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>Contact Name: ");
#nullable restore
#line 8 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
                 Write(Model[i].ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n    <h6>Type of Pizza: ");
#nullable restore
#line 9 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
                  Write(Model[i].TypeofPizza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <p>Municipality: ");
#nullable restore
#line 10 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
                Write(Model[i].Municipality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Phone: ");
#nullable restore
#line 11 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
         Write(Model[i].Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\Danilo Borozan\Desktop\Homework01\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SEDC.PizzaApp.Models.Domain.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
