using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class ManagerUI : MonoBehaviour
    {
        [Header("Navigation")]
        public GameObject MainPanel;
        public GameObject BGPanel;
        public GameObject FGPanel;
        public GameObject SettingsPanel;

        [Header("Inventory")]
        public GameObject ingredientsPanel;
        public GameObject ingredientsContainer;
        public GameObject ingredientBtn_pfb;

        [Header("Recipe")]
        public GameObject recipeBook;
        public RecipePage pageA;
        public RecipePage pageB;
        public TextMeshProUGUI recipesUnlockedQty;
        public TextMeshProUGUI recipesTotalQty;
        private int currentPage;

        [Header("Map")]
        public GameObject knifeTarget;
        public Animator knifeAnim;

        [Header("Hud")]
        public GameObject lifePanel;
        public GameObject hpPfb;
        public Sprite fullHeart;
        public Sprite hollowHeart;
        public Health charHP;
        public GameObject loadingScreen;

        [Header("Hack")]
        public GameObject[] mainMenuObjs;

        public void ToggleMainMenu(bool _bool)
        {
            for (int i = 0; i < mainMenuObjs.Length; i++)
            {
                mainMenuObjs[i].SetActive(_bool);
            }

            if (_bool)
            {
                loadingScreen.SetActive(false);
                ChangeMenuPanel(MainPanel);
                RemoveMenuPanel(knifeTarget);
            }
        }

        private void Awake()
        {
            ManagerStatic.uiManager = this;
        }

        public void ToggleRecipeBook(bool _bool)
        {
            if (_bool)
                LoadRecipePages(0);

            recipeBook.SetActive(_bool);
        }

        public void LoadRecipePages(int _index)
        {
            int indexA = _index * 2;
            int indexB = indexA + 1;

            List<Recipe_SO> recipes = ManagerStatic.inventoryManager.recipesLearned;

            // Page A
            if (indexA < recipes.Count)
            {
                pageA.SetRecipePage(recipes[indexA].recipeSpr, recipes[indexA].recipeName, recipes[indexA].ingredients);
            } else
            {
                pageA.ClearPage();
            }

            // Page B
            if (indexB < recipes.Count)
            {
                pageB.SetRecipePage(recipes[indexB].recipeSpr, recipes[indexB].recipeName, recipes[indexB].ingredients);
            } else
            {
                pageB.ClearPage();
            }

            currentPage = _index;
        }

        public void NextRecipeBookPage()
        {
            if (currentPage < ManagerStatic.inventoryManager.recipesLearned.Count / 2)
            {
                currentPage++;
                LoadRecipePages(currentPage);
            }
        }

        public void PrevRecipeBookRecipe()
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadRecipePages(currentPage);
            }
        }

        public void ToggleIngredientsPanel(bool _bool)
        {
            if (_bool)
            {
                foreach (Transform t in ingredientsContainer.transform)
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

        public void ChangeMenuPanel(GameObject _panel)
        {
            foreach (Transform t in BGPanel.transform)
            {
                t.gameObject.SetActive(false);
            }
            foreach(Transform t in FGPanel.transform)
            {
                t.gameObject.SetActive(false);
            }

            _panel.SetActive(true);
        }

        public void AddMenuPanelDelayed(GameObject _panel)
        {
            StartCoroutine(addDelayed(_panel));
        }

        public void AddMenuPanel(GameObject _panel)
        {
            _panel.SetActive(true);
        }

        public void RemoveMenuPanel(GameObject _panel)
        {
            _panel.SetActive(false);
        }

        public void ToggleMenuPanel(GameObject _panel)
        {
            _panel.SetActive(!_panel.activeSelf);
        }

        public void ChangeSubmenuPanel(GameObject _panel)
        {
            foreach(Transform t in SettingsPanel.transform)
            {
                t.gameObject.SetActive(false);
            }

            _panel.SetActive(true);
        }

        public void UpdateRecipesUnlock()
        {
            recipesUnlockedQty.text = ManagerStatic.inventoryManager.recipesLearned.Count.ToString();
            recipesTotalQty.text = ManagerStatic.recipesManager.allRecipes.Count.ToString();
        }

        public void RepositionMapKnife(GameObject _go)
        {
            Vector3 pos = _go.transform.position;
            knifeTarget.transform.position = pos;
            knifeAnim.SetTrigger("ThrowKnife");
        }

        public void UpateCharHP()
        {
            foreach(Transform t in lifePanel.transform)
            {
                Destroy(t.gameObject);
            }

            for (int i = 0; i < charHP.maxHealth; i++)
            {
                GameObject heart = Instantiate(hpPfb, lifePanel.transform);
                if (charHP.currentHealth > i)
                {
                    heart.GetComponent<Image>().sprite = fullHeart;
                } else
                {
                    heart.GetComponent<Image>().sprite = hollowHeart;
                }
            }
        }

        IEnumerator addDelayed(GameObject _panel)
        {
            yield return new WaitForSeconds(0.5f);
            AddMenuPanel(_panel);
        }
    }
}
