using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newIngredient", menuName = "Ingredient")]

public class InventoryItem_SO : ScriptableObject
{
    public Sprite ingredientSpr;
    public string ingredientName;
}
