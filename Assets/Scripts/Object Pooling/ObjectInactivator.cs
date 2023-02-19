using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInactivator : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Deactive", 3);
    }

    void Deactive()
    {
        gameObject.SetActive(false);
    }
}
