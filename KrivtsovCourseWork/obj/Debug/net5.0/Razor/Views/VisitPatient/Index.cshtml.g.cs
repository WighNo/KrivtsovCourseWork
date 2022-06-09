#pragma checksum "D:\RiderProjects\KrivtsovCourseWork\KrivtsovCourseWork\Views\VisitPatient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b426111866314528c92efc27dcf78b2c4a35090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VisitPatient_Index), @"mvc.1.0.view", @"/Views/VisitPatient/Index.cshtml")]
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
#line 1 "D:\RiderProjects\KrivtsovCourseWork\KrivtsovCourseWork\Views\_ViewImports.cshtml"
using KrivtsovCourseWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RiderProjects\KrivtsovCourseWork\KrivtsovCourseWork\Views\_ViewImports.cshtml"
using KrivtsovCourseWork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b426111866314528c92efc27dcf78b2c4a35090", @"/Views/VisitPatient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c534679a29fbcf50b36342bb4ab665076a84a6d", @"/Views/_ViewImports.cshtml")]
    public class Views_VisitPatient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DatabaseContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "VisitPatient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div xmlns=\"http://www.w3.org/1999/html\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b426111866314528c92efc27dcf78b2c4a350904235", async() => {
                WriteLiteral(@"
        <p/>
        <textarea type=""message"" style=""resize: none; margin-top: 30px"" class=""mt-3 me-3"" cols=""20"" rows=""1"" name=""secondName"" placeholder=""Фамилия пациента""></textarea>
        <textarea type=""message"" style=""resize: none"" class=""mt-3 me-3"" cols=""20"" rows=""1"" name=""firstName"" placeholder=""Имя пациента""></textarea>
        
        <p class=""mt-3""/>
        <p style=""margin-top: 20px""/>
        <text style=""font-size: 20px; margin-bottom: -10px; font-weight: lighter"">Диагноз</text>
        <p/>
        ");
#nullable restore
#line 13 "D:\RiderProjects\KrivtsovCourseWork\KrivtsovCourseWork\Views\VisitPatient\Index.cshtml"
   Write(Html.DropDownList("diagnosisId", Model.Diagnoses.ToList().Select(s => 
            new SelectListItem { Text = s.Name.ToString(), Value = s.Id.ToString() })));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n        \r\n        <p style=\"margin-top: 50px\"/>\r\n        <text style=\"font-size: 20px; margin-bottom: -10px; font-weight: lighter\">Лечащий врач</text>\r\n        <p/>\r\n        ");
#nullable restore
#line 19 "D:\RiderProjects\KrivtsovCourseWork\KrivtsovCourseWork\Views\VisitPatient\Index.cshtml"
   Write(Html.DropDownList("doctorId", Model.Doctors.ToList().Select(s => 
            new SelectListItem { Text = s.GetFullName().ToString(), Value = s.Id.ToString() })));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  
        
        <p class=""mt-3""/>
        <textarea type=""message"" style=""resize: none"" class=""mt-3 me-3"" cols=""25"" rows=""1"" name=""date"" placeholder=""Дата записи""></textarea>

        <p class=""mt-1""/>
        <input class=""btn btn-info mt-5"" type=""submit"" value=""Добавить запись""/>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DatabaseContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
