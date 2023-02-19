using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            _instance = FindObjectOfType<T>();

            if (_instance == null)
            {
                GameObject go = new GameObject("[Singleton] " + typeof(T).ToString());
                var instantiatedInstance = go.AddComponent<T>();
                _instance = instantiatedInstance;
            } else
            {
                Debug.LogWarning("[Singleton] is already exists in the scene witt the name: " + _instance.gameObject.name);
            }

            return _instance;
        }
    }
}
