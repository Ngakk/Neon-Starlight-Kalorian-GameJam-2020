﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

[CreateAssetMenu(fileName = "newRecipe", menuName = "Recipe")]

public class Recipe_SO : ScriptableObject
{
    public Sprite recipeSpr;
    public string recipeName;
    public List<InventoryItem_SO> ingredients = new List<InventoryItem_SO>();
}
