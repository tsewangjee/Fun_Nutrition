#pragma checksum "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\Home\Display_Percentage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ccb362827d463399b0b77142abac3b0610831f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display_Percentage), @"mvc.1.0.view", @"/Views/Home/Display_Percentage.cshtml")]
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
#line 1 "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\_ViewImports.cshtml"
using Fun_Nutrition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\_ViewImports.cshtml"
using Fun_Nutrition.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ccb362827d463399b0b77142abac3b0610831f2", @"/Views/Home/Display_Percentage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6a900ad99b02f55f7055a25c3fbde2734be4b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display_Percentage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\Home\Display_Percentage.cshtml"
  
    var percen = ViewBag.Percentage;

#line default
#line hidden
#nullable disable
            WriteLiteral("<center><h1><b>");
#nullable restore
#line 7 "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\Home\Display_Percentage.cshtml"
          Write(percen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h1></center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
