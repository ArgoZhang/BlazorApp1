// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using BlazorApp1.Components;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Pages;

public partial class Foo1
{
    private List<string> Items { get; } = new();

    private string BeginTime { get; } = DateTime.Now.ToString();

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Thread.Sleep(1000);
        Items.Add($"Foo: OnInitialized {DateTime.Now}");
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        Thread.Sleep(1000);
        Items.Add($"Foo: OnParametersSet {DateTime.Now}");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        Thread.Sleep(1000);
        Items.Add($"Foo: OnAfterRender {DateTime.Now}");

        if (firstRender)
        {
            StateHasChanged();
        }
    }
}
