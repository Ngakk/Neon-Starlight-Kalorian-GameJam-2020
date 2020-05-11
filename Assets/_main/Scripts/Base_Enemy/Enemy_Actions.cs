using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Managers;

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
    public List<GameObject> drops;
    public Transform pivotLoot;
    public GameObject dropsList;
    public GameObject dropPfb;

    private void Start() 
    {
        foreach(var x in chance)
        {
            total += x.percentage;
        }
    }

    public void DropLoot()
    {
        int drop = UnityEngine.Random.Range(2, 4);
        drops = new List<GameObject>();
        for(int i = 0; i < drop; i++)
        {
            randomNumber = UnityEngine.Random.Range(0, total);
            foreach(var x in chance)
            {
                if(randomNumber <= x.percentage)
                {
                    Debug.Log("Loot de esto: " +  x.objectToSpawn.name);
                    drops.Add(x.objectToSpawn);
                }
                else
                {
                    randomNumber -= x.percentage;
                }
            }
        }
        Vector3 startCoodenate = pivotLoot.transform.position;
        startCoodenate.x = 1f * drop - 0.5f;
        
        foreach(Transform t in dropsList.transform)
        {
            Destroy(t.gameObject);
        }
        
        for(int i = 0; i < drops.Count; i++)
        {
            GameObject go = Instantiate(drops[i], startCoodenate - new Vector3(2f * i, 0.0f, 0.0f), Quaternion.identity); 
            go.transform.SetParent(pivotLoot);
            ManagerStatic.inventoryManager.AddIngredient(drops[i].GetComponent<Adder_Inventory>().myIyem, 3);

            GameObject dp = Instantiate(dropPfb, dropsList.transform);
            dp.GetComponent<dropPfb>().SetDropUI(drops[i].GetComponent<Adder_Inventory>().myIyem.ingredientSpr, drops[i].GetComponent<Adder_Inventory>().myIyem.ingredientName, 3);
        }
    }
}
