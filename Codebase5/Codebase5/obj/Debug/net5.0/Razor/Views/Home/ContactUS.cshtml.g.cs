#pragma checksum "C:\Projects\Codebase5\Codebase5\Views\Home\ContactUS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e272d077ce79a2d71c31fd22f91680d9e8f606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUS), @"mvc.1.0.view", @"/Views/Home/ContactUS.cshtml")]
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
#line 1 "C:\Projects\Codebase5\Codebase5\Views\_ViewImports.cshtml"
using Codebase5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Codebase5\Codebase5\Views\_ViewImports.cshtml"
using Codebase5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e272d077ce79a2d71c31fd22f91680d9e8f606", @"/Views/Home/ContactUS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3ec05ac7da3ba796a8529ff9430ebd1ed088c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ContactUS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\Codebase5\Codebase5\Views\Home\ContactUS.cshtml"
  
    ViewData["Title"] = "Contact Us ";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Projects\Codebase5\Codebase5\Views\Home\ContactUS.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <label style=""color:red"">
        Enter Your Name:
    </label>
    <br />
    <input type=""text"" />
    <br />
    <label style=""color:red"">
        Enter Your Number:
    </label>
    <br />
    <input type=""text"" />
    <br />
    <label style=""color:green"">
        Reason to Contact Us
    </label>
    <br />
    <textarea style=""height:200px "">

    </textarea>
    <br />
    <input type=""submit"" style=""border-color :green"" />

</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591