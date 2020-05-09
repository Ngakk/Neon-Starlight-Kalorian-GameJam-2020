using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClamidiaCharco : MonoBehaviour
{
    public GameObject hitboxHolder;

    public float lifeTime = 5f;
    private float timeToDisable = 0.2f;

    private float lastBornTime;
    private float lastEnabledTime;

    private bool activated;

    public void Activate()
    {
        lastEnabledTime = Time.time;
        hitboxHolder.SetActive(true);
        lastBornTime = Time.time;
        activated = true;
    }

    private void Start()
    {
        activated = false;
        hitboxHolder.SetActive(false);
    }

    private void Update()
    {
        if (!hitboxHolder.activeSelf) hitboxHolder.SetActive(true);

        if(Time.time > lastEnabledTime + timeToDisable)
        {
            hitboxHolder.SetActive(false);
            lastEnabledTime += timeToDisable;
        }

        if(Time.time > lastBornTime + lifeTime)
        {
            SelfDestroy();
        }
    }

    private void SelfDestroy()
    {
        hitboxHolder.SetActive(false);
        activated = false;
    }
}
