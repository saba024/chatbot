#pragma checksum "/Users/sabanaskidashvili/Projects/chatbot/Views/Menu/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094fecbd55c12155985a498277d67f14bd8cd4bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_List), @"mvc.1.0.view", @"/Views/Menu/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094fecbd55c12155985a498277d67f14bd8cd4bc", @"/Views/Menu/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c5823347231e04fd7d10b313891946f52844e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sabanaskidashvili/Projects/chatbot/Views/Menu/List.cshtml"
   Layout = "MenuLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Menu</h1>\n<h3>");
#nullable restore
#line 4 "/Users/sabanaskidashvili/Projects/chatbot/Views/Menu/List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<div class=\"row mt-5 mb-2\">\n");
#nullable restore
#line 7 "/Users/sabanaskidashvili/Projects/chatbot/Views/Menu/List.cshtml"
      
        foreach (Dish dish in Model.AllDishes)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sabanaskidashvili/Projects/chatbot/Views/Menu/List.cshtml"
       Write(Html.Partial("AllDish", dish));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sabanaskidashvili/Projects/chatbot/Views/Menu/List.cshtml"
                                          
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</div>\n\n");
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