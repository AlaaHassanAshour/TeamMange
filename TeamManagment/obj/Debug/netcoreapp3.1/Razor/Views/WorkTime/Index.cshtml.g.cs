#pragma checksum "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53fa0c036977b2ea793ddfe9aa5f214f16f0f063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkTime_Index), @"mvc.1.0.view", @"/Views/WorkTime/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53fa0c036977b2ea793ddfe9aa5f214f16f0f063", @"/Views/WorkTime/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23baf2ee65f368b810887219372aa42f8c9e064d", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkTime_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkTimeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MenuTab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark p-3 me-1 mt-1 w-sm-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdNewWork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddWork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'!!???? ?????? ?????????? ???? ?????????????? ????\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DoneWork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdditionalWork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdditionalWorkDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    #myProjectTable_length, #myProjectTable_filter {\r\n        display: none;\r\n    }\r\n</style>\r\n    <div id=\"mytask-layout\" class=\"theme-indigo\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53fa0c036977b2ea793ddfe9aa5f214f16f0f0637251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
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

        <!-- main body area -->
        <div class=""main px-lg-4 px-md-4"">

            <!-- Body: Body -->
            <div class=""body d-flex py-3"">
                <div class=""container-xxl"">
                    <div class=""row clearfix g-3"">

                        <div class=""col-xl-4 col-lg-12 col-md-12"">
                            <div class=""row g-3 row-deck"">
                                <div class=""col-md-6 col-lg-6 col-xl-12"">

                                </div>
                                <div class=""col-md-6 col-lg-6 col-xl-12  flex-column"">
");
#nullable restore
#line 25 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                     if (Model.WorkTime == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa0c036977b2ea793ddfe9aa5f214f16f0f0639770", async() => {
                WriteLiteral("\r\n                                            ?????? ??????????\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                         if (Model.WorkTime.States == 0 && !Model.WorkTime.HolidayOrNot)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa0c036977b2ea793ddfe9aa5f214f16f0f06312009", async() => {
                WriteLiteral("\r\n                                                ?????? ??????????\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-WID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                                                                             WriteLiteral(Model.WorkTime.WorkTimeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-WID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                             if (Model.WorkTime.WorkEndDone != true)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa0c036977b2ea793ddfe9aa5f214f16f0f06315375", async() => {
                WriteLiteral("\r\n                                                    ?????????? ??????????\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-WID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                                                                                                                                           WriteLiteral(Model.WorkTime.WorkTimeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-WID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                 if (Model.WorkTime.ExtraHours != true || Model.WorkTime.HolidayOrNot)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa0c036977b2ea793ddfe9aa5f214f16f0f06318954", async() => {
                WriteLiteral("\r\n                                                        ?????????? ????????????\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-WID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                                                                                            WriteLiteral(Model.WorkTime.WorkTimeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-WID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa0c036977b2ea793ddfe9aa5f214f16f0f06322046", async() => {
                WriteLiteral("\r\n                                                        ?????????? ??????????????\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-WID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                                                    WriteLiteral(Model.WorkTime.WorkTimeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-WID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["WID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                             

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>


            <div class=""row g-3 mb-3 row-cols-1 row-cols-sm-2 row-cols-md-2 row-cols-lg-2 row-cols-xl-4 row-cols-xxl-4"">
                <div class=""col"">
                    <div class=""card bg-primary"">
                        <div class=""card-body text-white d-flex align-items-center"">
                            <i class=""icofont-data fs-3""></i>
                            <div class=""d-flex flex-column ms-3"">
                                <h6 class=""mb-0"">?????? ???????? ????????????</h6>
                                 <span class=""text-white"">");
#nullable restore
#line 88 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                     Write(ViewBag.totalWork);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card bg-primary"">
                        <div class=""card-body text-white d-flex align-items-center"">
                            <i class=""icofont-chart-flow fs-3""></i>
                            <div class=""d-flex flex-column ms-3"">
                                <h6 class=""mb-0"">???????? ???????????????? + ???????? ????????????</h6>
                                <span class=""text-white"">");
#nullable restore
#line 99 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                    Write(ViewBag.totalHoliday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card bg-primary"">
                        <div class=""card-body text-white d-flex align-items-center"">
                            <i class=""icofont-chart-flow-2 fs-3""></i>
                            <div class=""d-flex flex-column ms-3"">
                                <h6 class=""mb-0"">?????????? ????????????</h6>
                                <span class=""text-white"">");
#nullable restore
#line 110 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                    Write(ViewBag.totalExit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card bg-primary"">
                        <div class=""card-body text-white d-flex align-items-center"">
                            <i class=""icofont-tasks fs-3""></i>
                            <div class=""d-flex flex-column ms-3"">
                                <h6 class=""mb-0"">?????????????? ????????????????</h6>
                                <span class=""text-white"">");
#nullable restore
#line 121 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                    Write(ViewBag.totalAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row g-3 mb-3 row-deck"">
                <div class=""col-md-12"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <table id=""myProjectTable"" class=""table text-center table-hover align-middle mb-0"" style=""width:100%"">
                                        <thead>
                                            <tr>
                                                <th class=""fw-bold ms-1"">?????? </th>
                                                <th class=""fw-bold ms-1"">?????????? ??????????</th>
                                                <th class=""fw-bold ms-1"">?????? ?????? ??????????</th>
                                                <th class=""fw-bold ms-1"">?????? ?????????? ??????????</th>
                                                <th class=""fw-bold ms-1""> ??????????</th>
           ");
            WriteLiteral(@"                                     <th class=""fw-bold ms-1""> ???????? ??????????</th>
                                                <th class=""fw-bold ms-1""> ?????????? ????????????</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 144 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                             foreach (var item in Model.Employee.WorkTimes.Where(c=>c.TheDate.Month == DateTime.Today.Month))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    <a class=\"fw-bold text-secondary\">");
#nullable restore
#line 148 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                 Write(item.WorkTimeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 151 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                               Write(item.TheDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 154 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                               Write(item.WorkStart.ToShortTimeString().Trim(new Char[] { 'A', 'P', 'M' }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 157 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                               Write(item.WorkEnd.ToShortTimeString().Trim(new Char[] { 'A', 'P', 'M' }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
#nullable restore
#line 159 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                  if (item.ExiteID != null)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         <td> ");
#nullable restore
#line 161 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                         Write(item.ExitePrmission.TotalHrs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 162 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                    }else {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>0</td>");
#nullable restore
#line 162 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                \r\n");
#nullable restore
#line 165 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                 if (item.States != 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <td> <i class=\"icofont-check-circled text-success\"></i></td>");
#nullable restore
#line 165 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                                                                      }
                                                else {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <td> <i class=\"icofont-close-circled text-danger\"></i></td>");
#nullable restore
#line 166 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 169 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"
                                               Write(item.ExtraHourDifference);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 174 "C:\Users\PC\Desktop\TeamManagment\TeamManagment\Views\WorkTime\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                                        </tbody>\r\n                                    </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkTimeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
