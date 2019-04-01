using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class MouseSystem : IExecuteSystem ,IInitializeSystem
{
    private InputEntity inputEntity;
    private InputContext inputContext;
    public MouseSystem(Contexts contexts)
    {
        this.inputContext = contexts.input;
    }
    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            inputEntity.ReplaceMouse(MouseButton.LEFT,MouseButtonEvent.DOWN);


        }else if (Input.GetMouseButtonDown(1))
        {
            inputEntity.ReplaceMouse(MouseButton.RIGHT, MouseButtonEvent.DOWN);
        }
    }

    public void Initialize()
    {
        inputEntity = inputContext.mouseEntity;
    }
}
