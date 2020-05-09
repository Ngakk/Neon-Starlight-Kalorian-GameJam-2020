using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipeIngredientElement : MonoBehaviour
{
    public Image ingredientSprite;
    public TextMeshProUGUI ingredientName;

    public void SetIngredient(Sprite _spr, string _name)
    {
        ingredientSprite.sprite = _spr;
        ingredientName.text = _name;
    }
}
