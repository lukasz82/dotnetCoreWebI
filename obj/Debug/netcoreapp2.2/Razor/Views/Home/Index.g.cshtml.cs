#pragma checksum "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad4fff99caf32d1f06da8a2742630734ce785cc"
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
#line 2 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\_ViewImports.cshtml"
using dotnetCoreMVC.Models;

#line default
#line hidden
#line 1 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
using dotnetCoreMVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad4fff99caf32d1f06da8a2742630734ce785cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebee243c44c74106d7899476e5e4c9f5f3adfbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReturnList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(94, 359, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <p>Moja pierwsza strona w dot net CORE !!!</p>
    <p>Utworzona za pomocą VS Code i konsoli windows ;) </p>
    <p>Poniżej wylistowane dane z przykładowego modelu: </p>
");
            EndContext();
#line 14 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#line 16 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
         foreach (var emails in item.emailList)
        {

#line default
#line hidden
            BeginContext(554, 41, true);
            WriteLiteral("            <div>\r\n                Email ");
            EndContext();
            BeginContext(596, 13, false);
#line 19 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                 Write(emails.mailId);

#line default
#line hidden
            EndContext();
            BeginContext(609, 39, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Wiadomosc ");
            EndContext();
            BeginContext(649, 14, false);
#line 20 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                     Write(emails.message);

#line default
#line hidden
            EndContext();
            BeginContext(663, 55, true);
            WriteLiteral(" &nbsp&nbsp\r\n                <br>\r\n            </div>\r\n");
            EndContext();
#line 23 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(731, 17, true);
            WriteLiteral("        <p></p>\r\n");
            EndContext();
#line 26 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
         foreach (var persons in item.personList)
        {

#line default
#line hidden
            BeginContext(810, 40, true);
            WriteLiteral("            <div>\r\n                Imię ");
            EndContext();
            BeginContext(851, 12, false);
#line 29 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                Write(persons.name);

#line default
#line hidden
            EndContext();
            BeginContext(863, 38, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Nazwisko ");
            EndContext();
            BeginContext(902, 15, false);
#line 30 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                    Write(persons.surname);

#line default
#line hidden
            EndContext();
            BeginContext(917, 38, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Id osoby ");
            EndContext();
            BeginContext(956, 16, false);
#line 31 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                    Write(persons.personId);

#line default
#line hidden
            EndContext();
            BeginContext(972, 55, true);
            WriteLiteral(" &nbsp&nbsp\r\n                <br>\r\n            </div>\r\n");
            EndContext();
#line 34 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1040, 17, true);
            WriteLiteral("        <p></p>\r\n");
            EndContext();
#line 37 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
         foreach (var authors in item.authors)
        {

#line default
#line hidden
            BeginContext(1116, 38, true);
            WriteLiteral("            <div>\r\n                Id ");
            EndContext();
            BeginContext(1155, 16, false);
#line 40 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
              Write(authors.AuthorId);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 34, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Imię ");
            EndContext();
            BeginContext(1206, 17, false);
#line 41 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                Write(authors.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 38, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Nazwisko ");
            EndContext();
            BeginContext(1262, 16, false);
#line 42 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                    Write(authors.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 55, true);
            WriteLiteral(" &nbsp&nbsp\r\n                <br>\r\n            </div>\r\n");
            EndContext();
#line 45 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1344, 25, true);
            WriteLiteral("                <p></p>\r\n");
            EndContext();
#line 47 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
         foreach (var list in item.booksAndAuthors)
        {

#line default
#line hidden
            BeginContext(1433, 38, true);
            WriteLiteral("            <div>\r\n                Id ");
            EndContext();
            BeginContext(1472, 13, false);
#line 50 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
              Write(list.AuthorId);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 34, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Imię ");
            EndContext();
            BeginContext(1520, 14, false);
#line 51 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                Write(list.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1534, 38, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Nazwisko ");
            EndContext();
            BeginContext(1573, 13, false);
#line 52 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                    Write(list.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1586, 44, true);
            WriteLiteral(" &nbsp&nbsp\r\n                Wydana książka ");
            EndContext();
            BeginContext(1631, 10, false);
#line 53 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
                          Write(list.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1641, 55, true);
            WriteLiteral(" &nbsp&nbsp\r\n                <br>\r\n            </div>\r\n");
            EndContext();
#line 56 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#line 56 "D:\programowanie\net Core apki\dotnetCoreMVC\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1714, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReturnList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
