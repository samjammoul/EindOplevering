#pragma checksum "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec359e1084620a92aa2affa12ff00f51416d979e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\_ViewImports.cshtml"
using YouStore;

#line default
#line hidden
#line 2 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\_ViewImports.cshtml"
using YouStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec359e1084620a92aa2affa12ff00f51416d979e", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Denim Jeans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 605, true);
            WriteLiteral(@"
<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        max-width: 300px;
        margin: auto;
        text-align: center;
        font-family: arial;
    }

    .price {
        color: grey;
        font-size: 22px;
    }

    .card button {
        border: none;
        outline: 0;
        padding: 12px;
        color: white;
        background-color: #000;
        text-align: center;
        cursor: pointer;
        width: 100%;
        font-size: 18px;
    }

        .card button:hover {
            opacity: 0.7;
        }
</style>



");
            EndContext();
#line 41 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            BeginContext(765, 32, true);
            WriteLiteral("    <div class=\"card\">\r\n        ");
            EndContext();
            BeginContext(797, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec359e1084620a92aa2affa12ff00f51416d979e5218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 807, "~/images/", 807, 9, true);
#line 45 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
AddHtmlAttributeValue("", 816, Html.DisplayFor(modelItem => item.Productimagelink), 816, 52, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(907, 14, true);
            WriteLiteral("\r\n        <h1>");
            EndContext();
            BeginContext(922, 46, false);
#line 46 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
       Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(968, 33, true);
            WriteLiteral("</h1>\r\n        <p class=\"price\">$");
            EndContext();
            BeginContext(1002, 47, false);
#line 47 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
                     Write(Html.DisplayFor(modelItem => item.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(1067, 53, false);
#line 48 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
      Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 24, true);
            WriteLiteral("</p>\r\n        <p><button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1144, "\"", 1200, 3);
            WriteAttributeValue("", 1154, "location.href=\'", 1154, 15, true);
#line 49 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"
WriteAttributeValue("", 1169, Url.Action("Login", "Client"), 1169, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 1199, "\'", 1199, 1, true);
            EndWriteAttribute();
            BeginContext(1201, 39, true);
            WriteLiteral(">Add to Cart</button></p>\r\n    </div>\r\n");
            EndContext();
#line 51 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\Home\Home.cshtml"

}

#line default
#line hidden
            BeginContext(1245, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
            BeginContext(1965, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591