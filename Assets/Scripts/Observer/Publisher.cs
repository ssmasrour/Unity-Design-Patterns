using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Publisher : Singleton<Publisher>
{
    private List<IObserver> m_Subscribers = new List<IObserver>();
    void Start()
    {
        
    }

    public void AddSubscriber(IObserver new_subscriber)
    {
        bool alreadyAdded = m_Subscribers.Any(a => a == new_subscriber);

        if (!alreadyAdded)
            m_Subscribers.Add(new_subscriber);
    }

    public void Notify() => m_Subscribers.ForEach(a => a?.OnNotify());

}
