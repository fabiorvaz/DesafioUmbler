#pragma checksum "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98510d0064fc3d5c64cf9d86c1e28cc79624a15"
// <auto-generated/>
#pragma warning disable 1591
namespace DesafioUmbler.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using DesafioUmbler.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\_Imports.razor"
using DesafioUmbler.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
using DesafioUmbler.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class WhoIs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Who Is</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "mm-0");
            __builder.AddAttribute(3, "class", "mm-page mm-slideout");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "id", "domain-search");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
                          query

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
                                                 searchData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "container py-4 pb-md-5");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "id", "box-result");
                __builder2.AddAttribute(18, "class", "row");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-lg-9 col-md-8");
                __builder2.AddMarkupContent(21, "<label class=\"sr-only\" for=\"txt-search\">Domínio</label>\r\n                        ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "class", "form-control form-control-lg domain");
                __builder2.AddAttribute(24, "id", "txt-search");
                __builder2.AddAttribute(25, "name", "txt-search");
                __builder2.AddAttribute(26, "placeholder", "Digite o Domínio que deseja pesquisar");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
                                                                                                                    query.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.Name = __value, query.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.AddMarkupContent(31, @"<div class=""col-lg-3 col-md-4 text-xs-right""><button type=""submit"" id=""btn-search"" name=""name"" class=""btn btn-success btn-block btn-lg text-xs-center"" data-loading-text=""Pesquisando...""><i class=""icon icon-search icon-white mr-1""></i>
                            <span>Pesquisar...</span></button></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n                ");
                __builder2.AddMarkupContent(33, "<div class=\"container w-100\"><div class=\"row hide\" id=\"whois-results\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 34 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
     if (processando)
    { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<h2>Processando requisição, por favor aguarde...</h2>");
#nullable restore
#line 37 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
     if (domain != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<h4>Dominio</h4>\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddContent(37, 
#nullable restore
#line 42 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
              string.Join(" > ", domain.Name)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddMarkupContent(39, "<h4>IP</h4>\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddContent(41, 
#nullable restore
#line 44 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
               domain.Ip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.AddMarkupContent(43, "<h4>Hospedado em</h4>\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddContent(45, 
#nullable restore
#line 46 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
              domain.HostedAt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.AddMarkupContent(47, "<h4>Consulta completa</h4>\r\n        ");
            __builder.OpenElement(48, "pre");
            __builder.AddContent(49, 
#nullable restore
#line 48 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
              domain.WhoIs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 49 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "F:\Users\fabio\source\repos\DesafioUmbler\DesafioUmbler\Client\Pages\WhoIs.razor"
       

    private DomainValidation query = new DomainValidation();
    private bool processando = false;
    private Domain domain;

    private async void searchData()
    {
        processando = true;
        StateHasChanged();
        domain = await Http.GetFromJsonAsync<Domain>(string.Format("Domain?domainName={0}",query.Name));
        processando = false;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591