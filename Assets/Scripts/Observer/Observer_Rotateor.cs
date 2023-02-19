using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer_Rotateor : MonoBehaviour, IObserver
{
    [SerializeField] float m_RotationSpeed = 5;
    bool m_Active = false;

    private void Start()
    {
        Publisher.Instance.AddSubscriber(this);
    }

    private void Update()
    {
        if (!m_Active) return;

        transform.Rotate(Vector3.up * m_RotationSpeed * Time.deltaTime);
    }

    public void OnNotify()
    {
        m_Active = true;
        // And other custom codes can be execute from here
    }
}
