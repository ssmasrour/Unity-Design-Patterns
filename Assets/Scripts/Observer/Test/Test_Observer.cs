using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Observer : MonoBehaviour
{
    [ContextMenu("Notify")]
    private void Print1()
    {
        Publisher.Instance.Notify();
    }
}
