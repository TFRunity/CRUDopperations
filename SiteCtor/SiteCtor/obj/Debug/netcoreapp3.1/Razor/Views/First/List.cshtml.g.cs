#pragma checksum "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a363a8a8bfaad4a0f941a5d12e95770fab01208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_List), @"mvc.1.0.view", @"/Views/First/List.cshtml")]
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
#line 1 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\_ViewImports.cshtml"
using SiteCtor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\_ViewImports.cshtml"
using SiteCtor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\_ViewImports.cshtml"
using SiteCtor.DatabaseMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a363a8a8bfaad4a0f941a5d12e95770fab01208", @"/Views/First/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9a1576143bcace051059eb0c90d89345050266", @"/Views/_ViewImports.cshtml")]
    public class Views_First_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstSiteModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
  
    foreach (FirstSiteModel site in Model)
    {
        FirstSiteModel oldsiteModel = site;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 8 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
       Write(site.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 11 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
       Write(site.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 14 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
       Write(site.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 333, "\"", 382, 1);
#nullable restore
#line 17 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
WriteAttributeValue("", 340, Url.Action("Edit", "First", oldsiteModel), 340, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>Edit</h3></a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 417, "\"", 468, 1);
#nullable restore
#line 18 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
WriteAttributeValue("", 424, Url.Action("Delete", "First", oldsiteModel), 424, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>Delete</h3></a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href =\"", 529, "\"", 567, 1);
#nullable restore
#line 23 "C:\Users\Alexe\source\repos\SiteCtor\SiteCtor\Views\First\List.cshtml"
WriteAttributeValue("", 537, Url.Action("Create", "First"), 537, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h2>??????????, ?????????? ?????????????????? ????????</h2></a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FirstSiteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
