#pragma checksum "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "987315e555b55dbbeb094178e6d180113c039e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmiController1_Indexcate), @"mvc.1.0.view", @"/Views/AdmiController1/Indexcate.cshtml")]
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
#line 1 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\_ViewImports.cshtml"
using AppFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\_ViewImports.cshtml"
using AppFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"987315e555b55dbbeb094178e6d180113c039e28", @"/Views/AdmiController1/Indexcate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499d601515b3cfda8ff5ded057417a4f0556306d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmiController1_Indexcate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppFront.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
  
    ViewData["Title"] = "Indexcate";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Indexcate</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "987315e555b55dbbeb094178e6d180113c039e283926", async() => {
                WriteLiteral("Agregar una nueva categoria");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.ActionLink("EditCate", "EditCate", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 37 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
           Write(Html.ActionLink("Deletecate", "Deletecate", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController1\Indexcate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppFront.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591