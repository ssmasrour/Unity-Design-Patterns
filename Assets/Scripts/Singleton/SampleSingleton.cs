using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSingleton : MonoBehaviour
{
    #region Singleton
    public static SampleSingleton Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("You already have another instance of " + this.GetType().ToString());
            return;
        }

        Instance = this;
    }
    #endregion

    public int TestValue = 10;

}
