using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_ObjectPool : MonoBehaviour
{
    [ContextMenu("Request new object from Pool")]
    private void Print1()
    {
        Pool.Instance.Get();
    }
}
