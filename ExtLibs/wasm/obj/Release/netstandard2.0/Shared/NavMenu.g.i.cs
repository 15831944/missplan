#pragma checksum "D:\missplan\MissionPlanner\ExtLibs\wasm\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4084dcd2f5a486605f320ef28a54d12eefa2e927"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace wasm.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using wasm;
    using wasm.Shared;
    using MissionPlanner.Comms;
    using Blazor.FileReader;
    using MissionPlanner;
    using MissionPlanner.Utilities;
    using MissionPlanner.Log;
    using Blazor.Extensions.Canvas;
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 44 "D:\missplan\MissionPlanner\ExtLibs\wasm\Shared\NavMenu.cshtml"
            
    bool collapseNavMenu = true;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;

        StateHasChanged();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591