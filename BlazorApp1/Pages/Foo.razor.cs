// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using BlazorApp1.Components;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Pages;

public partial class Foo
{
    private List<string> Items { get; } = new();

    private string BeginTime { get; } = DateTime.Now.ToString();

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Items.Add($"Foo: OnInitialized {DateTime.Now}");
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        Items.Add($"Foo: OnInitializedAsync {DateTime.Now}");
        await Task.Delay(1000);
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        Items.Add($"Foo: OnParametersSet {DateTime.Now}");
    }

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        Items.Add($"Foo: OnParametersSetAsync {DateTime.Now}");
        await Task.Delay(1000);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        Items.Add($"Foo: OnAfterRender {DateTime.Now}");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        Items.Add($"Foo: OnAfterRenderAsync {DateTime.Now}");
        await Task.Delay(1000);

        if (firstRender )
        {
            StateHasChanged();
        }
    }
}
