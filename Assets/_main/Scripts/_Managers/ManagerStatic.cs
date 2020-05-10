using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    [System.Serializable]
    public class InventoryItem
    {
        public InventoryItem_SO stats;
        public int qty;

        public void SetQuantity(int _qty)
        {
            qty = _qty;
        }

        public void AddQuantity(int _val)
        {
            qty += _val;
        }
    }

    public static class ManagerStatic
    {
        public static ManagerInventory inventoryManager;
        public static ManagerUI uiManager;
        public static ManagerAudio audioManager;
        public static ManagerRecipes recipesManager;
    }
}
