#pragma checksum "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edef7eec64411135f256aef49c90837d02bd1644"
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
#line 1 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 3 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 4 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 5 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 6 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/_Imports.razor"
using LibreriaComponenti.Shared;

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
#line 37 "/Users/micheleaponte/blazordevita/articoli/LibreriaComponenti/LibreriaComponenti/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");     
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
