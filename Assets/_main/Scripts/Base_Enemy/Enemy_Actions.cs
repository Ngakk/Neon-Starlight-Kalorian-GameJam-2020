using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class DropItemChance 
{
    public GameObject objectToSpawn;
    public float percentage;
}

public class Enemy_Actions : MonoBehaviour
{
    public DropItemChance[] chance;
    public float total;
    public float randomNumber;
    public Animator anim;

    private void Start() 
    {
        foreach(var x in chance)
        {
            total += x.percentage;
        }
    }

    public void Attack()
    {
        anim.SetTrigger("MakeDamage");
    }

    public GameObject DropLoot()
    {
        randomNumber = UnityEngine.Random.Range(0, total);
        foreach(var x in chance)
        {
            if(randomNumber <= x.percentage)
            {
                return x.objectToSpawn;
            }
            else
            {
                randomNumber -= x.percentage;
            }
        }
        return null;
    }
}
