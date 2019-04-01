using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public class AddViewsSystem : ReactiveSystem<GameEntity>
{
    private Transform parent;
    private IContext<GameEntity> contexts;
    public AddViewsSystem(IContext<GameEntity> context) : base(context)
    {
        this.contexts = context;
        parent = new GameObject("ViewParent").transform;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.View);
    }

    protected override bool Filter(GameEntity entity)
    {
        return !entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            GameObject go = new GameObject("View");
            go.transform.SetParent(parent);
            go.Link(entity, contexts);
            entity.AddView(go.transform);
        }
    }
}
