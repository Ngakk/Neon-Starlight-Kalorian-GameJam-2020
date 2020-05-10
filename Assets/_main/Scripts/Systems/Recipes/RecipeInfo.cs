using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipeInfo : MonoBehaviour
{
    public Sprite defaultSprite;
    public Image recipeSpr;
    public TextMeshProUGUI recipeName;
    public TextMeshProUGUI recipeDescription;

    public void SetRecipeInfo(Sprite _spr, string _name, string _description)
    {
        recipeSpr.sprite = _spr;
        recipeName.text = _name;
        recipeDescription.text = _description;
    }

    public void ClearInfo()
    {
        recipeSpr.sprite = defaultSprite;
        recipeName.text = "No Recipe";
        recipeDescription.text = "No recipe with the selected ingredients exists right now";
    }
}
