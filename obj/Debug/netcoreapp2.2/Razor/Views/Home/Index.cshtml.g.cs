#pragma checksum "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff190adca1143f70aff8c20c6481b4357eb91e53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\_ViewImports.cshtml"
using MASCOTAAPP;

#line default
#line hidden
#line 2 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\_ViewImports.cshtml"
using MASCOTAAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff190adca1143f70aff8c20c6481b4357eb91e53", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15135008b2d231c9834a070b736cf2f52a0d51f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mascota>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 37, true);
            WriteLiteral("\r\n<h1>Mascotas para adopcion</h1>\r\n\r\n");
            EndContext();
            BeginContext(59, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff190adca1143f70aff8c20c6481b4357eb91e534398", async() => {
                BeginContext(97, 73, true);
                WriteLiteral("\r\n    Filtar por tipo mascota:\r\n    <select name=\"tipomascota\">\r\n        ");
                EndContext();
                BeginContext(170, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff190adca1143f70aff8c20c6481b4357eb91e534856", async() => {
                    BeginContext(188, 5, true);
                    WriteLiteral("Todos");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(202, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
         foreach (var t in (List<TipoMascota>)ViewBag.Tipos)
        {

#line default
#line hidden
                BeginContext(277, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(289, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff190adca1143f70aff8c20c6481b4357eb91e536639", async() => {
                    BeginContext(312, 8, false);
#line 11 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
                             Write(t.Nombre);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 11 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
               WriteLiteral(t.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(329, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(342, 44, true);
                WriteLiteral("    </select>\r\n    <button>Filtar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 17 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
 if(Model.Count == 0){

#line default
#line hidden
            BeginContext(421, 46, true);
            WriteLiteral("    <p>Aun no hay mascotas para adoptar.</p>\r\n");
            EndContext();
#line 19 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(470, 35, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    \r\n");
            EndContext();
#line 23 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
            BeginContext(543, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(556, 16, false);
#line 25 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
       Write(m.NombreTemporal);

#line default
#line hidden
            EndContext();
            BeginContext(572, 19, true);
            WriteLiteral("</h2>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 591, "\"", 604, 1);
#line 26 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
WriteAttributeValue("", 597, m.Foto, 597, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(605, 33, true);
            WriteLiteral(" width=\"300\">\r\n        <p>Tipo : ");
            EndContext();
            BeginContext(639, 13, false);
#line 27 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
             Write(m.Tipo.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(652, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 28 "C:\Users\LuisMauricio\Desktop\Copy of MASCOTAAPP\MASCOTAAPP\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(665, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mascota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
