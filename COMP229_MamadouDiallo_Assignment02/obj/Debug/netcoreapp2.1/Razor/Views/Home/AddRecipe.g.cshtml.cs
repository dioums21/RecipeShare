#pragma checksum "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Home\AddRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e61e72a2b1f71a3acd9252c85bdfe81279b9b99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddRecipe), @"mvc.1.0.view", @"/Views/Home/AddRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddRecipe.cshtml", typeof(AspNetCore.Views_Home_AddRecipe))]
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
#line 1 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\_ViewImports.cshtml"
using COMP229_MamadouDiallo_Assignment02.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e61e72a2b1f71a3acd9252c85bdfe81279b9b99", @"/Views/Home/AddRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b10c44952853f9b25a7e2fd0453571bf8fcf2e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Home\AddRecipe.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Add a Recipe";

#line default
#line hidden
            BeginContext(86, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(93, 34, false);
#line 10 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Home\AddRecipe.cshtml"
Write(await Html.PartialAsync("Details"));

#line default
#line hidden
            EndContext();
            BeginContext(127, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
