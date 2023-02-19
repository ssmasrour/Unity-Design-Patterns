using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Singeltons : MonoBehaviour
{
    [ContextMenu("Test Singleton (hard coded)")]
    private void Print1()
    {
        Debug.Log(SampleSingleton.Instance.TestValue);
    }

    [ContextMenu("Test Singleton (generic)")]
    private void Print2()
    {
        Debug.Log(SampleSingleton.Instance.TestValue);
    }


}
