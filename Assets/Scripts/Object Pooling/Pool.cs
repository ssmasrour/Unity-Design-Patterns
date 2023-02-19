using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Pool : Singleton<Pool>
{
    [SerializeField] GameObject m_Prefab;
    [SerializeField] int InitialQty = 1;

    [Space, Header("Visible only for Test")]
    [SerializeField]
    private List<GameObject> m_Pool;

    private void Start()
    {
        m_Pool = new List<GameObject>();
        Init();
    }

    private void Init()
    {
        for (int i = 0; i < InitialQty; i++)
        {

            var go = Instantiator();
            go.SetActive(false);
            m_Pool.Add(go);
        }
    }

    public GameObject Get()
    {
        // take first game object which is not active in scene hierarchy
        var availableObject = m_Pool.FirstOrDefault(a => !a.activeInHierarchy);

        if (availableObject == null)
        {
            availableObject = Instantiator();
            m_Pool.Add(availableObject);
        }

        availableObject.SetActive(true);
        return availableObject;
    }

    GameObject Instantiator()
    {
        var go = Instantiate(m_Prefab);

        // Optional: set parent
        go.transform.parent = this.transform;

        return go;
    }
}
