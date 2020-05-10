using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Managers;

public class InventoryItem_Btn : MonoBehaviour
{
    public Image itemSpr;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemQty;

    private InventoryItem_SO stats;
    private Button itemBtn;

    private void Start()
    {
        itemBtn = GetComponent<Button>();
    }

    public void SetIngredient(Sprite _spr, string _name, int _qty, InventoryItem_SO _stats)
    {
        itemSpr.sprite = _spr;
        itemName.text = _name;
        itemQty.text = _qty.ToString();
        stats = _stats;

        if (itemBtn == null)
            itemBtn = GetComponent<Button>();
        itemBtn.onClick.AddListener(() => ManagerStatic.inventoryManager.UseIngredient(stats));
    }
}
