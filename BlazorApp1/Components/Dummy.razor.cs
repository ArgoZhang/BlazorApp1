// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components;

public partial class Dummy
{
    private string? ClassString => CssBuilder.Default("btn")
        .AddClass(Color, !string.IsNullOrEmpty(Color))
        .AddClassFromAttributes(AdditionalAttributes)
        .Build();

    [Parameter]
    public string? Color { get; set; }

    [Parameter]
    public string? Icon { get; set; }

    [Parameter]
    public string? Text { get; set; }

    /// <summary>
    /// 获得/设置 用户自定义属性
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object>? AdditionalAttributes { get; set; }

    private void OnClick()
    {
        System.Console.WriteLine("button clicked");
    }
}
