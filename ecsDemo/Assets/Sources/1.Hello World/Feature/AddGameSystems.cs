using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 添加系统到框架内
/// </summary>
public class AddGameSystems : Feature {

    public AddGameSystems(Contexts contexts) : base("AddGameSystems")
    {
        Add(new LogSystem(contexts.game));
        Add(new InitSystem(contexts));
    }
}
