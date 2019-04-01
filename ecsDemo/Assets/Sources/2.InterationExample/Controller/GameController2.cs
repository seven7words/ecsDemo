using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameController2 : MonoBehaviour
{

    private Systems systems;
    private Contexts contexts;
    private void Start()
    {
        contexts = Contexts.sharedInstance;
        systems = new Feature("System").Add(new GameFeature(contexts));

    }

    private void Update()
    {
        systems.Execute();
        systems.Cleanup();
    }
}
