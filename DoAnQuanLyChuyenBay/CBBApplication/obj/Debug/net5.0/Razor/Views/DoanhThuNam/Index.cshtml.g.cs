#pragma checksum "D:\NguyenMinhThuan\QLCB\DoAnQuanLyChuyenBay\CBBApplication\Views\DoanhThuNam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88fce5bbe88e045d1aaeb84a35bbd62132f42fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoanhThuNam_Index), @"mvc.1.0.view", @"/Views/DoanhThuNam/Index.cshtml")]
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
#line 1 "D:\NguyenMinhThuan\QLCB\DoAnQuanLyChuyenBay\CBBApplication\Views\_ViewImports.cshtml"
using CBBApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NguyenMinhThuan\QLCB\DoAnQuanLyChuyenBay\CBBApplication\Views\_ViewImports.cshtml"
using CBBApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88fce5bbe88e045d1aaeb84a35bbd62132f42fe", @"/Views/DoanhThuNam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768bc34094c749601308b96d1a18a1cd53aa4e78", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DoanhThuNam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\NguyenMinhThuan\QLCB\DoAnQuanLyChuyenBay\CBBApplication\Views\DoanhThuNam\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h2 style=""margin-bottom:10px;"">Danh Thu Theo Năm</h2>
        <div class=""table-responsive table--no-card m-b-30"">

            <table class=""table table-borderless table-striped table-earning"">

                <thead>
                    <tr>
                        <th>
                            Tháng
                        </th>
                        <th>
                            Tên máy bay
                        </th>
                        <th>
                            Doanh Thu
                        </th>
                        <th>
                            Số Chuyến Bay
                        </th>
                    </tr>
                </thead>
                <tbody id=""getdatadoanhthunam"">
                </tbody>
            </table>
        </div>
    </div>
</div>


<script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>
<script type=""text/javascript"">
    $(docu");
            WriteLiteral(@"ment).ready(function () {
        var url = ""http://localhost:50947/api/"";
        GetData();
        function GetData() {
            var date = new Date();
            var nam = date.getFullYear();
            $.ajax({
                type: ""POST"",
                url: url + ""DatChoHanhKhach/GetBaoCaoDanhThuTheoNam/"" + nam,
                data: $(""#getdatadoanhthunam"").serialize(),
                success: function (data) {
                    $.each(data, function (index, value) {
                        $(""#getdatadoanhthunam"").append(productBuildTableRow(value));
                    });
                },
                error: function () { alert('error'); }
            });
        }
        function productBuildTableRow(item) {
            var ret =
                '<tr>'
                + '<td>' + item.thang + '</td>'
                + '<td>' + item.tenMayBay + '</td>'
                + '<td>' + item.doanhThu + '</td>'
                + '<td>' + item.soChuyenBay + '</td>'
                + '</tr>';

");
            WriteLiteral("            return ret;\n        }\n    })\n\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591