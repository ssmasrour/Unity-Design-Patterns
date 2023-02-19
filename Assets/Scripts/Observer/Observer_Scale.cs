using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer_Scale : MonoBehaviour, IObserver
{
    [SerializeField] float m_ScalingSpeed = 0.5f;
    bool m_Active = false;

    private void Start()
    {
        Publisher.Instance.AddSubscriber(this);
    }

    private void Update()
    {
        if (!m_Active) return;

        transform.localScale += new Vector3(1, m_ScalingSpeed * Time.deltaTime, 1);
    }

    public void OnNotify()
    {
        m_Active = true;
        // And other custom codes can be execute from here
    }
}
