#pragma checksum "D:\Backup Projects\Himserve\Himserve\Views\Services\_TheRhinoService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1bebc978aa188aa805bb480e21056c32dcfab20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services__TheRhinoService), @"mvc.1.0.view", @"/Views/Services/_TheRhinoService.cshtml")]
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
#line 1 "D:\Backup Projects\Himserve\Himserve\Views\_ViewImports.cshtml"
using Himserve;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Backup Projects\Himserve\Himserve\Views\_ViewImports.cshtml"
using Himserve.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bebc978aa188aa805bb480e21056c32dcfab20", @"/Views/Services/_TheRhinoService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead45d7d20ea3ee54046b9564ab6c6f0904993df", @"/Views/_ViewImports.cshtml")]
    public class Views_Services__TheRhinoService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-muted"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-service", "emergency-relief-service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Backup Projects\Himserve\Himserve\Views\Services\_TheRhinoService.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "The Rhino Ambulance Emergency Relief Service";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""slider-area"" style=""background-image: url('/assets/img/hero/emergency-medical-services-banner.png')"">
    <div class=""slider-active"">
        <div class=""single-slider slider-height d-flex align-items-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-6 col-lg-6 col-md-8 col-sm-10"">
                        <ul class=""breadcrumb bg-white"">
                            <li class=""breadcrumb-item""><a class=""text-muted""");
            BeginWriteAttribute("href", " href=\"", 631, "\"", 649, 1);
#nullable restore
#line 12 "D:\Backup Projects\Himserve\Himserve\Views\Services\_TheRhinoService.cshtml"
WriteAttributeValue("", 638, Href("~/"), 638, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1bebc978aa188aa805bb480e21056c32dcfab205595", async() => {
                WriteLiteral("Emergency Relief Services");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-service", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["service"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        </ul>
                        <div class=""hero__caption"">
                            <h1 data-animation=""fadeInUp"" data-delay="".6s"">The Rhino Ambulance<br />Service</h1>
                            <P data-animation=""fadeInUp"" data-delay="".8s"">
                                The Rhino is stationed in Barbote in Nimbong  under Kalimpong District. The vehicle is used for transports
                                of sick people for their higher level check ups, care, diagnosis in nearby cities. 
                                It is available for 24X7 days.
                            </P>
                            <div class=""hero__btn"">
                                <a href=""#section-more"" class=""btn hero-btn mb-10"" data-animation=""fadeInLeft"" data-delay="".8s"">Read more &rsaquo;</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
<div ");
            WriteLiteral(@"id=""section-more"" class=""service-area pt-70 bg-white"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-6 col-lg-7 col-md-10 col-sm-10"">
                <!-- Section Tittle -->
                <div class=""section-tittle text-center mb-80"">
                    <span>About the Service</span>
                    <h2>The Rhino</h2>
                </div>
            </div>
        </div>
        <div class=""row"">

            <div class=""col-md-8"">
                <div class=""text-left mb-50"">

                    <p>
                        Purna nimbly pilots The Rhino along the roughest roads in our area of service while Suren (who trained as as an EMT at Navjeevan Hospital) provides patient care. To reach the Subdivisional Hospital in Kalimpong, it is a 3-4 hour drive (one way) on washed out cobblestone roads. Mobile/Cellular service in the area is weak as well further complicating the logistics of providing high quality service to th");
            WriteLiteral(@"e region. Despite these obstacles Purna and Suren are always at the ready to respond to a community member in need. When not out on a call, Suren assists at a Dispensary run by the Cluny Sisters.
                        In this spirit of cooperation the Sisters have opened up their facility in return to serve as our ambulance station.
                    </p>

                </div>
            </div>
            <div class=""col-md-4"">
                <img class=""img-fluid"" src=""/assets/img/gallery/ers/Purna Tamang.jpg"" />

            </div>
            <div class=""clearfix""></div>
            <div class=""col-md-12"">
                <iframe class=""w-100"" height=""420"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" src=""https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=26.966907,88.562096&amp;aq=0&amp;oq=nimbong&amp;sll=26.96683,88.56092&amp;sspn=0.01136,0.01929&amp;t=h&amp;g=26.966907,88.562096&amp;ie=UTF8&amp;ll=26.966907,88.562096&amp;spn=0.01136,0.019");
            WriteLiteral("29&amp;z=14&amp;output=embed\"></iframe>\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n</div>");
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
