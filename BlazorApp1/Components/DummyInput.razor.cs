// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components;

public partial class DummyInput
{
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public EventCallback<string?> ValueChanged { get; set; }

    private string? ValueString
    {
        get { return Value; }
        set
        {
            Value = value;
            if (ValueChanged.HasDelegate)
            {
                ValueChanged.InvokeAsync(Value);
            }
        }
    }
}
