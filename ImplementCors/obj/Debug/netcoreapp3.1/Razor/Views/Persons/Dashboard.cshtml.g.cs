#pragma checksum "F:\OAX\DOC\_Project\mcc-55-net-core-2\ImplementCors\Views\Persons\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e5e3a797c9ef811e0316bd23b0f1a2dfa73f891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_Dashboard), @"mvc.1.0.view", @"/Views/Persons/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5e3a797c9ef811e0316bd23b0f1a2dfa73f891", @"/Views/Persons/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43793de8ec3e89ecacd12908e57073eb5edd501", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fontawesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/persons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\OAX\DOC\_Project\mcc-55-net-core-2\ImplementCors\Views\Persons\Dashboard.cshtml"
  
    Layout = (string)ViewData["Layout"] ?? "_LayoutAdmin";
    ViewData["Title"] = "Persons API";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e5e3a797c9ef811e0316bd23b0f1a2dfa73f8914743", async() => {
                WriteLiteral("\r\n    <title>Title</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0e5e3a797c9ef811e0316bd23b0f1a2dfa73f8915033", async() => {
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
                WriteLiteral(" <!--load all styles -->\r\n    <!-- CSS Boostrap -->\r\n");
                WriteLiteral("    <!-- CSS Bootstrap Datepicker -->\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.8.0/css/bootstrap-datepicker.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e5e3a797c9ef811e0316bd23b0f1a2dfa73f8916478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e5e3a797c9ef811e0316bd23b0f1a2dfa73f8918360", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <div class=""card shadow p-3 mt-3 p-lg-3"">
                    <div id=""chartGender""></div>
                </div>
            </div>
            <div class=""col"">
                <div class=""card shadow p-3 mt-3 p-lg-3"">
                    <div id=""chartSalary""></div>
                </div>
            </div>
        </div>
    </div>
");
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
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.8.0/js/bootstrap-datepicker.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/apexcharts""></script>
<script>
    $(document).ready(function () {
        //gender
        var male = 0;
        var female = 0;

        //salary
        var gol1 = 0;
        var gol2 = 0;
        var gol3 = 0;
        var gol4 = 0;
        var gol5 = 0;

        $.ajax({
            url: ""https://localhost:44300/api/persons/""
        }).done((result) => {
            console.log(result);

            for (var i = 0; i < result.data.length; i++) {
                if (result.data[i].gender == ""Male"") {
                    male++;
                } else {
               ");
            WriteLiteral(@"     female++;
                }

                if (result.data[i].salary < 25000000) {
                    gol1++;
                } else if (result.data[i].salary < 50000000) {
                    gol2++;
                } else if (result.data[i].salary < 75000000) {
                    gol3++;
                } else if (result.data[i].salary < 100000000) {
                    gol4++;
                } else {
                    gol5++;
                }
            }
            console.log(gol1,gol2,gol3,gol4,gol5);

            var optionsGender = {
                series: [male, female],
                chart: {
                    type: 'pie',
                },
                labels: ['Male', 'Female'],
                responsive: [{
                    breakpoint: 480,
                    options: {
                        chart: {
                            width: 200
                        },
                        legend: {
                            position: ");
            WriteLiteral(@"'bottom'
                        }
                    }
                }],
                title: {
                    text: 'Gender Chart',
                    floating: true,
                    align: 'center',
                    style: {
                        color: '#444'
                    }
                }
            };

            var chartGender = new ApexCharts(document.querySelector(""#chartGender""), optionsGender);
            chartGender.render();

            var optionsSalary = {
                chart: {
                    type: 'column'
                },
                series: [{
                    name: 'sales',
                    data: [44, 1, 2, 4, 1]
                }],
                xaxis: {
                    categories: [1991, 1992, 1993, 1994, 1995],
                    //categories: [""< 25jt"", ""< 50jt"", ""< 75jt"", ""< 100jt"", ""100jt ++""]
                },
                yaxis: {
                    axisBorder: {
                        ");
            WriteLiteral(@"show: false
                    },
                    axisTicks: {
                        show: false,
                    }
                },
                title: {
                    text: 'Salary Chart',
                    floating: true,
                    align: 'center',
                    style: {
                        color: '#444'
                    }
                }
            };



            var options = {
                series: [{
                    name: 'Inflation',
                    data: [gol1,gol2,gol3,gol4,gol5]
                }],
                chart: {
                    height: 350,
                    type: 'bar',
                },
                plotOptions: {
                    bar: {
                        borderRadius: 10,
                        dataLabels: {
                            position: 'top', // top, center, bottom
                        },
                    }
                },
                dataLabels:");
            WriteLiteral(@" {
                    enabled: true,
                    formatter: function (val) {
                        return val + """";
                    },
                    offsetY: -20,
                    style: {
                        fontSize: '12px',
                        colors: [""#304758""]
                    }
                },

                xaxis: {
                    categories: [""< 25jt"", ""< 50jt"", ""< 75jt"", ""< 100jt"", ""100jt ++""],
                    //position: 'top',
                    axisBorder: {
                        show: false
                    },
                    axisTicks: {
                        show: false
                    },
                    crosshairs: {
                        fill: {
                            type: 'gradient',
                            gradient: {
                                colorFrom: '#D8E3F0',
                                colorTo: '#BED1E6',
                                stops: [0, 100],
            ");
            WriteLiteral(@"                    opacityFrom: 0.4,
                                opacityTo: 0.5,
                            }
                        }
                    },
                    tooltip: {
                        enabled: true,
                    }
                },
                yaxis: {
                    axisBorder: {
                        show: false
                    },
                    axisTicks: {
                        show: false,
                    },
                    labels: {
                        show: false,
                        formatter: function (val) {
                            return val;
                        }
                    }

                },
                title: {
                    text: 'Range Salary',
                    floating: true,
                    align: 'center',
                    style: {
                        color: '#444'
                    }
                }
            };

            v");
            WriteLiteral("ar chart = new ApexCharts(document.querySelector(\"#chartSalary\"), options);\r\n            chart.render();\r\n\r\n        }).fail((result) => {\r\n            //\r\n        });\r\n\r\n\r\n    });\r\n    \r\n</script>");
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
