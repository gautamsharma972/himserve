#pragma checksum "D:\Backup Projects\Himserve\Himserve\Views\Home\Donate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16be8ada552204ac69726cba787c73012339113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Donate), @"mvc.1.0.view", @"/Views/Home/Donate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16be8ada552204ac69726cba787c73012339113", @"/Views/Home/Donate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead45d7d20ea3ee54046b9564ab6c6f0904993df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Donate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Backup Projects\Himserve\Himserve\Views\Home\Donate.cshtml"
  
    ViewData["Title"] = "Donate";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""service-area pt-70 bg-white"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-sm-12"">
                <!-- Section Tittle -->
                <div class=""section-tittle text-left mb-80"">
                    <span>Donate</span>

                    <h2>Donation for supporting Projects</h2>
                    <p>
                        <span class=""text-muted"">*All Debit/Credit Cards accepted</span><br />
                        <span class=""text-muted"">*All Payment Merchants Available</span>
                        <br />
                        <span class=""text-danger"">*Please click on the button below to proceed with the donations.</span>
                    </p>
                    <div class=""razorpay-embed-btn"" data-url=""https://rzp.io/l/zQwuYEB"" data-text=""Pay Now"" data-color=""#528FF0"" data-size=""large"">
                        <script>
                            (function () {
                                var");
            WriteLiteral(@" d = document; var x = !d.getElementById('razorpay-embed-btn-js')
                                if (x) {
                                    var s = d.createElement('script'); s.defer = !0; s.id = 'razorpay-embed-btn-js';
                                    s.src = 'https://cdn.razorpay.com/static/embed_btn/bundle.js'; d.body.appendChild(s);
                                } else {
                                    var rzp = window['__rzp__'];
                                    rzp && rzp.init && rzp.init()
                                }
                            })();
                        </script>
                        <iframe src=""https://cdn.razorpay.com/static/embed_btn/embed.html?url=https%3A%2F%2Frzp.io%2Fl%2FzQwuYEB&amp;text=Pay%20Now&amp;color=%23528FF0&amp;size=large&amp;referrer=http%3A%2F%2Fhimserve.org%2Fdonate.html""
                                scrolling=""no"" frameborder=""0"" width=""270"" height=""100""></iframe>
                    </div>
                </div>
     ");
            WriteLiteral(@"       </div>
             <div class=""col-sm-12"">
                 <h3>Global Donations to:</h3>
                 <p>
                     Account Name : Him Serve Society<br />
                     Account Num : 12391000016712<br />
                     Name of Bank : HDFC Bank<br />
                     Branch : Siliguri<br />
                     Bank Address : Hill Cart Road, PO Siliguri, India, PIN 734003
                     <br />
                     Swift Code : HDFCINBBCAL<br />
                     NEFT IFSC/RTGS/ No : HDFC0001239
                     <br />
                     (Eligible to receive global donations under FCRA Act)
                 </p>
                 <hr />
                 <h3>Indian Donations to:</h3>
                 <p>
                     Account Name : Him Serve Society<br />
                     Account Num : 12391450000019<br />
                     Name of Bank : HDFC Bank<br />
                     Branch : Siliguri<br />
                     Ba");
            WriteLiteral(@"nk address : Hill Cart Road, Siliguri<br />
                     Swift Code : HDFCINBBCAL<br />
                     NEFT IFSC/RTGS/ No : HDFC0001239<br />

                     (Indian donations are tax exempted under 80 G of Income Tax Act)
                 </p>
                 <hr />
                 <h3>Cheque Payable to:</h3>
                 <p>
                     ""Him Serve Society""<br />
                     19/A Nivedita Road Bylane,<br />
                     PO Pradhan Nagar, Siliguri,<br />
                     India - 734003<br />
                 </p>
                 <hr />
                 <p>
                     FOR ANY QUERIES, PLEASE CONTACT TO:<br />
                     The Executive Director (Mr. Puran Rai)<br />
                     Mobile: +91 9434380752<br />
                     Phone: +91 353 2514104<br />
                     Email: himserve@gmail.com<br />
                     Site: www.himserve.org<br />
                 </p>
             </div>
      ");
            WriteLiteral("  </div>\r\n        <div class=\"clearfix\"></div>\r\n\r\n    </div>\r\n</div>");
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