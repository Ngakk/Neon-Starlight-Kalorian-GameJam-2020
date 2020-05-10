using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidDrop : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
