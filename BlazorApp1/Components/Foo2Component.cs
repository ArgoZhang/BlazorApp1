// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Components;

public partial class Foo2Component : ComponentBase
{
    [CascadingParameter]
    [NotNull]
    public List<string>? Foos { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Foos.Add("1");
    }
}
