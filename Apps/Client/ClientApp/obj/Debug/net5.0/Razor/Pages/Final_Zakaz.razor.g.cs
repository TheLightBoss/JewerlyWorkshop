#pragma checksum "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5adf17da02c69f1522ac4f0b678417e0a737ca53"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/final_zakaz")]
    public partial class Final_Zakaz : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(3);
                __builder2.AddAttribute(4, "Class", "mt-8");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(8);
                        __builder4.AddAttribute(9, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(11);
                            __builder5.AddAttribute(12, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(13);
                                __builder6.AddAttribute(14, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(15, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 16 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                       Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(17, "Ваше изделие");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(18, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(19);
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(21, "div");
                                __builder6.OpenElement(22, "img");
                                __builder6.AddAttribute(23, "width", "490");
                                __builder6.AddAttribute(24, "height", "400");
                                __builder6.AddAttribute(25, "src", 
#nullable restore
#line 21 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                            spr.url_pic

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(26, "alt", "Изделие");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(27, "\r\n                    <br>\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudSelect<double>>(28);
                                __builder6.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                             Price_shet

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(30, "Label", "Размер");
                                __builder6.AddAttribute(31, "Strict", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(32, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                                                                          Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(33, "Format", "F2");
                                __builder6.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
#nullable restore
#line 31 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                         for (double i = 15; i <= 20; i += 0.5)
                        {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<MudBlazor.MudSelectItem<double>>(35);
                                    __builder7.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#nullable restore
#line 33 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                              i

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 34 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                        }

#line default
#line hidden
#nullable disable
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(37, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudText>(38);
                                __builder6.AddAttribute(39, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 36 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                   Typo.overline

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(41, "Примерная стоимость кольца: ");
                                    __builder7.AddContent(42, 
#nullable restore
#line 36 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                                               price_

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.AddMarkupContent(43, " руб");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(45);
                            __builder5.AddAttribute(46, "Class", "d-flex justify-center");
                            __builder5.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudButton>(48);
                                __builder6.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                         SetIzdelie

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(50, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 39 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                              Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 39 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                                                     Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(52, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 39 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                                                                          Size.Large

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(53, "Style", "width:50%;");
                                __builder6.AddAttribute(54, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                                                                                                                                    butt

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(56, "Заказать");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(58);
                    __builder3.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(60);
                        __builder4.AddAttribute(61, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Final_Zakaz.razor"
       
    ClientSOAP clientSOAP;
    bool butt = true;
    double price_;
    //SetCena cena = new();
    protected override void OnInitialized()
    {
        price_ = Convert.ToDouble(Math.Round((Configurator_page.select_mat.price_mater * spr.weight_ref * 1.08), 2));
    }
     
    RefProd spr = Conf_Osobenn.selectedIzd;
    double selectedVal; //выбранный размер

    CreateOrder createOrder = new();


    private void Price_shet(double selVal)
    {
        this.selectedVal = selVal;
        butt = false;
        price_ = Convert.ToDouble(Math.Round((Configurator_page.select_mat.price_mater * (spr.weight_ref + selectedVal * 0.15) * 1.08), 2));
    }
    private async void SetIzdelie()
    {
        //izdel.IdIzdspr = spr.IdIzdspr;
        //izdel.DateShtampa = null;
        //izdel.IdProb = 1;
        //izdel.Razmer = selectedVal;
        //izdel.PriceIzd = Math.Round(cena.Koeff.Value * cena.PriceMater.Value * Convert.ToDecimal(selectedVal), 2);
        //Service.InsertIzdelie(izdel);
        //var auState = await authenticationStateTask;
        //var User = auState.User;
        //var us = await userManager.GetUserAsync(User);
        //zakaz.IdClient = us.Id;
        //zakaz.DateZak = DateTime.Now;
        //zakaz.IdIzd = izdel.IdIzd;
        //zakaz.StatusZak = false;
        //zakazServ.InsertZakaz(zakaz);

        //TODO: Выбирать клиента
        clientSOAP = await localStorage.GetItemAsync<ClientSOAP>("login");
        createOrder.id_client = clientSOAP.id_client;
        createOrder.id_ref_prod = spr.id_ref_prod;
        createOrder.size = selectedVal;
        createOrder.weight = spr.weight_ref + selectedVal * 0.15;
        createOrder.price_prod = Convert.ToDouble(Math.Round((Configurator_page.select_mat.price_mater * createOrder.weight * 1.08), 2));

        if (soap.CreateOrder(createOrder)) ;

        var dialog = await DialogService.Show<Success>("Успешно").Result;
        if (!dialog.Cancelled)
        {
            NavMan.NavigateTo("/order");
        }
        else NavMan.NavigateTo("/");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SOAPService soap { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591