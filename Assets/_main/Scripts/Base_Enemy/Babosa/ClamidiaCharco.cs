using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClamidiaCharco : MonoBehaviour
{
    public GameObject hitboxHolder;
    public SpriteRenderer sprite;

    public float lifeTime = 5f;
    private float timeToDisable = 0.2f;

    private float lastBornTime;
    private float lastEnabledTime;

    private bool activated;

    public void Activate()
    {
        Invoke("RealActivate", 0.8f);
    }

    private void RealActivate()
    {
        lastEnabledTime = Time.time;
        hitboxHolder.SetActive(true);
        lastBornTime = Time.time;
        activated = true;
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1);
        sprite.DOColor(new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0), lifeTime+0.25f).SetEase(Ease.InQuad);
    }

    private void Start()
    {
        activated = false;
        hitboxHolder.SetActive(false);
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0);
    }

    private void Update()
    {
        if (!activated) return;
        if (!hitboxHolder.activeSelf)
        {
            hitboxHolder.SetActive(true);
        }

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
