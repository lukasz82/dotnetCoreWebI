#pragma checksum "D:\programowanie\net Core apki\dotnetCoreMVC\Views\ArrayTest\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bafedb337cdf9f5d585b1716095b3bd976fdee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ArrayTest_Show), @"mvc.1.0.view", @"/Views/ArrayTest/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ArrayTest/Show.cshtml", typeof(AspNetCore.Views_ArrayTest_Show))]
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
#line 2 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\_ViewImports.cshtml"
using dotnetCoreMVC.Models;

#line default
#line hidden
#line 1 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\ArrayTest\Show.cshtml"
using dotnetCoreMVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bafedb337cdf9f5d585b1716095b3bd976fdee", @"/Views/ArrayTest/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebee243c44c74106d7899476e5e4c9f5f3adfbd", @"/Views/_ViewImports.cshtml")]
    public class Views_ArrayTest_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 467, true);
            WriteLiteral(@"<script src=""/lib/jquery/dist/jquery.min.js""></script>
<div id=""resultAjax""></div>
<script>
    var result = """";
    $.get('/ReturnJsonTest/1').done(function(query) 
    {
        console.log(query);
        for (var i = 0; i < query.length ; i++)
        {
            result = result + query[i].firstName + "" "" + query[i].lastName + "" - "" + query[i].title + ""<br />"";
        }
        $(""#resultAjax"").html(result);
    });
</script>

<br /><br />
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
