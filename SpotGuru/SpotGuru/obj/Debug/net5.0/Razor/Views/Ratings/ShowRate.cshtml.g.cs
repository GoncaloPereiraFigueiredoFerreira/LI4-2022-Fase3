#pragma checksum "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b167618638575016db228e009048aa5cb943e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ratings_ShowRate), @"mvc.1.0.view", @"/Views/Ratings/ShowRate.cshtml")]
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
#line 1 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\_ViewImports.cshtml"
using SpotGuru;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\_ViewImports.cshtml"
using SpotGuru.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b167618638575016db228e009048aa5cb943e30", @"/Views/Ratings/ShowRate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8c0e7b41259814f556f5c900a8a0333599360a", @"/Views/_ViewImports.cshtml")]
    public class Views_Ratings_ShowRate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpotGuru.ViewModels.RatingUserPlusGlobalView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
  
    ViewData["Title"] = "ShowRate";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rate Us</h1>\r\n<hr />\r\n<div>\r\n    <h4>App Rating: ");
#nullable restore
#line 11 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
               Write(String.Format("{0:0.00}",@Model.RatingGlobal));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <img src=\"/images/misc/EstrelaReview.png\" height=\"20\" width=\"20\" alt=\"Not Found\" /> </h4> \r\n    <hr />\r\n</div>\r\n<div>\r\n    <link rel=\"stylesheet\" href=\"/css/ratings.css\" />\r\n    <h4>Your Rating</h4>\r\n    <div class=\"stars_section\">\r\n");
#nullable restore
#line 18 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
         if (Model.RatingUser == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"stars_1\"></div>\r\n");
#nullable restore
#line 21 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
        }
        else if (Model.RatingUser == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"stars_2\"></div>\r\n");
#nullable restore
#line 25 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
        }
        else if (Model.RatingUser == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"stars_3\"></div>\r\n");
#nullable restore
#line 29 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
        }
        else if (Model.RatingUser == 4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"stars_4\"></div>\r\n");
#nullable restore
#line 33 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"stars_5\"></div>\r\n");
#nullable restore
#line 37 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n    <br />\r\n    Changed your mind? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b167618638575016db228e009048aa5cb943e306496", async() => {
                WriteLiteral("Click here");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Ratings\ShowRate.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpotGuru.ViewModels.RatingUserPlusGlobalView> Html { get; private set; }
    }
}
#pragma warning restore 1591
