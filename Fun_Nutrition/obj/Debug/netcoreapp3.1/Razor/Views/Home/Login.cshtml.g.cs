#pragma checksum "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e963bb92e5be60ba45cb90e217b3f709dbeb179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e963bb92e5be60ba45cb90e217b3f709dbeb179", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6a900ad99b02f55f7055a25c3fbde2734be4b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Local\Fun_Nutrition\Fun_Nutrition\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Nutrition";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
        function Login()
        {
        var myTextField = ""be back"";
        alert(myTextField);
        }
        function SignUp()
        {
        var myTextField = ""not yet"";
        alert(myTextField);
        }
</script>
<table>
    <tr>
        <tr>
        <td> Have an Account? </td>
    </tr>
    <tr>
        <td>
            email 
        </td>
        <td>
            <input type=""text""/>
        </td>
    </tr>
     <tr>
        <td>
            password
        </td>
        <td>
            <input type=""text""/>
        </td>
    </tr>
    <tr><td><button type=""button"" onclick=""Login()"" >Login</button></td></tr>
    </tr>
    <tr>
        <td> Create Account? </td>
    </tr>
    <tr>
        <td>
            Name 
        </td>
        <td>
            <input type=""text""/>
        </td>
    </tr>
    <tr>
        <td>
            email 
        </td>
        <td>
            <input type=""text""/>
        </td>");
            WriteLiteral(@"
    </tr>
     <tr>
        <td>
            password
        </td>
        <td>
            <input type=""password""/>
        </td>
    </tr><tr>
        <td>
            Confirm Password
        </td>
        <td>
            <input type=""password""/>
        </td>
    </tr>
    <tr><td><button type=""button"" onclick=""SignUp()"" onkeypress=""signup()"">Sign Up</button></td></tr>
</table>
");
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