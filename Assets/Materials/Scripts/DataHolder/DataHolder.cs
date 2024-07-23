using System.Collections.Generic;
using UnityEngine;

public static class DataHolder
{
    public static List<GameObject> _firstSceneGameObjects { get; private set; } = new List<GameObject>();
    public static List<GameObject> _secondSceneGameObjects { get; private set; } = new List<GameObject>();

    public static void LoadAssetsForFirstGame(GameObject asset)
    {
        _firstSceneGameObjects.Add(asset);
    }
    
    public static void LoadAssetsForSecondGame(GameObject asset)
    {
        _secondSceneGameObjects.Add(asset);
    }

    public static void DeleteAssetsForFirstGame()
    {
        _firstSceneGameObjects.Clear();
    }
    
    public static void DeleteAssetsForSecondGame()
    {
        _secondSceneGameObjects.Clear();
    }
}
