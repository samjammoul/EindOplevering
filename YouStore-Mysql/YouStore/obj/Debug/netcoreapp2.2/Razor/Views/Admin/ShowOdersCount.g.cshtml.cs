#pragma checksum "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb43816fb6befb7c68188c9609b39170fe03dca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowOdersCount), @"mvc.1.0.view", @"/Views/Admin/ShowOdersCount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ShowOdersCount.cshtml", typeof(AspNetCore.Views_Admin_ShowOdersCount))]
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
#line 1 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\_ViewImports.cshtml"
using YouStore;

#line default
#line hidden
#line 2 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\_ViewImports.cshtml"
using YouStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb43816fb6befb7c68188c9609b39170fe03dca2", @"/Views/Admin/ShowOdersCount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowOdersCount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Product>>
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
#line 3 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
  
    ViewData["Title"] = "ShowOdersCount";
    Layout = "~/Views/Shared/_AdminView.cshtml";

#line default
#line hidden
            BeginContext(138, 38, true);
            WriteLiteral("\r\n<h2>ShowOdersCount</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(176, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb43816fb6befb7c68188c9609b39170fe03dca23939", async() => {
                BeginContext(199, 10, true);
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
            BeginContext(213, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(306, 47, false);
#line 17 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(353, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(409, 48, false);
#line 20 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderedTimes));

#line default
#line hidden
            EndContext();
            BeginContext(457, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(575, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(624, 46, false);
#line 29 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(670, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(726, 47, false);
#line 32 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderedTimes));

#line default
#line hidden
            EndContext();
            BeginContext(773, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ShowOdersCount.cshtml"
}

#line default
#line hidden
            BeginContext(812, 24, true);
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