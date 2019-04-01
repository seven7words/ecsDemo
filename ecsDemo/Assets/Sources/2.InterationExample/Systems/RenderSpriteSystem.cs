using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class RenderSpriteSystem : ReactiveSystem<GameEntity> {
    public RenderSpriteSystem(Contexts context) : base(context.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Sprite);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasSprite&entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            Transform trans = entity.view.viewTrans;
            SpriteRenderer sr = trans.GetComponent<SpriteRenderer>();
            if (sr == null) trans.gameObject.AddComponent<SpriteRenderer>();
            sr.sprite = Resources.Load<Sprite>(entity.sprite.spriteName);
        }
    }
}
