#pragma checksum "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f448fc2a33c5170e37a874e59fbd02ac16358aa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Results.cshtml", typeof(AspNetCore.Views_Home_Results))]
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
#line 1 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\_ViewImports.cshtml"
using DK.Web;

#line default
#line hidden
#line 2 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\_ViewImports.cshtml"
using DK.Web.ViewModels;

#line default
#line hidden
#line 3 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
using DK.BusinessLogic.Helpers;

#line default
#line hidden
#line 4 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
using DK.DataAccess.Enums;

#line default
#line hidden
#line 5 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
using DK.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f448fc2a33c5170e37a874e59fbd02ac16358aa1", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c0b10d1ca970eda3aaac8e60075617da4643ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("connection__icon connection__icon--campaign"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-b btn-b--small work__preview-more"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Interview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExamReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-b"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contacts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Results";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(204, 699, true);
            WriteLiteral(@"
<section class=""contact"" style=""padding-top: 220px;"">
    <div class=""contact__wrap"">
        <div class=""container no-width"">
            <h2 class=""title-h2"">Score calculation</h2>
            <h3 class=""title-h3"">Each question has it's score value. If candidate gives the right answer than score will be added to the total sum. Also we use boost coefficients for more complex exams:</h3>
            <div class=""contact__outer"">
                <div class=""contact__itm"">
                    <div class=""connection connection--contacts"">
                        <div class=""connection__outer"">
                            <div class=""connection__top"">
                                ");
            EndContext();
            BeginContext(903, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f448fc2a33c5170e37a874e59fbd02ac16358aa17747", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 965, "~/images/", 965, 9, true);
#line 22 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
AddHtmlAttributeValue("", 974, Constants.BASE_TYPE_ICO, 974, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1002, 64, true);
            WriteLiteral("\r\n                                <span class=\"connection__ttl\">");
            EndContext();
            BeginContext(1067, 44, false);
#line 23 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                         Write(ExamType.Base.GetEnumDisplayName().ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1111, 420, true);
            WriteLiteral(@"</span>
                                <p class=""connection__text"">Exams for base knowleage level.</p>
                                <a class=""connection__link"" href=""#"">NO TIME LIMIT</a>
                            </div>
                            <div class=""connection__bottom"">
                                <a class=""btn-b btn-b--small"" href=""#"">
                                    <span>COEFFICIENT: ");
            EndContext();
            BeginContext(1532, 31, false);
#line 29 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                  Write(Constants.BASE_EXAM_COEFFICIENT);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 428, true);
            WriteLiteral(@" X</span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""contact__itm"">
                    <div class=""connection connection--contacts"">
                        <div class=""connection__outer"">
                            <div class=""connection__top"">
                                ");
            EndContext();
            BeginContext(1991, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f448fc2a33c5170e37a874e59fbd02ac16358aa111237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2053, "~/images/", 2053, 9, true);
#line 39 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
AddHtmlAttributeValue("", 2062, Constants.INTERMEDIATE_TYPE_ICO, 2062, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2098, 64, true);
            WriteLiteral("\r\n                                <span class=\"connection__ttl\">");
            EndContext();
            BeginContext(2163, 52, false);
#line 40 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                         Write(ExamType.Intermediate.GetEnumDisplayName().ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2215, 412, true);
            WriteLiteral(@"</span>
                                <p class=""connection__text"">Medium difficulty exam.</p>
                                <a class=""connection__link"" href=""#"">NO TIME LIMIT</a>
                            </div>
                            <div class=""connection__bottom"">
                                <a class=""btn-b btn-b--small"" href=""#"">
                                    <span>COEFFICIENT: ");
            EndContext();
            BeginContext(2628, 39, false);
#line 46 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                  Write(Constants.INTERMEDIATE_EXAM_COEFFICIENT);

#line default
#line hidden
            EndContext();
            BeginContext(2667, 428, true);
            WriteLiteral(@" X</span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""contact__itm"">
                    <div class=""connection connection--contacts"">
                        <div class=""connection__outer"">
                            <div class=""connection__top"">
                                ");
            EndContext();
            BeginContext(3095, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f448fc2a33c5170e37a874e59fbd02ac16358aa114748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3157, "~/images/", 3157, 9, true);
#line 56 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
AddHtmlAttributeValue("", 3166, Constants.ADVANCED_TYPE_ICO, 3166, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3198, 64, true);
            WriteLiteral("\r\n                                <span class=\"connection__ttl\">");
            EndContext();
            BeginContext(3263, 48, false);
#line 57 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                         Write(ExamType.Advanced.GetEnumDisplayName().ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3311, 411, true);
            WriteLiteral(@"</span>
                                <p class=""connection__text"">Medium difficulty exam.</p>
                                <a class=""connection__link"" href=""#"">TIME LIMITED</a>
                            </div>
                            <div class=""connection__bottom"">
                                <a class=""btn-b btn-b--small"" href=""#"">
                                    <span>COEFFICIENT: ");
            EndContext();
            BeginContext(3723, 35, false);
#line 63 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                  Write(Constants.ADVANCED_EXAM_COEFFICIENT);

#line default
#line hidden
            EndContext();
            BeginContext(3758, 513, true);
            WriteLiteral(@" X</span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""contact__sect-cnt"">
    <div class=""contact__wrap"">
        <div class=""container no-width"">
            <h2 class=""title-h2"">Candidate Results</h2>
            <h3 class=""title-h3"">Sorted by higher score</h3>
            <div class=""contact__outer--results"">
");
            EndContext();
#line 80 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                 foreach (var interview in Model)
                {

#line default
#line hidden
            BeginContext(4341, 126, true);
            WriteLiteral("                    <div class=\"work__itm--results\">\r\n                        <div class=\"work__preview--results\" data-value=\"");
            EndContext();
            BeginContext(4468, 14, false);
#line 83 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                                   Write(interview.Type);

#line default
#line hidden
            EndContext();
            BeginContext(4482, 261, true);
            WriteLiteral(@""">
                            <div class=""work__preview-row"">
                                <div class=""work__preview-col--results"">
                                    <i class=""work__icon"">
                                        <img class=""work__img""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4743, "\"", 4780, 2);
            WriteAttributeValue("", 4749, "/images/", 4749, 8, true);
#line 87 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
WriteAttributeValue("", 4757, interview.ExamTypeLogo, 4757, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4781, 114, true);
            WriteLiteral(">\r\n                                    </i>\r\n                                    <span class=\"work__ttl--results\">");
            EndContext();
            BeginContext(4896, 15, false);
#line 89 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                                Write(interview.Score);

#line default
#line hidden
            EndContext();
            BeginContext(4911, 181, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"work__preview-col\">\r\n                                    <img class=\"exam-logo--results\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5092, "\"", 5125, 2);
            WriteAttributeValue("", 5098, "/images/", 5098, 8, true);
#line 92 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
WriteAttributeValue("", 5106, interview.ExamLogo, 5106, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5126, 175, true);
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"work__preview-col--descr\">\r\n                                    <span class=\"work__ttl\">");
            EndContext();
            BeginContext(5302, 18, false);
#line 95 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                       Write(interview.ExamName);

#line default
#line hidden
            EndContext();
            BeginContext(5320, 67, true);
            WriteLiteral("</span>\r\n                                    <p class=\"work__text\">");
            EndContext();
            BeginContext(5388, 27, false);
#line 96 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                     Write(interview.CandidateFullName);

#line default
#line hidden
            EndContext();
            BeginContext(5415, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(5418, 30, false);
#line 96 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                                                   Write(interview.CandidateDescription);

#line default
#line hidden
            EndContext();
            BeginContext(5448, 71, true);
            WriteLiteral(")</p>\r\n                                    <p class=\"work__text-email\">");
            EndContext();
            BeginContext(5520, 15, false);
#line 97 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                           Write(interview.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5535, 79, true);
            WriteLiteral("</p>\r\n                                    <a class=\"connection__link\" href=\"#\">");
            EndContext();
            BeginContext(5615, 48, false);
#line 98 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                                    Write(interview.Date.ToLocalTime().ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5663, 42, true);
            WriteLiteral("</a>\r\n                                    ");
            EndContext();
            BeginContext(5705, 261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f448fc2a33c5170e37a874e59fbd02ac16358aa123797", async() => {
                BeginContext(5855, 107, true);
                WriteLiteral("\r\n                                        <span>Review Answers</span>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                                                                                                                                                      WriteLiteral(interview.InterviewId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5966, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 106 "D:\Dev\SourceControls\GitHub\Mine\CandidateInterviewer\CandidateInterviewer\DK.Web\Views\Home\Results.cshtml"
                }

#line default
#line hidden
            BeginContext(6123, 174, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"about-ci\">\r\n    <div class=\"container\">\r\n        <h2 class=\"title-h2\">Need more statistics?</h2>");
            EndContext();
            BeginContext(6297, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f448fc2a33c5170e37a874e59fbd02ac16358aa127491", async() => {
                BeginContext(6370, 23, true);
                WriteLiteral("<span>Contact us</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6397, 24, true);
            WriteLiteral("\r\n    </div>\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
