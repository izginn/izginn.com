#pragma checksum "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3783b4f7af87aca4d9e9f65423e4aca56d743c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
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
#line 1 "C:\Users\izgin\source\repos\izginn\izginn\Views\_ViewImports.cshtml"
using izginn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\izgin\source\repos\izginn\izginn\Views\_ViewImports.cshtml"
using izginn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3783b4f7af87aca4d9e9f65423e4aca56d743c1a", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6643bb2356d9bb787655d01901c1da07b5b2f9f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ExperienceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""experience"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Experience</h2>
        </div>
        <div class=""col-md-6 justify-content-center mx-auto""> <!-- mx-auto ekledim -->
");
#nullable restore
#line 9 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card mb-3"" data-aos=""fade-left"" data-aos-delay=""400"">
                    <div class=""card-header px-3 py-2"">
                        <div class=""d-flex justify-content-between"">
                            <div>
                                <h3 class=""h5 mb-1"">");
#nullable restore
#line 15 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <div class=\"text-muted text-small\">");
#nullable restore
#line 16 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                              Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small>  ");
#nullable restore
#line 16 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                                                    Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></div>\r\n                            </div><img");
            BeginWriteAttribute("src", " src=\"", 877, "\"", 897, 1);
#nullable restore
#line 17 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
WriteAttributeValue("", 883, item.ImageUrl, 883, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" height=\"48\" alt=\"full stack\" />\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-body px-3 py-2\">\r\n                        <p>");
#nullable restore
#line 21 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
                      Write(item.Describtion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\izgin\source\repos\izginn\izginn\Views\Shared\Components\ExperienceList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n          ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591