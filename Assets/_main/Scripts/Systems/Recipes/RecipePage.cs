using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipePage : MonoBehaviour
{
    public Sprite defaultSpr;
    public Image recipeSprite;
    public TextMeshProUGUI recipeName;
    public GameObject ingredientsPanel;
    public GameObject ingredientElementPrefab;

    public void SetRecipePage(Sprite _spr, string _name, List<InventoryItem_SO> _ingredients)
    {
        recipeSprite.sprite = _spr;
        recipeName.text = _name;

        foreach(Transform t in ingredientsPanel.transform)
        {
            Destroy(t.gameObject);
        }

        for (int i = 0; i < _ingredients.Count; i++)
        {
            Debug.Log(ingredientElementPrefab.GetComponent<RecipeIngredientElement>());

            GameObject ing = Instantiate(ingredientElementPrefab, ingredientsPanel.transform);
            ing.GetComponent<RecipeIngredientElement>().SetIngredient(_ingredients[i].ingredientSpr, _ingredients[i].ingredientName);
        }
    }

    public void ClearPage()
    {
        recipeSprite.sprite = defaultSpr;
        recipeName.text = "______________";

        foreach(Transform t in ingredientsPanel.transform)
        {
            Destroy(t.gameObject);
        }
    }
}
