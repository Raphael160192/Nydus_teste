#pragma checksum "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c802d50afed54a3ab6960b9d02d07451bf401152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Colaborador_Edit), @"mvc.1.0.view", @"/Views/Colaborador/Edit.cshtml")]
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
#line 1 "C:\CadastroFuncionários\CadastroFuncionários\Views\_ViewImports.cshtml"
using CadastroFuncionários;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CadastroFuncionários\CadastroFuncionários\Views\_ViewImports.cshtml"
using CadastroFuncionários.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c802d50afed54a3ab6960b9d02d07451bf401152", @"/Views/Colaborador/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618357298edfd1397973af226b1ff85cda6688b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Colaborador_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroFuncionários.Models.Colaborador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Editar Colaborador</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c802d50afed54a3ab6960b9d02d07451bf4011524679", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c802d50afed54a3ab6960b9d02d07451bf4011524941", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <div>\r\n        <label for=\"Nome\">Nome:</label>\r\n        <input type=\"text\" id=\"Nome\" name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 307, "\"", 326, 1);
#nullable restore
#line 14 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 315, Model.Nome, 315, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <div>\r\n        <label for=\"CPF\">CPF:</label>\r\n        <input type=\"text\" id=\"CPF\" name=\"CPF\"");
                BeginWriteAttribute("value", " value=\"", 442, "\"", 460, 1);
