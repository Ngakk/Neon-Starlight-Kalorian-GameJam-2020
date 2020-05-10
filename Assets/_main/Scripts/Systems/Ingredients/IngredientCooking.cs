using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class IngredientCooking : MonoBehaviour
{
    public List<InventoryItem_SO> chosenIngredients = new List<InventoryItem_SO>();
    public RecipeInfo recipeInfo;

    public bool SelectIngredient(InventoryItem_SO _ingredient)
    {
        if (chosenIngredients.Count < 3)
        {
            chosenIngredients.Add(_ingredient);
            return true;
        } else
        {
            return false;
        }
    }
    
    public bool DeselectIngredient(InventoryItem_SO _ingredient)
    {
        if (chosenIngredients.Contains(_ingredient))
        {
            chosenIngredients.Remove(_ingredient);
            return true;
        } else
        {
            return false;
        }
    }

    public void testCook()
    {
        Debug.Log("Recipe Learned: " + CookChosenIngredients());
    }

    public Recipe_SO CookChosenIngredients()
    {
        bool validRecipe = false;
        int recipeIndex = -1;
        for (int i = 0; i < ManagerStatic.recipesManager.allRecipes.Count; i++)
        {
            if (ManagerStatic.recipesManager.allRecipes[i].ingredients.Count == chosenIngredients.Count)
            {
                bool gotAllIngredients = true;
                for (int j = 0; j < chosenIngredients.Count; j++)
                {
                    if (!ManagerStatic.recipesManager.allRecipes[i].ingredients.Contains(chosenIngredients[j]))
                    {
                        gotAllIngredients = false;
                    }
                }
                if (gotAllIngredients)
                {
                    validRecipe = true;
                    recipeIndex = i;
                }
            }
        }

        if (validRecipe)
        {
            Recipe_SO recipe = ManagerStatic.recipesManager.allRecipes[recipeIndex];

            for (int i = 0; i < chosenIngredients.Count; i++)
            {
                ManagerStatic.inventoryManager.UseIngredient(chosenIngredients[i]);
            }

            ManagerStatic.inventoryManager.LearnRecipe(recipe);
            ManagerStatic.uiManager.ToggleIngredientsPanel(true);
            recipeInfo.SetRecipeInfo(recipe.recipeSpr, recipe.recipeName, "no descriptions yet");
            chosenIngredients.Clear();
            return recipe;
        }
        else
        {
            recipeInfo.ClearInfo();
            return null;
        }
    }

    public void ClearChosenIngredients()
    {
        chosenIngredients.Clear();
    }
}
