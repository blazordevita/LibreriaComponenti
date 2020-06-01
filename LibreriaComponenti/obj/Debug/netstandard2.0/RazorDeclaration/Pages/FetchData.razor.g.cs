#pragma checksum "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6777b7b21a17c1f342e6cd2eed651f6f640bb547"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LibreriaComponenti.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using LibreriaComponenti.Shared;

#line default
#line hidden
#line 6 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using LibreriaComponenti.Services;

#line default
#line hidden
#line 7 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using LibreriaComponenti.Models;

#line default
#line hidden
#line 8 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\_Imports.razor"
using LibreriaComponenti.Components;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 45 "c:\Users\miche\BlazorDevIta\articoli\LibreriaComponenti\LibreriaComponenti\Pages\FetchData.razor"
       
    private GridModel WeatherForecastModel = new GridModel();
    private WeatherForecast[] weatherForecasts = null;
    private WeatherForecast newWeatherForecast = null;

    public void CreateWeatherForecast()
    {
        newWeatherForecast = new WeatherForecast();
    }

    public void Cancel()
    {
        newWeatherForecast = null;
    }

    public void Save()
    {
        Array.Resize(ref weatherForecasts, weatherForecasts.Length + 1);
        weatherForecasts[weatherForecasts.Length - 1] = newWeatherForecast;
        WeatherForecastModel.Rows = weatherForecasts;
        newWeatherForecast = null;
    }

    protected override async Task OnInitializedAsync()
    {
        WeatherForecastModel.UseAnnotations = true;
        weatherForecasts = await WeatherForecastService.GetForecastAsync(DateTime.Now);
        WeatherForecastModel.Rows = weatherForecasts;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWeatherForecastService WeatherForecastService { get; set; }
    }
}
#pragma warning restore 1591
