#pragma checksum "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ac9f11980fa7f98c3f2b15bf1f93af3df825e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monumentos_Filters), @"mvc.1.0.view", @"/Views/Monumentos/Filters.cshtml")]
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
#line 1 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
using SpotGuru.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
using SpotGuru.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ac9f11980fa7f98c3f2b15bf1f93af3df825e5b", @"/Views/Monumentos/Filters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8c0e7b41259814f556f5c900a8a0333599360a", @"/Views/_ViewImports.cshtml")]
    public class Views_Monumentos_Filters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/geolocation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
  
    ViewData["Title"] = "Filters";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <link rel=\"stylesheet\" href=\"/css/customCheckBox.css\" />\r\n");
            WriteLiteral(@"
<h1>Monumentos</h1>

<br />
<h4>Search By Name</h4>
<div>
    <div class=""form-group"">
        <input id=""monumentName"" class=""form-control"" />
    </div>
    <button class=""button"" onclick=""SearchByName()"">Search</button>
</div>

<br />
<h4>Search with Filters</h4>
<div id=""FiltersList"">
");
#nullable restore
#line 25 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
      
        IEnumerable<Categorias> categorias = Enum.GetValues(typeof(Categorias)).Cast<Categorias>().OrderBy(cat => EnumExtensionMethods.GetDescription(cat));
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
     foreach (Categorias cat in categorias)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label class=\"checkBoxContainer\">");
#nullable restore
#line 31 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
                                    Write(EnumExtensionMethods.GetDescription(cat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=", 867, "", 875, 1);
#nullable restore
#line 32 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
WriteAttributeValue("", 871, cat, 871, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span class=\"checkmark\"></span>\r\n        </label>\r\n");
#nullable restore
#line 35 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
     if (Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a id=\"sortBool\" name=\"true\"></a>\r\n");
#nullable restore
#line 40 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a id=\"sortBool\" name=\"false\"></a>\r\n");
#nullable restore
#line 44 "C:\Users\Alexandr___of\Desktop\UM\Ano3\Semestre1\LI4\3ª fase\LI4-2022-Fase3\SpotGuru\SpotGuru\Views\Monumentos\Filters.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <button class=""button"" onclick=""SaveList()"">Search</button>

</div>

<script>
    var SaveList = function() {
        
        var arr = [];
        var commaSeparatedIds = """";

        $(""#FiltersList label input[type=checkbox]"").each(function (index,val){
            var id = $(val).attr(""Id"");
            var isChecked = $(""#"" + id).is("":checked"",true);
            if(isChecked){
                arr.push(id);
            }
        })

        if(arr.length != 0){
            commaSeparatedIds = arr.toString();
            var sort = document.getElementById(""sortBool"");
            const url = ""/Monumentos/ApplyFilters?FiltersList="" + commaSeparatedIds + ""&sortByDistance="" + $(sort).attr(""name"") + ""&"";
            addLocationToUrl(url);
        }
        else{
            const url = ""/Monumentos/Index?"";
            addLocationToUrl(url);
        }
    }

    var SearchByName = function(){
        const url = ""/Monumentos/SearchMonumentByName?name="" + document.getElem");
            WriteLiteral("entById(\"monumentName\").value + \"&\";\r\n        addLocationToUrl(url);\r\n    }\r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ac9f11980fa7f98c3f2b15bf1f93af3df825e5b8459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool> Html { get; private set; }
    }
}
#pragma warning restore 1591
