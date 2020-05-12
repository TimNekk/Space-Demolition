using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Params
    [SerializeField] int breakableBlocks; // Debag

    // Cached
    SceneLoader sceneLoader;

    public void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks == 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
