#pragma checksum "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89869051bcb9e13854dc3b28b8302297725460c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingBasket_ProductsList), @"mvc.1.0.view", @"/Views/ShoppingBasket/ProductsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingBasket/ProductsList.cshtml", typeof(AspNetCore.Views_ShoppingBasket_ProductsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89869051bcb9e13854dc3b28b8302297725460c", @"/Views/ShoppingBasket/ProductsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingBasket_ProductsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
  
    ViewData["Title"] = "ProductsList";
    Layout = "~/Views/Shared/_LayoutClient.cshtml";

#line default
#line hidden
            BeginContext(139, 36, true);
            WriteLiteral("\r\n<h2>ProductsList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(175, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e89869051bcb9e13854dc3b28b8302297725460c4074", async() => {
                BeginContext(198, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(212, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(305, 47, false);
#line 17 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(352, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 54, false);
#line 20 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(462, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(518, 48, false);
#line 23 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(566, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(622, 47, false);
#line 26 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductCode));

#line default
#line hidden
            EndContext();
            BeginContext(669, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(725, 51, false);
#line 29 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityInStock));

#line default
#line hidden
            EndContext();
            BeginContext(776, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(832, 52, false);
#line 32 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Productimagelink));

#line default
#line hidden
            EndContext();
            BeginContext(884, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1002, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1051, 46, false);
#line 41 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1153, 53, false);
#line 44 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1262, 47, false);
#line 47 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1365, 46, false);
#line 50 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductCode));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1467, 50, false);
#line 53 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantityInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1573, 51, false);
#line 56 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Productimagelink));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1680, 65, false);
#line 59 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1766, 71, false);
#line 60 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1858, 69, false);
#line 61 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Sam\Documents\GitHub\EindOplevering\YouStore-Local databse\YouStore\Views\ShoppingBasket\ProductsList.cshtml"
}

#line default
#line hidden
            BeginContext(1966, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
