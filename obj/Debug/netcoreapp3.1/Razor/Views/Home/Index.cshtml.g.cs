#pragma checksum "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16fd94637e2ef8a574f2a2ea03f5dd72f41581b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\_ViewImports.cshtml"
using DetailsPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\_ViewImports.cshtml"
using DetailsPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd94637e2ef8a574f2a2ea03f5dd72f41581b1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585022fa09537bd1e04b34769543cdb1a0975b5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsPage.Models.Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .button {\r\n");
            WriteLiteral("width: 100%;\r\n        border: none;\r\n        padding: 1rem 0rem;\r\n    }\r\n\r\n    .button:focus {\r\n        outline: none;\r\n        border-bottom: 1px solid blue;\r\n    }\r\n</style>\r\n\r\n<div class=\"center\">\r\n    <h1>");
#nullable restore
#line 21 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
   Write(Model.Year.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"font-size: 1.2rem\">");
#nullable restore
#line 21 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
                                                                            Write(Model.Version);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </h1>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 574, "\"", 598, 1);
#nullable restore
#line 22 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
WriteAttributeValue("", 580, Model.CarImageUrl, 580, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 599, "\"", 605, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"80%\">\r\n    <p style=\"font-size: 1.4rem; color: gray; font-weight: bold; margin: .8rem 0rem .2rem 0rem\">Owner\'s Comment</p>\r\n    <div style=\"border: 1px solid lightgray; padding: .2rem .4rem;background-color: white;\">\r\n        ");
#nullable restore
#line 25 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
   Write(Model.OwnerComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div style=""margin: 1rem 0; border: .5px solid lightgray"">
        <div style=""display: flex; flex: 1 1 auto; justify-content: space-evenly;"">
            <button class=""button"" id=""overviewButton"">Overview</button>
            <button class=""button"" id=""featuresButton"">Features</button>
            <button class=""button"" id=""specifiactionButton"">Specification</button>
        </div>
        <div id=""detailsPanel"">
");
#nullable restore
#line 34 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
              
                foreach (var prop in @Model.GetType().GetProperties())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"display: flex; padding: .8rem .5rem;\">\r\n                        <p style=\"width: 50%;margin:0;\">");
#nullable restore
#line 38 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
                                                   Write(prop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin:0;\">");
#nullable restore
#line 39 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
                                        Write(prop.GetValue(@Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <hr style=\"margin: 0;\" />\r\n");
#nullable restore
#line 42 "C:\Users\suraj\Desktop\training\day3-sep11\DetailsPage\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsPage.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
