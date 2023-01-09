// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Components;

public partial class Foo1Component
{
    [Parameter]
    [NotNull]
    public List<string> Items { get; set; } = new();

    private string BeginTime { get; } = DateTime.Now.ToString();

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Thread.Sleep(1000);
        Items.Add($"FooComponent: OnInitialized {DateTime.Now}");
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        Thread.Sleep(1000);
        Items.Add($"FooComponent: OnParametersSet {DateTime.Now}");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        Thread.Sleep(1000);
        Items.Add($"FooComponent: OnAfterRender {DateTime.Now}");

        if (firstRender)
        {
            StateHasChanged();
        }
    }
}
