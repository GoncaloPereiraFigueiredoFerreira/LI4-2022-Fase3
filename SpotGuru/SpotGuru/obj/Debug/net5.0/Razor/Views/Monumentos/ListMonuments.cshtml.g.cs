#pragma checksum "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36e923274993c3a324c1b0d63e5488d93d66afb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monumentos_ListMonuments), @"mvc.1.0.view", @"/Views/Monumentos/ListMonuments.cshtml")]
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
#line 1 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
using SpotGuru.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e923274993c3a324c1b0d63e5488d93d66afb8", @"/Views/Monumentos/ListMonuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8c0e7b41259814f556f5c900a8a0333599360a", @"/Views/_ViewImports.cshtml")]
    public class Views_Monumentos_ListMonuments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpotGuru.ViewModels.MonumentosView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div>\r\n    <link rel=\"stylesheet\" href=\"/css/monumentDetails.css\" />\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
               Write(Html.DisplayName("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
               Write(Html.DisplayName("Rating"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
               Write(Html.DisplayName("Distance"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
               Write(Html.DisplayName("Photo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n    \r\n        <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36e923274993c3a324c1b0d63e5488d93d66afb86245", async() => {
#nullable restore
#line 33 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
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
#line 33 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
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
#line 36 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
                   Write(Html.DisplayName(EnumExtensionMethods.GetDescription(item.Categoria)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
                   Write(Html.DisplayName(String.Format("{0:0.00}",item.Rating)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <img src=\"/images/misc/EstrelaReview.png\" height=\"20\" width=\"20\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
                   Write(Html.DisplayName(String.Format("{0:0.00} {1}",item.distanceToUser,"Km")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 46 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
                          
                            string imagePath = "/images/monuments/" + item.pathFoto;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <img class=\"img_min\"");
            BeginWriteAttribute("src", " src=", 1728, "", 1743, 1);
#nullable restore
#line 49 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
WriteAttributeValue("", 1733, imagePath, 1733, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Not Found\" /> \r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Acer\Source\Repos\GoncaloPereiraFigueiredoFerreira\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\ListMonuments.cshtml"
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
