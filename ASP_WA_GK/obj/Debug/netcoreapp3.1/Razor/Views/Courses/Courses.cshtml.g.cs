#pragma checksum "C:\Users\5cepr\Desktop\Projekti_GK\Stuff\ASP_WA_GK\ASP_WA_GK\Views\Courses\Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a35e79ac183a8bde63479d131c03e0deb19531"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Courses), @"mvc.1.0.view", @"/Views/Courses/Courses.cshtml")]
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
#line 1 "C:\Users\5cepr\Desktop\Projekti_GK\Stuff\ASP_WA_GK\ASP_WA_GK\Views\_ViewImports.cshtml"
using ASP_WA_GK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\5cepr\Desktop\Projekti_GK\Stuff\ASP_WA_GK\ASP_WA_GK\Views\_ViewImports.cshtml"
using ASP_WA_GK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a35e79ac183a8bde63479d131c03e0deb19531", @"/Views/Courses/Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4969c6156a6e4dd0badf4e5c1375d127f10bee", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Courses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("unos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\5cepr\Desktop\Projekti_GK\Stuff\ASP_WA_GK\ASP_WA_GK\Views\Courses\Courses.cshtml"
  
    ViewBag.Title = "Courses";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Kolegiji</h2>\r\n<table>\r\n    <thead id=\"table-head\"></thead>\r\n    <tbody id=\"table-body\"></tbody>\r\n</table>\r\n\r\n<br /><br />\r\n\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6a35e79ac183a8bde63479d131c03e0deb195313979", async() => {
                WriteLiteral(@"
          <label>ID kolegija: </label>
          <input type=""text"" id=""id"" value=""11""/>
          <br />
          <label>ISVU kolegija: </label>
          <input type=""text"" id=""isvu"" value=""11""/>
          <br />
          <label>Ime kolegija: </label>
          <input type=""text"" id=""ime"" value=""aaa""/>
          <br />
          <label>Kratko ime kolegija: </label>
          <input type=""text"" id=""krime"" value=""aaa""/>
          <br />
          <label>Razina kolegija: </label>
          <input type=""text"" id=""razina"" value=""aaa""/>
          <br />
          <label>ECTS kolegija: </label>
          <input type=""text"" id=""ects"" value=""12""/>
          <br />
          <label>Odjel: </label>
          <input type=""text"" id=""odjel"" value=""aaa""/>
          <br />
          <input id=""savebtn"" type=""button"" value=""save"" onclick=""save()"" />
      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script type=""text/javascript"">
    'use strict';

    function appendTableHead(single) {

        let header = domHelper.createTableHeader(single);
        let thead = document.getElementById('table-head');
        thead.appendChild(header);
    }

    function appendToTable(data){

        let rows = data.map(x => domHelper.createTableRow(x));
        let tableBody = document.getElementById('table-body');

        appendTableHead(data[0]);

        for(let row of rows){
            tableBody.appendChild(row);
        }
    }

    function save() {
        var id = document.getElementById(""id"").value;
        var isvu = document.getElementById(""isvu"").value;
        var ime = document.getElementById(""ime"").value;
        var krime = document.getElementById(""krime"").value;
        var razina = document.getElementById(""razina"").value;
        var ects = document.getElementById(""ects"").value;
        var odjel = document.getElementById(""odjel"").value;
        var obj = new Obje");
            WriteLiteral(@"ct();
        obj = {
            ""ID"": id,
            ""ISVU"": isvu,
            ""name"": ime,
            ""sname"": krime,
            ""level"": razina,
            ""ECTS"": ects,
            ""department"": odjel
        };
        var str = ""Ala brate!""

        //var xhttp = new XMLHttpRequest();
        //xhttp.onreadystatechange = function () {
        //    if (this.readyState == 4 && this.status == 200) {
        //        console.log(""Poslano!"");
        //    }
        //};
        //xhttp.open(""POST"", ""/api/courses"", true);
        //xhttp.send(str);

        //axios({
        //    method: ""post"",
        //    url: ""/api/courses"",
        //    data: ""aaa!"",
        //    header: { ""Content-type"": ""text/plain"", ""Accept"":""text/plain"" }
        //}).then(data => console.log(data));

        //$.ajax({
        //    type: ""POST"",
        //    url: ""/api/courses"",
        //    dataType: ""json"",
        //    contentType: ""application/json; charset=utf-8"",
        //    d");
            WriteLiteral(@"ata: JSON.stringify(obj),
        //    success: function (result) {
        //        alert(result.success); // result is an object which is created from the returned JSON
        //    },
        //});
    }

    axios.get('/api/courses').then(response => appendToTable(response.data));</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
