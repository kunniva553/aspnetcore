#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0587249e6e0b7ba4e1efc463f58577d5d0b6ae2"
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(null, typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel_cshtml), null)]
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
#line 4 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel_cshtml : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-offset-2 col-md-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
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
        private global::DivTagHelper __DivTagHelper = null;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(381, 75, true);
            WriteLiteral("\r\n<h1>New Customer</h1>\r\n<form method=\"post\" class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(456, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            __tagHelperExecutionContext.Add(__DivTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(487, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(493, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                BeginContext(517, 48, true);
                WriteLiteral("\r\n        <label class=\"col-md-2 control-label\">");
                EndContext();
                BeginContext(566, 4, false);
#line 25 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
                                         Write(Name);

#line default
#line hidden
                EndContext();
                BeginContext(570, 18, true);
                WriteLiteral("</label>\r\n        ");
                EndContext();
                BeginContext(588, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                    BeginContext(611, 101, true);
                    WriteLiteral("\r\n            <input class=\"form-control\" />\r\n            <span class=\"text-danger\"></span>\r\n        ");
                    EndContext();
                }
                );
                __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
                __tagHelperExecutionContext.Add(__DivTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(718, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            __tagHelperExecutionContext.Add(__DivTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(730, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(736, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                BeginContext(760, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(770, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                    BeginContext(809, 83, true);
                    WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        ");
                    EndContext();
                }
                );
                __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
                __tagHelperExecutionContext.Add(__DivTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(898, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            __tagHelperExecutionContext.Add(__DivTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(910, 11, true);
            WriteLiteral("\r\n</form>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
            
    public IActionResult OnPost(Customer customer)
    {
        Name = customer.Name;
        return Redirect("~/customers/inlinepagemodels/");
    }

    public string Name { get; set; }

    public class Customer
    {
        public string Name { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel_cshtml> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel_cshtml> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel_cshtml>)PageContext?.ViewData;
        public TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel_cshtml Model => ViewData.Model;
    }
}
