#pragma checksum "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Shared\RecipeViewing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfdcd56c22afd0df484d242339b2870d752de615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RecipeViewing), @"mvc.1.0.view", @"/Views/Shared/RecipeViewing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/RecipeViewing.cshtml", typeof(AspNetCore.Views_Shared_RecipeViewing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfdcd56c22afd0df484d242339b2870d752de615", @"/Views/Shared/RecipeViewing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b10c44952853f9b25a7e2fd0453571bf8fcf2e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RecipeViewing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 56, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Name</th>\r\n        <td>");
            EndContext();
            BeginContext(72, 10, false);
#line 6 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Shared\RecipeViewing.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(82, 70, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Description</th>\r\n        <td>");
            EndContext();
            BeginContext(153, 17, false);
#line 10 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Shared\RecipeViewing.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(170, 70, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Ingredients</th>\r\n        <td>");
            EndContext();
            BeginContext(241, 17, false);
#line 14 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Shared\RecipeViewing.cshtml"
       Write(Model.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(258, 63, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Chef</th>\r\n        <td>");
            EndContext();
            BeginContext(322, 10, false);
#line 18 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Shared\RecipeViewing.cshtml"
       Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(332, 74, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>PreparationTime</th>\r\n        <td>");
            EndContext();
            BeginContext(407, 21, false);
#line 22 "H:\WebApp_Agmt3\COMP229_MamadouDiallo_Assignment02\COMP229_MamadouDiallo_Assignment02\Views\Shared\RecipeViewing.cshtml"
       Write(Model.PreparationTime);

#line default
#line hidden
            EndContext();
            BeginContext(428, 34, true);
            WriteLiteral(" minutes</td>\r\n    </tr>\r\n</table>");
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
