using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidDrop : MonoBehaviour
{
    public GameObject debris;
    public float lifeTime = 10;
    public bool destroyOnCollide = true;

    private float bornTime;

    private void OnEnable()
    {
        bornTime = Time.time;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(destroyOnCollide)
            Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (destroyOnCollide)
            Destroy(gameObject);
    }


    private void Update()
    {
        if(Time.time > bornTime + lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(debris)
            Instantiate(debris, transform.position, Quaternion.identity, transform.parent);
    }
}
