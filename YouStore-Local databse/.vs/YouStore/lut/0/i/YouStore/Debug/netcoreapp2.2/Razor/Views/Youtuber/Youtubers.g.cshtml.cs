#pragma checksum "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3129fc702f032b6c81eb98f1972b772586a3029"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Youtuber_Youtubers), @"mvc.1.0.view", @"/Views/Youtuber/Youtubers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Youtuber/Youtubers.cshtml", typeof(AspNetCore.Views_Youtuber_Youtubers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3129fc702f032b6c81eb98f1972b772586a3029", @"/Views/Youtuber/Youtubers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Youtuber_Youtubers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Youtuber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Youtuber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddYoutuber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
  
    ViewData["Title"] = "Youtubers";
    Layout = "~/Views/Shared/_AdminView.cshtml";

#line default
#line hidden
            BeginContext(134, 33, true);
            WriteLiteral("\r\n<h2>Youtubers</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(167, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3129fc702f032b6c81eb98f1972b772586a30294258", async() => {
                BeginContext(221, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(328, 48, false);
#line 17 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
           Write(Html.DisplayNameFor(model => model.YoutuberName));

#line default
#line hidden
            EndContext();
            BeginContext(376, 68, true);
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(445, 49, false);
#line 21 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
           Write(Html.DisplayNameFor(model => model.YoutuberImage));

#line default
#line hidden
            EndContext();
            BeginContext(494, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(612, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(661, 47, false);
#line 30 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
           Write(Html.DisplayFor(modelItem => item.YoutuberName));

#line default
#line hidden
            EndContext();
            BeginContext(708, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(764, 48, false);
#line 33 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
           Write(Html.DisplayFor(modelItem => item.YoutuberImage));

#line default
#line hidden
            EndContext();
            BeginContext(812, 97, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span type=\"button\" title=\"Edit\" value=\" \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 909, "\"", 1014, 3);
            WriteAttributeValue("", 919, "location.href=\'/Youtuber/EditYoutuberInformatie/", 919, 48, true);
#line 36 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
WriteAttributeValue("", 967, Html.DisplayFor(modelItem => item.YoutuberId), 967, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 1013, "\'", 1013, 1, true);
            EndWriteAttribute();
            BeginContext(1015, 110, true);
            WriteLiteral(">Edit</span> |\r\n                <span class=\"glyphicon glyphicon-trash\" type=\"button\" title=\"Delete\" value=\" \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1125, "\"", 1233, 3);
            WriteAttributeValue("", 1135, "location.href=\'/YouTuber/DeletYoutuber/YoutuberId?=", 1135, 51, true);
#line 37 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
WriteAttributeValue("", 1186, Html.DisplayFor(modelItem => item.YoutuberId), 1186, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 1232, "\'", 1232, 1, true);
            EndWriteAttribute();
            BeginContext(1234, 44, true);
            WriteLiteral("></span>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Sam\Desktop\S2 software\YouStore-Local databse\YouStore\Views\Youtuber\Youtubers.cshtml"
}

#line default
#line hidden
            BeginContext(1281, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Youtuber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
