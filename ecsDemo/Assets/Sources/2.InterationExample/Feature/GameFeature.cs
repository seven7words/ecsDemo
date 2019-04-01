using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeature : Feature {

    public GameFeature(Contexts contexts)
    {
        Add(new AddGameSystems(contexts));
        Add(new AddViewsSystem(contexts.game));
    }
}
