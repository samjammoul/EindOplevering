#pragma checksum "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba36fc0fe44be0a5d6c3fbd3346b1fe0e6fde2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Youtuber_ShowYoutuberProducts), @"mvc.1.0.view", @"/Views/Youtuber/ShowYoutuberProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Youtuber/ShowYoutuberProducts.cshtml", typeof(AspNetCore.Views_Youtuber_ShowYoutuberProducts))]
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
#line 1 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\_ViewImports.cshtml"
using YouStore;

#line default
#line hidden
#line 2 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\_ViewImports.cshtml"
using YouStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ba36fc0fe44be0a5d6c3fbd3346b1fe0e6fde2a", @"/Views/Youtuber/ShowYoutuberProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Youtuber_ShowYoutuberProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Product>>
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
#line 3 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
  
    ViewData["Title"] = "ShowYoutuberProducts";
    Layout = "~/Views/Shared/_LayoutClient.cshtml";

#line default
#line hidden
            BeginContext(147, 624, true);
            WriteLiteral(@"
<h2>Products</h2>

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
#line 42 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(804, 24, true);
            WriteLiteral("<div class=\"card\">\r\n    ");
            EndContext();
            BeginContext(828, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ba36fc0fe44be0a5d6c3fbd3346b1fe0e6fde2a5369", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 838, "~/images/", 838, 9, true);
#line 45 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
AddHtmlAttributeValue("", 847, Html.DisplayFor(modelItem => item.Productimagelink), 847, 52, false);

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
            BeginContext(938, 10, true);
            WriteLiteral("\r\n    <h1>");
            EndContext();
            BeginContext(949, 46, false);
#line 46 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(995, 29, true);
            WriteLiteral("</h1>\r\n    <p class=\"price\">$");
            EndContext();
            BeginContext(1025, 47, false);
#line 47 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
                 Write(Html.DisplayFor(modelItem => item.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(1086, 53, false);
#line 48 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
  Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(1660, 78, true);
            WriteLiteral("   \r\n    <button type=\"button\" class=\"btn btn-danger glyphicon glyphicon-plus\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1738, "\"", 1827, 3);
            WriteAttributeValue("", 1748, "location.href=\'/ShoppingBasket/AddProductsToShoppingBasket/id?=", 1748, 63, true);
#line 56 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
WriteAttributeValue("", 1811, item.ProductId, 1811, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1826, "\'", 1826, 1, true);
            EndWriteAttribute();
            BeginContext(1828, 20, true);
            WriteLiteral("></button>\r\n</div>\r\n");
            EndContext();
#line 58 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\ShowYoutuberProducts.cshtml"
        }

#line default
#line hidden
            BeginContext(1859, 8, true);
            WriteLiteral("\r\n    \r\n");
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
