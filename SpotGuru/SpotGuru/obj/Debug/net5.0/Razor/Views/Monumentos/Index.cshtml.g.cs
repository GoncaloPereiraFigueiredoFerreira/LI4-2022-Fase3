#pragma checksum "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe20a4bd215f6843b949924feccd43eced2e3b01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monumentos_Index), @"mvc.1.0.view", @"/Views/Monumentos/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
using SpotGuru.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe20a4bd215f6843b949924feccd43eced2e3b01", @"/Views/Monumentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8c0e7b41259814f556f5c900a8a0333599360a", @"/Views/_ViewImports.cshtml")]
    public class Views_Monumentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpotGuru.ViewModels.MonumentosView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Monumentos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Monuments</h1>\r\n\r\n<div>\r\n    Click ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe20a4bd215f6843b949924feccd43eced2e3b014753", async() => {
                WriteLiteral("<strong>here</strong>");
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
            WriteLiteral(" to choose filters! \r\n    <link rel=\"stylesheet\" href=\"/css/monumentDetails.css\" />\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
               Write(Html.DisplayName("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
               Write(Html.DisplayName("Rating"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
               Write(Html.DisplayName("Distance"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n    \r\n        <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"mon_miniature_section\">\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe20a4bd215f6843b949924feccd43eced2e3b018185", async() => {
#nullable restore
#line 37 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
                                                  WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
                   Write(Html.DisplayName(EnumExtensionMethods.GetDescription(item.Categoria)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
                   Write(Html.DisplayName(String.Format("{0:0.00}",item.Rating)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <img src=\"/images/misc/EstrelaReview.png\" height=\"20\" width=\"20\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
                   Write(Html.DisplayName(String.Format("{0:0.00} {1}",item.distanceToUser,"Km")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 50 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
                          
                            string imagePath = "/images/monuments/" + item.pathFoto;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"img_mon_miniature\"");
            BeginWriteAttribute("src", " src=", 1893, "", 1908, 1);
#nullable restore
#line 53 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
WriteAttributeValue("", 1898, imagePath, 1898, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Not Found\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpotGuru.ViewModels.MonumentosView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
