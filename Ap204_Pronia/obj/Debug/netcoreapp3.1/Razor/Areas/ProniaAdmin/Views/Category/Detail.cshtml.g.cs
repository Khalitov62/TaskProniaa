#pragma checksum "C:\Users\user\OneDrive\Masaüstü\TruePronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ceb64a3d350936d93d310a1fa172e1aefcca5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProniaAdmin_Views_Category_Detail), @"mvc.1.0.view", @"/Areas/ProniaAdmin/Views/Category/Detail.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Masaüstü\TruePronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Category\Detail.cshtml"
using Ap204_Pronia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ceb64a3d350936d93d310a1fa172e1aefcca5b", @"/Areas/ProniaAdmin/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54289a8a9cc2330d52892068f548cd18ef4ea07", @"/Areas/ProniaAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_ProniaAdmin_Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\OneDrive\Masaüstü\TruePronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Category\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div>\r\n        <h2>Id:  ");
#nullable restore
#line 8 "C:\Users\user\OneDrive\Masaüstü\TruePronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Category\Detail.cshtml"
            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n      \r\n    </div>\r\n    <div>\r\n         <h2>Name:   ");
#nullable restore
#line 12 "C:\Users\user\OneDrive\Masaüstü\TruePronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Category\Detail.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n       \r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
