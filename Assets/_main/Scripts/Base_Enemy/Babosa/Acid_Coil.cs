using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid_Coil : MonoBehaviour
{
    void Start()
    {
        Invoke("Disolve", 3.0f);
    }

    void Disolve()
    {
        Destroy(gameObject);
    }

}
