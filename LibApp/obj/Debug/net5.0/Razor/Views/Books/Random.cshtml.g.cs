#pragma checksum "D:\Projects\LibApp\Views\Books\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e8b969e405d7cd4f7644cc7913540f16b74f15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Random), @"mvc.1.0.view", @"/Views/Books/Random.cshtml")]
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
#line 1 "D:\Projects\LibApp\Views\_ViewImports.cshtml"
using LibApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\LibApp\Views\_ViewImports.cshtml"
using LibApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e8b969e405d7cd4f7644cc7913540f16b74f15", @"/Views/Books/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbce3ab8be2552ae2c0c63b9eec500954dd42b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibApp.ViewModels.RandomBookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\LibApp\Views\Books\Random.cshtml"
  
    ViewBag.Title = "Random";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var className = Model.Customers.Count > 5 ? "popular" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2");
            BeginWriteAttribute("class", " class=\"", 207, "\"", 225, 1);
#nullable restore
#line 10 "D:\Projects\LibApp\Views\Books\Random.cshtml"
WriteAttributeValue("", 215, className, 215, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "D:\Projects\LibApp\Views\Books\Random.cshtml"
                  Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 12 "D:\Projects\LibApp\Views\Books\Random.cshtml"
 if (Model.Customers.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No one has borrowed this book before</p>\r\n");
#nullable restore
#line 15 "D:\Projects\LibApp\Views\Books\Random.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 19 "D:\Projects\LibApp\Views\Books\Random.cshtml"
         foreach (var customer in Model.Customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 21 "D:\Projects\LibApp\Views\Books\Random.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "D:\Projects\LibApp\Views\Books\Random.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 24 "D:\Projects\LibApp\Views\Books\Random.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibApp.ViewModels.RandomBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
