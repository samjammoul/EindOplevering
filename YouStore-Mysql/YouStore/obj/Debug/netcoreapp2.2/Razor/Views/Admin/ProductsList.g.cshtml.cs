#pragma checksum "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57201e2c36e750d7347d188363ba7457a5302544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductsList), @"mvc.1.0.view", @"/Views/Admin/ProductsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ProductsList.cshtml", typeof(AspNetCore.Views_Admin_ProductsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57201e2c36e750d7347d188363ba7457a5302544", @"/Views/Admin/ProductsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
  
    ViewData["Title"] = "ProductsList";
    Layout = "~/Views/Shared/_AdminView.cshtml";

#line default
#line hidden
            BeginContext(136, 969, true);
            WriteLiteral(@"<style>
    * {
        box-sizing: border-box;
    }

    #myInput {
        background-image: url('/css/searchicon.png');
        background-position: 10px 10px;
        background-repeat: no-repeat;
        width: 100%;
        font-size: 16px;
        padding: 12px 20px 12px 40px;
        border: 1px solid #ddd;
        margin-bottom: 12px;
    }

    #myTable {
        border-collapse: collapse;
        width: 100%;
        border: 1px solid #ddd;
        font-size: 18px;
    }

        #myTable th, #myTable td {
            text-align: left;
            padding: 12px;
        }

        #myTable tr {
            border-bottom: 1px solid #ddd;
        }

            #myTable tr.header, #myTable tr:hover {
                background-color: #f1f1f1;
            }
</style>

<h2>ProductsList</h2>
<input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for names.."" title=""Type in a name"">
<p>
    ");
            EndContext();
            BeginContext(1105, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57201e2c36e750d7347d188363ba7457a53025445165", async() => {
                BeginContext(1155, 10, true);
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
            BeginContext(1169, 81, true);
            WriteLiteral("\r\n</p>\r\n<table id=\"myTable\">\r\n    <tr class=\"header\">\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1251, 47, false);
#line 52 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1342, 54, false);
#line 55 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1440, 48, false);
#line 58 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1532, 47, false);
#line 61 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductCode));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1623, 51, false);
#line 64 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1718, 52, false);
#line 67 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
       Write(Html.DisplayNameFor(model => model.Productimagelink));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 62, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 73 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1881, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1942, 46, false);
#line 77 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2056, 53, false);
#line 80 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2177, 47, false);
#line 83 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(2224, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2292, 46, false);
#line 86 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductCode));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2406, 50, false);
#line 89 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuantityInStock));

#line default
#line hidden
            EndContext();
            BeginContext(2456, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2524, 51, false);
#line 92 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Productimagelink));

#line default
#line hidden
            EndContext();
            BeginContext(2575, 109, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <span type=\"button\" title=\"Edit\" value=\" \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2684, "\"", 2784, 3);
            WriteAttributeValue("", 2694, "location.href=\'/Admin/EditProductInformatie/", 2694, 44, true);
#line 95 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
WriteAttributeValue("", 2738, Html.DisplayFor(modelItem => item.ProductId), 2738, 45, false);

#line default
#line hidden
            WriteAttributeValue("", 2783, "\'", 2783, 1, true);
            EndWriteAttribute();
            BeginContext(2785, 114, true);
            WriteLiteral(">Edit</span> |\r\n                    <span class=\"glyphicon glyphicon-trash\" type=\"button\" title=\"Delete\" value=\" \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2899, "\"", 3001, 3);
            WriteAttributeValue("", 2909, "location.href=\'/Admin/DeletProduct/ProductId?=", 2909, 46, true);
#line 96 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
WriteAttributeValue("", 2955, Html.DisplayFor(modelItem => item.ProductId), 2955, 45, false);

#line default
#line hidden
            WriteAttributeValue("", 3000, "\'", 3000, 1, true);
            EndWriteAttribute();
            BeginContext(3002, 52, true);
            WriteLiteral("></span>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 99 "C:\Users\Sam\Desktop\S2 software\YouStore-Mysql\YouStore\Views\Admin\ProductsList.cshtml"
        }

#line default
#line hidden
            BeginContext(3065, 616, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
function myFunction() {
  var input, filter, table, tr, td, i, txtValue;
  input = document.getElementById(""myInput"");
  filter = input.value.toUpperCase();
  table = document.getElementById(""myTable"");
  tr = table.getElementsByTagName(""tr"");
  for (i = 0; i < tr.length; i++) {
    td = tr[i].getElementsByTagName(""td"")[0];
    if (td) {
      txtValue = td.textContent || td.innerText;
      if (txtValue.toUpperCase().indexOf(filter) > -1) {
        tr[i].style.display = """";
      } else {
        tr[i].style.display = ""none"";
      }
    }
  }
}
</script>");
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
