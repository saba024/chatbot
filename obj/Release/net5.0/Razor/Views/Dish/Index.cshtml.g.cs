#pragma checksum "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6537ec093347bc2a5948de0d785cf85d880f23ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Index), @"mvc.1.0.view", @"/Views/Dish/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6537ec093347bc2a5948de0d785cf85d880f23ec", @"/Views/Dish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c5823347231e04fd7d10b313891946f52844e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<chatbot.Models.Dish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Dish</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Category</th>
                                <th>Name</th>
                                <th>Description</th>
                                <th>Img</th>
                                <th>Price</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 29 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 30 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 31 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 32 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 33 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Img));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 34 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1639, "\"", 1666, 2);
            WriteAttributeValue("", 1646, "Dish/Update/", 1646, 12, true);
#nullable restore
#line 35 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
WriteAttributeValue("", 1658, item.Id, 1658, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a> | <a");
            BeginWriteAttribute("href", " href=\"", 1683, "\"", 1690, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1691, "\"", 1719, 3);
            WriteAttributeValue("", 1701, "Delete(\'", 1701, 8, true);
#nullable restore
#line 35 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
WriteAttributeValue("", 1709, item.Id, 1709, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1717, "\')", 1717, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n                                </tr>\n");
#nullable restore
#line 37 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\n                </div>\n                <!-- /.box-body -->\n            </div>\n            <!-- /.box -->\n        </div>\n        <!-- /.col -->\n    </div>\n    <!-- /.row -->\n</section>\n\n<!-- DataTables -->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6537ec093347bc2a5948de0d785cf85d880f23ec8403", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6537ec093347bc2a5948de0d785cf85d880f23ec9426", async() => {
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
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {

            $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 65 "/Users/sabanaskidashvili/Projects/chatbot/Views/Dish/Index.cshtml"
                 Write(Url.Action("Delete", "Dish"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Dish"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<chatbot.Models.Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
