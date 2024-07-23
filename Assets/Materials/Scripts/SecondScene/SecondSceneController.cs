using System;
using UnityEngine;

public class SecondSceneController : MonoBehaviour
{
    private void Awake()
    {
        for (int i = 0; i < DataHolder._secondSceneGameObjects.Count; i++)
        {
            try
            {
                Instantiate(DataHolder._secondSceneGameObjects[i]);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }
    }
}
