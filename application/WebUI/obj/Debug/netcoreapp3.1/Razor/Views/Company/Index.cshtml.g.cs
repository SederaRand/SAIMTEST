#pragma checksum "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57803d5013c0c505d35d761b5b23c211f72fd19a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\_ViewImports.cshtml"
using SAIM_FO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\_ViewImports.cshtml"
using SAIM_FO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57803d5013c0c505d35d761b5b23c211f72fd19a", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20d6ca5958735f1d767084f4f3aead6b850d8ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImportTxt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Compagnies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Companies</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">List companies</a></li>
                    <li class=""breadcrumb-item active"">Home</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>


<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">      
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""card card-danger"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Import File</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""");
            WriteLiteral(@"row"">
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <div class=""input-group"">
                                        <div class=""custom-file"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57803d5013c0c505d35d761b5b23c211f72fd19a6201", async() => {
                WriteLiteral("\r\n                                                <input type=\"file\" name=\"file\"/>\r\n                                                <button type=\"submit\">Import File</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                                </div>
                            </div>                            
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card card-green"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Export file company</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <div class=""input-group"">
                                        <div class=""custom-file"">
                                            <input type=""button"" class=""btn btn-def");
            WriteLiteral("ault btn-block\" value=\"Export\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2822, "\"", 2883, 3);
            WriteAttributeValue("", 2832, "location.href=\'", 2832, 15, true);
#nullable restore
#line 65 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
WriteAttributeValue("", 2847, Url.Action("ExportTxt", "Company"), 2847, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2882, "\'", 2882, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        </div>
                                    </div>
                                </div>
                            </div>                            
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""card-header p-2"">
                <ul class=""nav nav-pills"">
                    <li class=""nav-item""><a class=""nav-link active""");
            BeginWriteAttribute("href", " href=\"", 3428, "\"", 3466, 1);
#nullable restore
#line 79 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
WriteAttributeValue("", 3435, Url.Action("Create","Company"), 3435, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add</a></li>                  
                </ul>
            </div>
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">List</h3>
                        <div class=""card-tools"">
                            <div class=""input-group input-group-sm"" style=""width: 150px;"">
                                <div class=""card-tools"">
                                    <div class=""card-tools"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body table-responsive p-0"" style=""height: 300px;"">
                        <table class=""table table-head-fixed text-nowrap"">
                            <thead>
                                <tr>
                                    <th>ID</th>");
            WriteLiteral(@"
                                    <th>Name company</th>
                                    <th>Address</th>
                                    <th>Details</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 107 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
                                 foreach (var company in ViewBag.ListCompany)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 110 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
                                       Write(company.IdCompany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 111 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
                                       Write(company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 112 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
                                       Write(company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 113 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
                                       Write(company.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"project-actions text-right\">\r\n                                            <a class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 5359, "\"", 5437, 1);
#nullable restore
#line 115 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
WriteAttributeValue("", 5366, Url.Action("Update","Company" ,new { idCompany = company.IdCompany } ), 5366, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""fas fa-pencil-alt"">
                                                </i>
                                                Edit
                                            </a>
                                            <a class=""btn btn-danger btn-sm""");
            BeginWriteAttribute("href", " href=\"", 5754, "\"", 5832, 1);
#nullable restore
#line 120 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"
WriteAttributeValue("", 5761, Url.Action("Delete","Company" ,new { idCompany = company.IdCompany } ), 5761, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""fas fa-trash"">
                                                </i>
                                                Delete
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 127 "C:\Users\Ibonia\Documents\WORK FILE\PROJECTS\SAIM TEST\application\WebUI\Views\Company\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>
<!-- /.content -->
");
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
