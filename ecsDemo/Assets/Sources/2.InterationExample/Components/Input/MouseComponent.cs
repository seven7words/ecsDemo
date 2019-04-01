using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
/// <summary>
/// 鼠标点击组件
/// </summary>
[Input,Unique]
public class MouseComponent : IComponent
{
/// <summary>
/// 点击鼠标类型
/// </summary>
    public MouseButton mouse;
    public MouseButtonEvent MouseEvent;
}
