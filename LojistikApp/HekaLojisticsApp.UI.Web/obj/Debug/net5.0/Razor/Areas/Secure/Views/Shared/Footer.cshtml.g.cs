#pragma checksum "C:\git-repo\LojistikApp\HekaLojisticsApp.UI.Web\Areas\Secure\Views\Shared\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf351a6459e8bc67a8c3c598319c24adafb99ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Secure_Views_Shared_Footer), @"mvc.1.0.view", @"/Areas/Secure/Views/Shared/Footer.cshtml")]
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
#line 1 "C:\git-repo\LojistikApp\HekaLojisticsApp.UI.Web\Areas\Secure\Views\Shared\Footer.cshtml"
using HekaLojisticsApp.Core.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf351a6459e8bc67a8c3c598319c24adafb99ab", @"/Areas/Secure/Views/Shared/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Secure/Views/_ViewImports.cshtml")]
    public class Areas_Secure_Views_Shared_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"main-footer\">\r\n    <div class=\"float-right d-none d-sm-block\">\r\n        <b>Version: </b>");
#nullable restore
#line 4 "C:\git-repo\LojistikApp\HekaLojisticsApp.UI.Web\Areas\Secure\Views\Shared\Footer.cshtml"
                   Write(AppSetting.PRODUCT_VERSION);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <strong>");
#nullable restore
#line 6 "C:\git-repo\LojistikApp\HekaLojisticsApp.UI.Web\Areas\Secure\Views\Shared\Footer.cshtml"
       Write(AppSetting.CopyRightText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n</footer>");
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
