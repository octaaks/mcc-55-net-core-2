#pragma checksum "F:\OAX\DOC\_Project\mcc-55-net-core-2\ImplementCors\Views\Persons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305b09dd2ec410c75c9418749abf25f45968643b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_Index), @"mvc.1.0.view", @"/Views/Persons/Index.cshtml")]
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
#line 1 "F:\OAX\DOC\_Project\mcc-55-net-core-2\ImplementCors\Views\_ViewImports.cshtml"
using ImplementCors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\OAX\DOC\_Project\mcc-55-net-core-2\ImplementCors\Views\_ViewImports.cshtml"
using ImplementCors.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305b09dd2ec410c75c9418749abf25f45968643b", @"/Views/Persons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43793de8ec3e89ecacd12908e57073eb5edd501", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fontawesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\OAX\DOC\_Project\mcc-55-net-core-2\ImplementCors\Views\Persons\Index.cshtml"
  
    ViewData["Title"] = "Persons API";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305b09dd2ec410c75c9418749abf25f45968643b4941", async() => {
                WriteLiteral("\r\n    <title>Title</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "305b09dd2ec410c75c9418749abf25f45968643b5231", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <!--load all styles -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305b09dd2ec410c75c9418749abf25f45968643b7138", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <h3 id=""judul"" style=""font-family: HACKED; text-align:start;"">Persons api</h3>
            </div>
            <div class=""col"">
                <button class=""btn btn-primary"" style=""float:right"" data-bs-toggle=""modal"" data-bs-target=""#registerModal"">Register <i class=""fas fa-plus ml-2""></i></button>
            </div>
        </div>

        <div class=""card shadow p-3 mt-3 p-lg-3"">
            <table id=""table_id"" class=""display"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>NO</th>
                        <th>NIK</th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Gender</th>
                        <th>Phone</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
");
                WriteLiteral("\n");
                WriteLiteral(@"        </div>

        <!-- Modal 1-->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    <div id=""modal-content"" class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-4 pl-5 font-weight-bold"">
                                <div>NIK</div>
                                <div>Name</div>
                                <div>Gender</div>
                                <div>Email</div>
                                <div>Phone</div>
                                <div>BirthD");
                WriteLiteral(@"ate</div>
                                <div>Salary</div>

                                <div>University</div>
                                <div>Degree</div>
                                <div>GPA</div>

                                <div>Roles</div>
                            </div>
                            <div class=""col-1"">
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                            </div>
                            <div class=""col-7"">
                                <div id=""modal-data""></div>
                 ");
                WriteLiteral("           </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Close</button>\r\n");
                WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

        <!-- Modal Register-->
        <div class=""modal fade"" id=""registerModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    <div id=""modal-content"" class=""modal-body"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305b09dd2ec410c75c9418749abf25f45968643b11729", async() => {
                    WriteLiteral(@"
                            <div class=""form-row"">
                                <div class=""col-md-4 mb-3"">
                                    <label for=""validationCustom01"">First name</label>
                                    <input type=""text"" class=""form-control"" id=""validationCustom01"" placeholder=""First name"" value=""Mark"" required>
                                    <div class=""valid-feedback"">
                                        Looks good!
                                    </div>
                                </div>
                                <div class=""col-md-4 mb-3"">
                                    <label for=""validationCustom02"">Last name</label>
                                    <input type=""text"" class=""form-control"" id=""validationCustom02"" placeholder=""Last name"" value=""Otto"" required>
                                    <div class=""valid-feedback"">
                                        Looks good!
                                    </div>
          ");
                    WriteLiteral(@"                      </div>
                                <div class=""col-md-4 mb-3"">
                                    <label for=""validationCustomUsername"">Username</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text"" id=""inputGroupPrepend""></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" id=""validationCustomUsername"" placeholder=""Username"" aria-describedby=""inputGroupPrepend"" required>
                                        <div class=""invalid-feedback"">
                                            Please choose a username.
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-row"">
    ");
                    WriteLiteral(@"                            <div class=""col-md-6 mb-3"">
                                    <label for=""validationCustom03"">City</label>
                                    <input type=""text"" class=""form-control"" id=""validationCustom03"" placeholder=""City"" required>
                                    <div class=""invalid-feedback"">
                                        Please provide a valid city.
                                    </div>
                                </div>
                                <div class=""col-md-3 mb-3"">
                                    <label for=""validationCustom04"">State</label>
                                    <input type=""text"" class=""form-control"" id=""validationCustom04"" placeholder=""State"" required>
                                    <div class=""invalid-feedback"">
                                        Please provide a valid state.
                                    </div>
                                </div>
                                <di");
                    WriteLiteral(@"v class=""col-md-3 mb-3"">
                                    <label for=""validationCustom05"">Zip</label>
                                    <input type=""text"" class=""form-control"" id=""validationCustom05"" placeholder=""Zip"" required>
                                    <div class=""invalid-feedback"">
                                        Please provide a valid zip.
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox""");
                    BeginWriteAttribute("value", " value=\"", 8771, "\"", 8779, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" id=""invalidCheck"" required>
                                    <label class=""form-check-label"" for=""invalidCheck"">
                                        Agree to terms and conditions
                                    </label>
                                    <div class=""invalid-feedback"">
                                        You must agree before submitting.
                                    </div>
                                </div>
                            </div>
                            <button class=""btn btn-primary"" type=""submit"">Submit form</button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Close</button>\r\n");
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script src=""https://code.jquery.com/jquery-3.2.1.min.js""></script>
<script>

    $(document).ready(function () {

        var mt = $('#table_id').DataTable({
            ""columnDefs"": [{
                ""targets"": 0,
                ""searchable"": false,
                ""orderable"": false
            }],
            ""order"": [[1, 'asc']],
            ""filter"": true,
            ""ajax"": {
                ""url"": ""https://localhost:44300/api/persons/getperson"",
                ""datatype"": ""json"",
                ""dataSrc"": ""result""
            },
            ""columns"": [
                { ""data"": null },
                { ""data"": ""nik"" },
                { ""data"": ""fullName"" },
                { ""data"": ""email"" },
                {
                    ""data"": ""gender"",
                    ""render"": function (data, type, row) {
                        if (data == ""Male"") {
                            return data + ' <i class=""fas fa-mars""></i>';
                        } els");
            WriteLiteral(@"e {
                            return data + ' <i class=""fas fa-venus""></i>';
                        }
                    }
                },
                {
                    ""data"": ""phone"",
                    ""render"": function (data, type, row) {

                        return '(+62)' + data.slice(1, 99);
                    },
                    ""autoWidth"": true
                },
                {
                    ""data"": ""nik"",
                    ""render"": function (data, type, row) {

                        return '<button class=""btn btn-primary"" onclick=""show(' + data + ')"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal""> Details </button>';
                    },
                    ""autoWidth"": true
                }
            ]
        });

        mt.on('order.dt search.dt', function () {
            mt.column(0, { search: 'applied', order: 'applied' }).nodes().each(function (cell, i) {
                cell.innerHTML = i + 1;
            });
  ");
            WriteLiteral(@"      }).draw();

    });

    //show all data into table

    //$.ajax({
    //    url: ""https://localhost:44300/api/persons/""
    //}).done((result) => {
    //    var text = """";

    //    console.log(result);
    //    $.each(result.data, function (key, val) {
    //        text += `<tr>
    //            <td>${key + 1}</td>
    //            <td>${val.nik}</td>
    //            <td>${val.firstName + "" "" + val.lastName}</td>
    //            <td>${val.email}</td>
    //            <td>${val.gender}</td>
    //            <td>${val.phone}</td>
    //            <td>
    //                <button type=""button"" onclick=""show('https://localhost:44300/api/persons/${val.nik}')"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
    //                  Details
    //                </button>
    //            </td>
    //        </tr>`
    //    });
    //    $(""#swapi"").html(text);
    //}).fail((result) => {
    //    console.log(result);
    //});
");
            WriteLiteral(@"
    $.ajax({
        url: ""https://localhost:44300/api/persons/getperson""
    }).done((result) => {
        console.log(result);
    }).fail((result) => {
        console.log(result);
    });

    //show char infobirt
    function show(nik) {
        $.ajax({
            url: ""https://localhost:44300/api/persons/"" + nik
        }).done((result) => {

            var roles = """";
            console.log(result);

            for (let i = 0; i < result.data.account.accountRoles.length; i++) {
                roles += `<li>${result.data.account.accountRoles[i].role.name}</li>`;
            }

            var genderIcon = """";
            if (result.data.gender == ""Male"") {
                genderIcon = ' <i class=""fas fa-mars""></i>';
            } else {
                genderIcon = ' <i class=""fas fa-venus""></i>';
            }

            var text = """";
            text += `
            <div>${result.data.nik}</div>
            <div>${result.data.firstName + "" "" + result.data.last");
            WriteLiteral(@"Name}</div>
            <div>${result.data.gender} ${genderIcon}</div>
            <div>${result.data.email}</div>
            <div>(+62)${result.data.phone.slice(1, 99)}</div>
            <div>${moment(result.data.birthDate).format(""dddd, MMMM Do YYYY"")}</div>
            <div>Rp. ${result.data.salary.toLocaleString('it-IT')}</div>
            <div>${result.data.account.profiling.educations.universities.name}</div>
            <div>${result.data.account.profiling.educations.degree}</div>
            <div>${result.data.account.profiling.educations.gpa}</div>
            <div><ul>${roles}</ul></div>
        `
            $(""#modal-data"").html(text);
            $(""#exampleModalLabel"").html(result.data.firstName + "" "" + result.data.lastName + ""'s Profile"");
        }).fail((result) => {
            console.log(result);
        });
    }

</script>");
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
