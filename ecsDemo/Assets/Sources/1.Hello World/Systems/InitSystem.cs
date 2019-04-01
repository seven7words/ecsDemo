using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
/// <summary>
/// 初始化系统
/// </summary>
public class InitSystem : IInitializeSystem {
    /// <summary>
    /// 初始化
    /// </summary>
    public void Initialize()
    {
        _ganeContext.CreateEntity().AddLog("????");
    }

    private readonly GameContext _ganeContext;
    public InitSystem(Contexts contexts)
    {
        _ganeContext = contexts.game;
    }
}
