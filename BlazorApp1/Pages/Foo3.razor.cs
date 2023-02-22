// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages;

public partial class Foo3
{
    private List<string> Items { get; set; } = new(50) { "12" };

    public EventCallback Test { get; set; }

    private void OnClick()
    {
        Items.Add(DateTime.Now.ToString());
    }
}
