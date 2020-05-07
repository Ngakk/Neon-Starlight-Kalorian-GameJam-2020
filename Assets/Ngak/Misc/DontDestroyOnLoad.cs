using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public bool isUnique;
    public string uniqueName;

    void Awake()
    {
        if(isUnique)
        {
            Debug.Log("Unique dont destroy");
            var gos = GameObject.FindGameObjectsWithTag("Persistent");
            foreach(var go in gos)
            {
                if (go == gameObject) continue;

                var ddol = go.GetComponent<DontDestroyOnLoad>();
                if(ddol.uniqueName.Equals(uniqueName))
                {
                    Debug.Log("Found a duplicate, self destroying");
                    DestroyImmediate(gameObject);

                    return;
                }
            }
        }

        DontDestroyOnLoad(gameObject);
    }
}
