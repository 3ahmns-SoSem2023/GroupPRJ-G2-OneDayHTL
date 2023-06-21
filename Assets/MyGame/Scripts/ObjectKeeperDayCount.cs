using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectKeeperDayCount : MonoBehaviour
{
    private static ObjectKeeperDayCount instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
