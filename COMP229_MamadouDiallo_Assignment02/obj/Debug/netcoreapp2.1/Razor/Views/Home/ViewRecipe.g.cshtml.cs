#pragma checksum "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a676fba048cc6e8bfa8890d660513cd6e6b6d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a676fba048cc6e8bfa8890d660513cd6e6b6d81", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b10c44952853f9b25a7e2fd0453571bf8fcf2e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Home\ViewRecipe.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "View Recipe";

#line default
#line hidden
            BeginContext(83, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(88, 40, false);
#line 8 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Home\ViewRecipe.cshtml"
Write(await Html.PartialAsync("RecipeViewing"));

#line default
#line hidden
            EndContext();
            BeginContext(128, 2, true);
            WriteLiteral("\r\n");
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
