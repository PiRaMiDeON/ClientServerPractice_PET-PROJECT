using UnityEngine;
using System;

public class FirstSceneController : MonoBehaviour
{
    private void Awake()
    {
        for (int i = 0; i < DataHolder._firstSceneGameObjects.Count; i++)
        {
            try
            {
                Instantiate(DataHolder._firstSceneGameObjects[i]);
            }
            catch(Exception e)
            {
                Debug.LogError(e);
            }
        }
    }
}
