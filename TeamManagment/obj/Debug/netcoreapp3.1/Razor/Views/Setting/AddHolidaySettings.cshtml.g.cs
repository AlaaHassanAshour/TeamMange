#pragma checksum "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca6ddd60c31972b37688f1e141d490187eaa825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_AddHolidaySettings), @"mvc.1.0.view", @"/Views/Setting/AddHolidaySettings.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using TeamManagment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using TeamManagment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using TeamManagment.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using TeamManagment.ViewModels.UserVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using TeamManagment.ViewModels.AdminVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\_ViewImports.cshtml"
using TeamManagment.ViewModels.EmployeesVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca6ddd60c31972b37688f1e141d490187eaa825", @"/Views/Setting/AddHolidaySettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23baf2ee65f368b810887219372aa42f8c9e064d", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_AddHolidaySettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HolidaySettingVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MenuTab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Setting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddHolidaySettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div id=\"mytask-layout\" class=\"theme-indigo\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ca6ddd60c31972b37688f1e141d490187eaa8257097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.CompanyInfromation;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""main px-lg-4 px-md-4"">

            <div class=""body d-flex py-lg-5 py-md-5"">
                <div class=""container-xxl"">
                    <div class=""row clearfix"">
                        <div class=""col-md-12"">
                            <div class=""card border-0 mb-4 no-bg"">
                                <div class=""card-header py-3 px-0 d-sm-flex align-items-center  justify-content-between border-bottom"">
                                    <h3 class="" fw-bold flex-fill mb-0 mt-sm-0"">????????????????</h3>
                                    <button type=""button"" class=""btn btn-dark me-1 mt-1 w-sm-100"" data-bs-toggle=""modal"" data-bs-target=""#createemp""><i class=""icofont-plus-circle me-2 fs-6""></i>?????????? ??????????</button>

                                </div>
                            </div>
                        </div>
                    </div><!-- Row End -->
                    <div class=""row clearfix g-3"">
                        <div class=""col-sm-12"">
        ");
            WriteLiteral(@"                    <div class=""card mb-3"">
                                <div class=""card-body"">
                                    <table id=""myProjectTable"" class=""table text-center table-hover align-middle mb-0"" style=""width:100%"">
                                        <thead>
                                            <tr>
                                                <th class=""fw-bold ms-1"">?????? </th>
                                                <th class=""fw-bold ms-1"">?????? ??????????????</th>
                                                <th class=""fw-bold ms-1"">?????????? ??????????????</th>
                                                <th class=""fw-bold ms-1"">?????????? ??????????????</th>
                                                <th class=""fw-bold ms-1"">?????? ????????????</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 36 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                             foreach (var item in Model.HolidaySettings)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    <a class=\"fw-bold text-secondary\">");
#nullable restore
#line 40 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                                                                 Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <span class=\"fw-bold ms-1\">");
#nullable restore
#line 43 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                                                          Write(item.HolidayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <span class=\"fw-bold ms-1\">");
#nullable restore
#line 46 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                                                          Write(item.FirstDay.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <span class=\"fw-bold ms-1\">");
#nullable restore
#line 49 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                                                          Write(item.LastDay.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <span class=\"fw-bold ms-1\">");
#nullable restore
#line 52 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                                                          Write(item.DayDifference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </td>\r\n                                                \r\n                                            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Create Employee-->
            <div class=""modal fade"" id=""createemp"" tabindex=""-1"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered modal-lg modal-dialog-scrollable"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title  fw-bold"" id=""createprojectlLabel""> ?????????? ?????????? </h5>
                            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                        </div>
                        <div class=""modal-body"">
                            <div class=""deadline-form"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca6ddd60c31972b37688f1e141d490187eaa82515071", async() => {
                WriteLiteral(@"
                                    <div class=""row g-3 mb-3"">
                                        <div class=""col"">
                                            <label class=""form-label"">?????? ????????????????</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ca6ddd60c31972b37688f1e141d490187eaa82515594", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 81 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HolidaySetting.HolidayName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""row g-3 mb-3"">
                                        <div class=""col"">
                                            <label class=""form-label"">????</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ca6ddd60c31972b37688f1e141d490187eaa82517758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 87 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HolidaySetting.FirstDay);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"col\">\r\n                                            <label class=\"form-label\">??????</label>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ca6ddd60c31972b37688f1e141d490187eaa82519817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 91 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\Setting\AddHolidaySettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HolidaySetting.LastDay);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">????????</button>
                                        <button type=""submit"" class=""btn btn-primary"">?????????? </button>
                                    </div>

                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            \r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HolidaySettingVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
