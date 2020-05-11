using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClamidiaCharco : MonoBehaviour
{
    public GameObject hitboxHolder;
    public SpriteRenderer sprite;
    public bool startActivated = false;

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
        if (sprite)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1);
            sprite.DOColor(new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0), lifeTime + 0.25f).SetEase(Ease.InQuad);
        }
    }

    private void Start()
    {
        if (!startActivated)
        {
            activated = false;
            hitboxHolder.SetActive(false);
            if (sprite)
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0);
        }
        else
        {
            activated = true;
        }
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

        if (lifeTime != 0)
        {
            if (Time.time > lastBornTime + lifeTime)
            {
                SelfDestroy();
            }
        }
    }

    private void SelfDestroy()
    {
        hitboxHolder.SetActive(false);
        activated = false;
    }

    private void OnDisable()
    {
        DOTween.Clear();
    }
}
