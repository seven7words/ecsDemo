using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
/// <summary>
/// 打印消息系统
/// </summary>
public class LogSystem : ReactiveSystem<GameEntity> {
    public LogSystem(IContext<GameEntity> context) : base(context)
    {
        
    }
    
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Log);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasLog;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity gameEntity in entities)
        {
            Debug.Log(gameEntity.log.message);
        }
    }
}
