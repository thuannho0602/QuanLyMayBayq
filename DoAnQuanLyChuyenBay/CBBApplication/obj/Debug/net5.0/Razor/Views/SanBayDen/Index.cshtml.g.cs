#pragma checksum "D:\NguyenMinhThuan\QLCB\DoAnQuanLyChuyenBay\CBBApplication\Views\SanBayDen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c7d5d3c8c87855a965c6283d52afd822aeb578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanBayDen_Index), @"mvc.1.0.view", @"/Views/SanBayDen/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c7d5d3c8c87855a965c6283d52afd822aeb578", @"/Views/SanBayDen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768bc34094c749601308b96d1a18a1cd53aa4e78", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SanBayDen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\NguyenMinhThuan\QLCB\DoAnQuanLyChuyenBay\CBBApplication\Views\SanBayDen\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"col-lg-12\">\n");
            WriteLiteral(@"        <button id=""themsanbayden"" type=""button"" style=""margin-bottom:10px"" class=""btn btn-success mb-1"" data-toggle=""modal"" data-target=""#themsanbaydenModal"" data-backdrop=""false"">
            Thêm Sân Bay Đến
        </button>
        <div class=""table-responsive table--no-card m-b-30"">

            <table class=""table table-borderless table-striped table-earning"">

                <thead>
                    <tr>
                        <th>
                            Id
                        </th>
                        <th>
                            Mã Sân Bay Đến
                        </th>
                        <th>
                            Tên Sân Bay Đến
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id=""getdatasanbaydenbody"">
                </tbody>
            </table>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""themsanbaydenModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""m");
            WriteLiteral(@"ediumModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""mediumModalLabel"">Thêm Sân Bay Đến</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card-body"">
                    <div class=""form-group has-success"">
                        <label for=""cc-name"" class=""control-label mb-1"">Mã Sân Bay Đến</label>
                        <input id=""themsanbayden_masanbayden"" name=""themsanbayden_masanbayden"" type=""text"" class=""form-control cc-name valid""");
            BeginWriteAttribute("value", " value=\"", 2173, "\"", 2181, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""form-group"">
                        <label for=""cc-number"" class=""control-label mb-1"">Tên sân bay đi</label>
                        <input id=""themsanbayden_tensanbayden"" name=""themsanbayden_tensanbayden"" type=""tel"" class=""form-control cc-number identified visa""");
            BeginWriteAttribute("value", " value=\"", 2507, "\"", 2515, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                <button id=""btnThemSanBayDen"" type=""button"" class=""btn btn-primary"">Thêm</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""editsanbaydenModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mediumModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""mediumModalLabel"">Sửa Sân Bay Đến</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card-body"">
                    <div class=""form-group h");
            WriteLiteral("as-success\">\n                        <label for=\"cc-name\" class=\"control-label mb-1\">ID</label>\n                        <input id=\"suasanbayden_id\" name=\"suasanbayden_id\" type=\"text\" class=\"form-control cc-name valid\"");
            BeginWriteAttribute("value", " value=\"", 3757, "\"", 3765, 0);
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group has-success"">
                        <label for=""cc-name"" class=""control-label mb-1"">Mã Sân Bay Đi</label>
                        <input id=""suasanbayden_masanbayden"" name=""suasanbayden_masanbayden"" type=""text"" class=""form-control cc-name valid""");
            BeginWriteAttribute("value", " value=\"", 4094, "\"", 4102, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""form-group"">
                        <label for=""cc-number"" class=""control-label mb-1"">Tên sân bay đi</label>
                        <input id=""suasanbayden_tensanbayden"" name=""suasanbayden_tensanbayden"" type=""tel"" class=""form-control cc-number identified visa""");
            BeginWriteAttribute("value", " value=\"", 4426, "\"", 4434, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                <button id=""btnSuaSanBayDen"" type=""button"" class=""btn btn-primary"">Sửa</button>
            </div>
        </div>
    </div>
</div>

<script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        var url = ""http://localhost:50947/api/"";
        GetData();
        function GetData() {
            $.ajax({
                type: ""GET"",
                url: url + ""SanBayDen"",
                data: $(""#getdatasanbaydenbody"").serialize(),
                success: function (data) {
                    $.each(data, function (index, value) {
                        $(""#getdatasanbaydenbody"").append(productBuildTableRow(value));
                    });
                },
     ");
            WriteLiteral(@"           error: function () { alert('error'); }
            });
        }
        function productBuildTableRow(item) {
            var ret =
                '<tr>'
                + '<td>' + item.id + '</td>'
                + '<td>' + item.code + '</td>'
                + '<td>' + item.tenSanBayDden + '</td>'
                + '<td style=""float:right"">'
                + '<button type=""button"" style=""margin-right: 10px;"" data-id=""' + item.id + '"" class=""btn btn-primary btn-sm filldataeditsanbayden"" data-toggle=""modal"" data-target=""#editsanbaydenModal"" data-backdrop=""false"">Sửa</button>'
                + '<button type=""button"" id=""deletesanbayden"" data-id=""' + item.id + '"" class=""btn btn-danger btn-sm deletesanbayden"" data-toggle=""modal"" data-target=""#deletesanbaydenModal"" data-backdrop=""false"">Xóa</button>'
                + '</td>'
                + '</tr>';

            return ret;
        }

        // Thêm sân bay đi
        $(""#themsanbayden"").click(function () {
            //$('#select').empty().a");
            WriteLiteral(@"ppend('<option data-id=""0"">Please select</option>');
            //GetLoai();
            $(""#themsanbayden_masanbayden"").val("""");
            $(""#themsanbayden_tensanbayden"").val("""");
        });

        $(""#btnThemSanBayDen"").click(function () {

            if ($(""#themsanbayden_masanbayden"").val() == """" || $(""#themsanbayden_tensanbayden"").val() == """") {
                //$.toast('Toast message to be shown');
                $.toast({
                    text: ""Mã hoặc tên sân bay đến không được rỗng"",
                    showHideTransition: 'slide',  // It can be plain, fade or slide
                    bgColor: 'red',              // Background color for toast
                    textColor: '#eee',            // text color
                    allowToastClose: false,       // Show the close button or not
                    hideAfter: 5000,              // `false` to make it sticky or time in miliseconds to hide after
                    stack: 5,                     // `fakse` to show one stack at a tim");
            WriteLiteral(@"e count showing the number of toasts that can be shown at once
                    textAlign: 'right',            // Alignment of text i.e. left, right, center
                    position: 'top-right'       // bottom-left or bottom-right or bottom-center or top-left or top-right or top-center or mid-center or an object representing the left, right, top, bottom values to position the toast on page
                })
                $('#themsanbaydenModal').modal().hide();
            }
            else {
                var mayBay = new Object();
                mayBay.Code = $(""#themsanbayden_masanbayden"").val();
                mayBay.TenSanBayDden = $(""#themsanbayden_tensanbayden"").val();
                //mayBay.MaLoai = $(""#select option:selected"").val();
                $.ajax(
                    {
                        type: ""POST"",
                        dataType: 'json',
                        contentType: ""application/json; charset=utf-8"",
                        url: url + ""SanBayDen"",
       ");
            WriteLiteral(@"                 data: JSON.stringify(mayBay),

                        success: function () {
                            location.reload();
                            $('#themsanbaydenModal').modal().hide();
                        },
                        failure: function (response) {
                            //
                        }

                    });
            }
        });

        //sua
        $(""#btnSuaSanBayDen"").click(function () {

            if ($(""#suasanbayden_tensanbayden"").val() == """") {
                //$.toast('Toast message to be shown');
                $.toast({
                    text: ""Tên sân bay đến không được rỗng"",
                    showHideTransition: 'slide',  // It can be plain, fade or slide
                    bgColor: 'red',              // Background color for toast
                    textColor: '#eee',            // text color
                    allowToastClose: false,       // Show the close button or not
                    hideAfter: 5000,      ");
            WriteLiteral(@"        // `false` to make it sticky or time in miliseconds to hide after
                    stack: 5,                     // `fakse` to show one stack at a time count showing the number of toasts that can be shown at once
                    textAlign: 'right',            // Alignment of text i.e. left, right, center
                    position: 'top-right'       // bottom-left or bottom-right or bottom-center or top-left or top-right or top-center or mid-center or an object representing the left, right, top, bottom values to position the toast on page
                })
                $('#editsanbaydenModal').modal().hide();
            }
            else {
                var sanbayden = new Object();
                sanbayden.Id = $(""#suasanbayden_id"").val();
                sanbayden.Code = $(""#suasanbayden_masanbayden"").val();
                sanbayden.TenSanBayDden = $(""#suasanbayden_tensanbayden"").val();//$(""#selectedit option:selected"").val();
                var Id = $(""#suasanbayden_id"").val();
");
            WriteLiteral(@"                $.ajax(
                    {
                        type: ""PUT"",
                        dataType: 'json',
                        contentType: ""application/json; charset=utf-8"",
                        url: url + ""SanBayDen/"" + Id,
                        data: JSON.stringify(sanbayden),

                        success: function () {
                            location.reload();
                            $('#editsanbaydenModal').modal().hide();
                        },
                        failure: function (response) {
                            //
                        }

                    });
            }
        });

        //delete
        $(document).on('click', '.deletesanbayden', function () {
            var Id = $(this).data('id');
            $.ajax({
                url: url + ""SanBayDen/"" + Id,
                type: ""DELETE"",
                contentType: ""application/json;charset=UTF-8"",
                dataType: ""json"",
                success: function (result");
            WriteLiteral(@") {
                    location.reload();
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        });

        //get by id
        $(document).on('click', '.filldataeditsanbayden', function () {
            var Id = $(this).data('id');
            $.ajax({
                url: url + ""SanBayDen/"" + Id,
                type: ""GET"",
                contentType: ""application/json;charset=UTF-8"",
                dataType: ""json"",
                success: function (result) {
                    $('#suasanbayden_id').val(result.id);
                    $('#suasanbayden_masanbayden').val(result.code);
                    $('#suasanbayden_tensanbayden').val(result.tenSanBayDden);
                    $('#editsanbaydenModal').modal('show');
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        });

    })");
            WriteLiteral("\n</script>\n\n");
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
