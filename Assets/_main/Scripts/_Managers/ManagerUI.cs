using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class ManagerUI : MonoBehaviour
    {
        public GameObject ingredientsPanel;
        public GameObject ingredientsContainer;
        public GameObject ingredientBtn_pfb;

        private void Awake()
        {
            ManagerStatic.uiManager = this;
        }

        public void ToggleIngredientsPanel(bool _bool)
        {
            if (_bool)
            {
                foreach(Transform t in ingredientsContainer.transform)
                {
                    Destroy(t.gameObject);
                }

                List<InventoryItem> ings = ManagerStatic.inventoryManager.ingredients;
                for (int i = 0; i < ings.Count; i++) {
                    GameObject ing = Instantiate(ingredientBtn_pfb, ingredientsContainer.transform);
                    ing.GetComponent<InventoryItem_Btn>().SetIngredient(ings[i].stats.ingredientSpr, ings[i].stats.ingredientName, ings[i].qty, ings[i].stats);
                }
            } else
            {
                foreach (Transform t in ingredientsContainer.transform)
                {
                    Destroy(t.gameObject);
                }
            }

            ingredientsPanel.SetActive(_bool);
        }
    }
}