#nullable restore
#line 19 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 450, Model.CPF, 450, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    </div>

    <div>
        <label for=""Matricula"">Matrícula:</label>
        <input type=""text"" id=""Matricula"" name=""Matricula"" pattern=""[A-Z]{2}[0-9]{4}"" title=""O campo matrícula deve respeitar o formato CCNNNN, onde C são caracteres (sempre em caixa alta) e N são números. Ex.: AA1234, AB9876""");
                BeginWriteAttribute("value", " value=\"", 768, "\"", 792, 1);
#nullable restore
#line 24 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 776, Model.Matricula, 776, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("readonly", " readonly=\"", 793, "\"", 831, 3);
#nullable restore
#line 24 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 804, Model.DataDemissao, 804, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 823, "!=", 824, 3, true);
                WriteAttributeValue(" ", 826, "null", 827, 5, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <div>\r\n        <label for=\"DataAdmissao\">Data de Admissão:</label>\r\n        <input type=\"date\" id=\"DataAdmissao\" name=\"DataAdmissao\"");
                BeginWriteAttribute("value", " value=\"", 987, "\"", 1037, 1);
#nullable restore
#line 29 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 995, Model.DataAdmissao.ToString("yyyy-MM-dd"), 995, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("readonly", " readonly=\"", 1038, "\"", 1076, 3);
#nullable restore
#line 29 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 1049, Model.DataDemissao, 1049, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1068, "!=", 1069, 3, true);
                WriteAttributeValue(" ", 1071, "null", 1072, 5, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <div>\r\n        <label for=\"DataDemissao\">Data de Demissão:</label>\r\n        <input type=\"date\" id=\"DataDemissao\" name=\"DataDemissao\"");
                BeginWriteAttribute("value", " value=\"", 1232, "\"", 1284, 1);
#nullable restore
#line 34 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 1240, Model.DataDemissao?.ToString(" yyyy-MM-dd"), 1240, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("readonly", " readonly=\"", 1285, "\"", 1323, 3);
#nullable restore
#line 34 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 1296, Model.DataDemissao, 1296, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1315, "!=", 1316, 3, true);
                WriteAttributeValue(" ", 1318, "null", 1319, 5, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <div>\r\n        <label for=\"CargoId\">Cargo:</label>\r\n        <select id=\"CargoId\" name=\"CargoId\"");
                BeginWriteAttribute("disabled", " disabled=\"", 1442, "\"", 1480, 3);
#nullable restore
#line 39 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 1453, Model.DataDemissao, 1453, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1472, "!=", 1473, 3, true);
                WriteAttributeValue(" ", 1475, "null", 1476, 5, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 40 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
               var cargos = ViewBag.Cargos; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
             foreach (var cargo in cargos)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c802d50afed54a3ab6960b9d02d07451bf40115212058", async() => {
#nullable restore
#line 43 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                                                                           Write(cargo.Nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                   WriteLiteral(cargo.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
AddHtmlAttributeValue("", 1642, cargo.Id, 1642, 9, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue(" ", 1651, "==", 1652, 3, true);
                AddHtmlAttributeValue(" ", 1654, "Model.CargoId", 1655, 14, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n\r\n    <div>\r\n        <label for=\"EmpresaId\">Empresa:</label>\r\n        <select id=\"EmpresaId\" name=\"EmpresaId\"");
                BeginWriteAttribute("disabled", " disabled=\"", 1847, "\"", 1885, 3);
#nullable restore
#line 50 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 1858, Model.DataDemissao, 1858, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1877, "!=", 1878, 3, true);
                WriteAttributeValue(" ", 1880, "null", 1881, 5, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 51 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
               var empresas = ViewBag.Empresas; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
             foreach (var empresa in empresas)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c802d50afed54a3ab6960b9d02d07451bf40115215926", async() => {
#nullable restore
#line 54 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                                                                                 Write(empresa.RazaoSocial);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                   WriteLiteral(empresa.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
AddHtmlAttributeValue("", 2057, empresa.Id, 2057, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue(" ", 2068, "==", 2069, 3, true);
                AddHtmlAttributeValue(" ", 2071, "Model.EmpresaId", 2072, 16, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n\r\n");
#nullable restore
#line 59 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
     if (Model.DataDemissao != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a");
                BeginWriteAttribute("href", " href=\"", 2223, "\"", 2250, 1);
#nullable restore
#line 61 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
WriteAttributeValue("", 2230, Url.Action("Index"), 2230, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Voltar</a>\r\n");
#nullable restore
#line 62 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\" value=\"Salvar\" />\r\n        <input type=\"reset\" value=\"Limpar\" />\r\n");
#nullable restore
#line 67 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        // Lógica para carregar os cargos e empresas disponíveis nos comboboxes\r\n        var cargos = ");
#nullable restore
#line 73 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                Write(Html.Raw(Json.Serialize(ViewBag.Cargos)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var empresas = ");
#nullable restore
#line 74 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                  Write(Html.Raw(Json.Serialize(ViewBag.Empresas)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        // Preenche o combobox de cargos
        var cargoSelect = document.getElementById(""CargoId"");
        for (var i = 0; i < cargos.length; i++) {
            var option = document.createElement(""option"");
            option.value = cargos[i].Id;
            option.text = cargos[i].Nome;
            option.selected = cargos[i].Id == """);
#nullable restore
#line 82 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                                          Write(Model.CargoId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" ? true : false;
            cargoSelect.appendChild(option);
        }

        // Preenche o combobox de empresas
        var empresaSelect = document.getElementById(""EmpresaId"");
        for (var i = 0; i < empresas.length; i++) {
            var option = document.createElement(""option"");
            option.value = empresas[i].Id;
            option.text = empresas[i].RazaoSocial;
            option.selected = empresas[i].Id == """);
#nullable restore
#line 92 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                                            Write(Model.EmpresaId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" ? true : false;\r\n            empresaSelect.appendChild(option);\r\n        }\r\n\r\n        // Preenche a data de demissão\r\n        var dataDemissaoInput = document.getElementById(\"DataDemissao\");\r\n        dataDemissaoInput.value = \"");
#nullable restore
#line 98 "C:\CadastroFuncionários\CadastroFuncionários\Views\Colaborador\Edit.cshtml"
                              Write(Model.DataDemissao?.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroFuncionários.Models.Colaborador> Html { get; private set; }
    }
}
#pragma warning restore 1591
