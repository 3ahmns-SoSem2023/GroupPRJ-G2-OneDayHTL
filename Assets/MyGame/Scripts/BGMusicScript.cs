using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BGMusicScript : MonoBehaviour
{
    private static BGMusicScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
