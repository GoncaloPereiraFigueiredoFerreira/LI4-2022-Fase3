#pragma checksum "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d778ad17bdaf0fe100d495b9c3922130ee756c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monumentos_Details), @"mvc.1.0.view", @"/Views/Monumentos/Details.cshtml")]
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
#line 1 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\_ViewImports.cshtml"
using SpotGuru;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\_ViewImports.cshtml"
using SpotGuru.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d778ad17bdaf0fe100d495b9c3922130ee756c9", @"/Views/Monumentos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8c0e7b41259814f556f5c900a8a0333599360a", @"/Views/_ViewImports.cshtml")]
    public class Views_Monumentos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpotGuru.Models.Monumentos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFavorito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Monumentos</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descrição));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descrição));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt> \r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class = \"col-sm-10\">\r\n");
#nullable restore
#line 45 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
              var url = "https://www.google.com/maps/place/" + Model.Latitude +","+ Model.Longitude;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=", 1420, "", 1430, 1);
#nullable restore
#line 46 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
WriteAttributeValue("", 1426, url, 1426, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Obter direções</a>\r\n        </dd>\r\n        <h4>Reviews</h4>\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
           Write(Html.DisplayName("Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
           Write(Html.DisplayName("Classificacao"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
           Write(Html.DisplayName("Comentario"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
 foreach (var item in Model.Reviews) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
           Write(Html.DisplayFor(m => item.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
           Write(Html.DisplayFor(m => item.Classificacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
           Write(Html.DisplayFor(m => item.Comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d778ad17bdaf0fe100d495b9c3922130ee756c911920", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d778ad17bdaf0fe100d495b9c3922130ee756c914108", async() => {
                WriteLiteral("Add Favorite");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Details.cshtml"
                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d778ad17bdaf0fe100d495b9c3922130ee756c916311", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpotGuru.Models.Monumentos> Html { get; private set; }
    }
}
#pragma warning restore 1591
