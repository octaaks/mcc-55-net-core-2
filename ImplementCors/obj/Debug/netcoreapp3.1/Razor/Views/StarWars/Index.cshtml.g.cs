#pragma checksum "F:\OAX\DOC\_Project\NETCore2\NETCore\NETCore\ImplementCors\Views\StarWars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c87a923299c0d0d21b253caffeba83d125db0be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_Index), @"mvc.1.0.view", @"/Views/StarWars/Index.cshtml")]
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
#line 1 "F:\OAX\DOC\_Project\NETCore2\NETCore\NETCore\ImplementCors\Views\_ViewImports.cshtml"
using ImplementCors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\OAX\DOC\_Project\NETCore2\NETCore\NETCore\ImplementCors\Views\_ViewImports.cshtml"
using ImplementCors.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c87a923299c0d0d21b253caffeba83d125db0be", @"/Views/StarWars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43793de8ec3e89ecacd12908e57073eb5edd501", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/starwars.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\OAX\DOC\_Project\NETCore2\NETCore\NETCore\ImplementCors\Views\StarWars\Index.cshtml"
  
    ViewData["Title"] = "Star Wars";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c87a923299c0d0d21b253caffeba83d125db0be4328", async() => {
                WriteLiteral("\r\n    <title>Title</title>\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU\" crossorigin=\"anonymous\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c87a923299c0d0d21b253caffeba83d125db0be4844", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c87a923299c0d0d21b253caffeba83d125db0be6726", async() => {
                WriteLiteral(@"
    <div class=""container"">

        <div class=""row mt-5 mb-3"">
            <div class=""col-2"">
                <span><img class=""top-img"" src=""https://i.kym-cdn.com/entries/icons/original/000/029/079/hellothere.jpg"" alt=""General Kenobi"" /></span>
            </div>
            <div class=""col-10"">
                <h3 id=""judul"" style=""font-family: 'Star Jedi'; text-align:start;"">""Hello There""</h3>
            </div>
        </div>
        <div class=""card shadow p-3 mt-3 p-lg-3"">
            <table class=""table table-striped table-hover table-bordered"">
                <thead class=""table-dark"">
                    <tr>
                        <th scope=""col"">No</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Gender</th>
                        <th scope=""col"">Height</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody id=""swapi"">
                </tbody>
    ");
                WriteLiteral(@"        </table>
        </div>

        <!-- Modal 1-->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    <div id=""modal-content"" class=""modal-body"">

                        <div class=""row"">
                            <div class=""col-3"">
                                <div>Name</div>
                                <div>Gender</div>
                                <div>Height</div>
                                <div>Mass</div>
                                <div>Hair Color</div>
                             ");
                WriteLiteral(@"   <div>Skin Color</div>
                                <div>Birth Year</div>
                            </div>
                            <div class=""col-1"">
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                                <div>:</div>
                            </div>
                            <div class=""col-8"">
                                <div id=""modal-data""></div>
                            </div>
                        </div>

                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
");
                WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

        <!-- Modal 2-->
        <div class=""modal fade"" id=""filmsModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""filmModalLabel"">Modal title</h5>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    <div id=""modal-content"" class=""modal-body"">
                        <ul>
                            <li id=""filmList""></li>
                        </ul>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
");
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
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
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/moment-with-locales.min.js"" integrity=""sha512-LGXaggshOkD/at6PFNcp2V2unf9LzFq6LE+sChH7ceMTDP0g2kn6Vxwgg7wkPP7AAtX+lmPqPdxB47A0Nz0cMQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script>
    //show all data into table
    $.ajax({
        url: ""https://swapi.dev/api/people/""
    }).done((result) => {
        var text = """";
        $.each(result.results, function (key, val) {
            text += `<tr>
                <td>${key + 1}</td>
                <td>${val.name}</td>
                <td>${val.gender}</td>
                <td>${val.height} cm</td>
                <td>
                    <button type=""button"" onclick=""");
            WriteLiteral(@"show('${val.url}')"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                      Details
                    </button>
                    <button type=""button"" onclick=""film('${val.url}')"" class=""btn btn-success"" data-bs-toggle=""modal"" data-bs-target=""#filmsModal"">
                      Films
                    </button>
                </td>
            </tr>`
        });
        $(""#swapi"").html(text);
    }).fail((result) => {
        console.log(result);
    });

    //show char info
    function show(charUrl) {
        $.ajax({
            url: charUrl
        }).done((result) => {
            var text = """";
            text += `<div>${result.name}</div>
            <div>${result.gender}</div>
            <div>${result.height}</div>
            <div>${result.mass}</div>
            <div>${result.hair_color}</div>
            <div>${result.skin_color}</div>
            <div>${result.birth_year}</div>
        `
            console.log(re");
            WriteLiteral(@"sult);

            $(""#modal-data"").html(text);
            $(""#exampleModalLabel"").html(result.name + ""'s Profile"");
        }).fail((result) => {
            console.log(result);
        });
    }

    //show char's films
    function film(url) {
        $.ajax({
            url: url
        }).done((result) => {
            var text = """";

            for (let i = 0; i < result.films.length; i++) {
                $.getJSON(result.films[i], function (data) {
                    console.log(data);
                    text += `<li><a href=""${result.films[i]}""> ${data.title} </a> - Release date : ${moment(data.release_date, ""YYYY"")}</li>`;
                    $(""#filmList"").html(text);
                });
            }

            $(""#filmModalLabel"").html(result.name + ""'s Films"");

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
