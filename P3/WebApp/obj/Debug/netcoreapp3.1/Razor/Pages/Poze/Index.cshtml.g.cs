#pragma checksum "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a897e24a6cba8217d1eca4e1789df7c1e4513c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Poze.Pages_Poze_Index), @"mvc.1.0.razor-page", @"/Pages/Poze/Index.cshtml")]
namespace WebApp.Pages.Poze
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
#line 1 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a897e24a6cba8217d1eca4e1789df7c1e4513c6", @"/Pages/Poze/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54a580a236bf4511f2b8e02a6219a9844921dafb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Poze_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
  
    ViewData["Title"] = "Poze";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Poze</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Cale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Tip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Data_creare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Descriere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Del));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Persoanes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Locatiis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pozes[0].Evenimentes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
         foreach (var item in Model.Pozes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"font-size:small\">\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data_creare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descriere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Del));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Persoanes.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locatiis.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Evenimentes.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\LauR\Desktop\facultate\TSPNET\P3\WebApp\Pages\Poze\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.Poze.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Poze.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Poze.IndexModel>)PageContext?.ViewData;
        public WebApp.Pages.Poze.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
