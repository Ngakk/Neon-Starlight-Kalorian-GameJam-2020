using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers {
    public class ManagerInventory : MonoBehaviour
    {
        public List<InventoryItem> ingredients = new List<InventoryItem>();

        private void Awake()
        {
            ManagerStatic.inventoryManager = this;
        }

        public void AddIngredient(InventoryItem_SO _invItem)
        {
            bool itemExists = false;
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients[i].stats == _invItem)
                    itemExists = true;
            }

            if (itemExists)
            {
                ingredients[0].AddQuantity(1);
            } else
            {
                InventoryItem newItem = new InventoryItem();
                newItem.stats = _invItem;
                newItem.qty = 1;
                ingredients.Add(newItem);
            }
        }

        public void UseIngredient(InventoryItem_SO _invItem)
        {
            bool itemExists = false;
            int itemIndex = -1;
            for(int i = 0; i < ingredients.Count; i++)
            {
                if (_invItem == ingredients[i].stats)
                {
                    itemExists = true;
                    itemIndex = i;
                }
            }

            if (itemExists)
            {
                ingredients[itemIndex].AddQuantity(-1);
                if (ingredients[itemIndex].qty <= 0)
                {
                    ClearIngredient(ingredients[itemIndex]);
                }
            } else
            {
                Debug.LogError(_invItem + " does not exists in the inventory");
            }
                
        }

        public void ClearIngredient(InventoryItem _invItem)
        {
            ingredients.Remove(_invItem);
        }

        public void ClearAllIngredients()
        {
            ingredients.Clear();
        }
    }
}
