#pragma checksum "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d8f0747ccb5736fd7a50d1781e36252c05cd9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "/Users/sabanaskidashvili/Projects/chatbot/Views/_ViewImports.cshtml"
using chatbot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sabanaskidashvili/Projects/chatbot/Views/_ViewImports.cshtml"
using chatbot.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sabanaskidashvili/Projects/chatbot/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d8f0747ccb5736fd7a50d1781e36252c05cd9b", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742de54b4a4c31dd3a6400d58f1540bcee10f1a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<chatbot.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/raphael/raphael.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/morris.js/morris.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- Main content -->
<section class=""content"">
    <!-- Small boxes (Stat box) -->
    <div class=""row"">
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-aqua"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 11 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml"
                   Write(Model.dish_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <p>Dish</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-users""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-green"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 25 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml"
                   Write(Model.category_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px""></sup></h3>
                    <p>Categories</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-users""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-yellow"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 39 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml"
                   Write(Model.users_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <p>Users</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-person""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-red"">
                <div class=""inner"">
                    <h3>65</h3>
                    <p>This Month</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
    </div>
    <!-- /.row -->
    <!-- Main row -->
    <div class=""row"">
        <!-- Left col -->
        <section class=""col-lg-10 connectedSortable"">
            <!");
            WriteLiteral(@"-- Custom tabs (Charts with tabs)-->
            <!-- DONUT CHART -->
            <div class=""box box-danger"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Donut Chart</h3>
                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                    </div>
                </div>
                <div class=""box-body chart-responsive"">
                    <div class=""chart"" id=""sales-chart"" style=""height: 300px; position: relative;""></div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.nav-tabs-custom -->
        </section>
        <!-- /.Left col -->
        <!-- right col (We are only adding the ID to mak");
            WriteLiteral("e the widgets sortable)-->\n        <!-- right col -->\n    </div>\n    <!-- /.row (main row) -->\n</section>\n\n<!-- Morris.js charts -->\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d8f0747ccb5736fd7a50d1781e36252c05cd9b8405", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d8f0747ccb5736fd7a50d1781e36252c05cd9b9428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script>\n  $(function () {\n    \"use strict\";\n\n    var donut = new Morris.Donut({\n      element: \'sales-chart\',\n      resize: true,\n      colors: [\"#3c8dbc\", \"#f56954\", \"#00a65a\"],\n      data: [\n        {label: \"Registered Dish\", value: ");
#nullable restore
#line 108 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml"
                                     Write(Model.dish_count);

#line default
#line hidden
#nullable disable
            WriteLiteral("},\n        {label: \"Registered Categories\", value: ");
#nullable restore
#line 109 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml"
                                           Write(Model.category_count);

#line default
#line hidden
#nullable disable
            WriteLiteral("},\n        {label: \"Registered Users\", value: ");
#nullable restore
#line 110 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dashboard/Index.cshtml"
                                      Write(Model.users_count);

#line default
#line hidden
#nullable disable
            WriteLiteral("}\n      ],\n      hideHover: \'auto\'\n    });\n  });\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<chatbot.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
