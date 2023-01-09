// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Components;

public partial class FooComponent
{
    [Parameter]
    [NotNull]
    public List<string>? Items { get; set; }

    [Parameter]
    public Func<Task>? OnAfterRenderCallbackAsync { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Items.Add($"FooComponent: OnInitialized {DateTime.Now}");
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        Items.Add($"FooComponent: OnInitializedAsync {DateTime.Now}");
        await Task.Delay(1000);
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        Items.Add($"FooComponent: OnParametersSet {DateTime.Now}");
    }

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        Items.Add($"FooComponent: OnParametersSetAsync {DateTime.Now}");
        await Task.Delay(1000);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        Items.Add($"FooComponent: OnAfterRender {DateTime.Now}");
    }

    private int Index { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        Items.Add($"FooComponent: OnAfterRenderAsync {DateTime.Now}");
        await Task.Delay(1000);

        if (firstRender || Index == 1)
        {
            Index++;
            if (OnAfterRenderCallbackAsync != null)
            {
                await OnAfterRenderCallbackAsync();
            }
        }
    }
}
