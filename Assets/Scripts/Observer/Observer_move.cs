using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer_move : MonoBehaviour, IObserver
{
    [SerializeField] float m_MoveSpeed = 5;
    [SerializeField] float m_MoveBoundary = 2;

    bool m_Active = false;

    private void Start()
    {
        Publisher.Instance.AddSubscriber(this);
    }

    private void Update()
    {
        if (!m_Active) return;

        transform.position += new Vector3(0, Time.deltaTime * m_MoveSpeed, 0);
        
    }
    public void OnNotify()
    {
        m_Active = true;
        // And other custom codes can be called from here
    }
}
