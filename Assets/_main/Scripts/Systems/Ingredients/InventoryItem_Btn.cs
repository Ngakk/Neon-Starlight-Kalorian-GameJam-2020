using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Managers;

public class InventoryItem_Btn : MonoBehaviour
{
    public Image selectionSpr;
    public Image itemSpr;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemQty;

    private InventoryItem_SO stats;
    private Button itemBtn;
    private bool ingredientSelected;

    private void Start()
    {
        itemBtn = GetComponent<Button>();
        selectionSpr.enabled = false;
        ingredientSelected = false;
    }

    public void SetIngredient(Sprite _spr, string _name, int _qty, InventoryItem_SO _stats)
    {
        itemSpr.sprite = _spr;
        itemName.text = _name;
        itemQty.text = _qty.ToString();
        stats = _stats;
    }

    public void ToggleIngredientSelection()
    {
        if (ingredientSelected)
        {
            if (ManagerStatic.inventoryManager.cooker.DeselectIngredient(stats))
            {
                selectionSpr.enabled = false;
                ingredientSelected = false;
            }
        } else
        {
            if (ManagerStatic.inventoryManager.cooker.SelectIngredient(stats))
            {
                selectionSpr.enabled = true;
                ingredientSelected = true;
            }
        }
    }
}
