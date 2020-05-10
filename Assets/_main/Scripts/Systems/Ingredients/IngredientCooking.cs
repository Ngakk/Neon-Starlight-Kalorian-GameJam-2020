using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class IngredientCooking : MonoBehaviour
{
    public List<InventoryItem_SO> chosenIngredients = new List<InventoryItem_SO>();

    public void SelectIngredient(InventoryItem_SO _ingredient)
    {
        if (chosenIngredients.Count < 3)
        {
            chosenIngredients.Add(_ingredient);
        }
    }
    
    public void DeselectIngredient(InventoryItem_SO _ingredient)
    {
        if (chosenIngredients.Contains(_ingredient))
        {
            chosenIngredients.Remove(_ingredient);
        }
    }
}
