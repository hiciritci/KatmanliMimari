#pragma checksum "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0626c6e0878ef738fa6ba779a0b41f08886ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\_ViewImports.cshtml"
using MvcUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\_ViewImports.cshtml"
using MvcUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0626c6e0878ef738fa6ba779a0b41f08886ba7", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626b5fcac875be8e1ebb777fe08584c4b84f6f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<h2>Catergory List</h2>\r\n<div class=\"list-group\">\r\n    <a href=\"/product/index\" class=\"list-group-item\">Tüm Ürünler</a>\r\n    \r\n\r\n");
#nullable restore
#line 11 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {

        var css = "list-group-item";
        if(category.CategoryId==Model.Currentcategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 382, "\"", 433, 2);
            WriteAttributeValue("", 389, "/product/index?category=", 389, 24, true);
#nullable restore
#line 19 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 413, category.CategoryId, 413, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 434, "\"", 446, 1);
#nullable restore
#line 19 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 442, css, 442, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\3759537\source\repos\NortwindLevelTwo\MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
