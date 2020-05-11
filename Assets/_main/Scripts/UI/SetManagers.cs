using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Managers;

public class SetManagers : MonoBehaviour
{
    [Header("Navigation")]
    public GameObject _BGPanel;
    public GameObject _FGPanel;
    public GameObject _SettingsPanel;

    [Header("Inventory")]
    public GameObject _ingredientsPanel;
    public GameObject _ingredientsContainer;

    [Header("Recipe")]
    public GameObject _recipeBook;
    public RecipePage _pageA;
    public RecipePage _pageB;
    public TextMeshProUGUI _recipesUnlockedQty;
    public TextMeshProUGUI _recipesTotalQty;

    [Header("Map")]
    public GameObject _knifeTarget;
    public Animator _knifeAnim;

    private void Awake()
    {
        SetManagersUIVariables();
    }

    public void SetManagersUIVariables()
    {
        ManagerStatic.uiManager.BGPanel = _BGPanel;
        ManagerStatic.uiManager.FGPanel = _FGPanel;
        ManagerStatic.uiManager.SettingsPanel = _SettingsPanel;
        ManagerStatic.uiManager.ingredientsPanel = _ingredientsPanel;
        ManagerStatic.uiManager.ingredientsContainer = _ingredientsContainer;
        ManagerStatic.uiManager.recipeBook = _recipeBook;
        ManagerStatic.uiManager.pageA = _pageA;
        ManagerStatic.uiManager.pageB = _pageB;
        ManagerStatic.uiManager.recipesUnlockedQty = _recipesUnlockedQty;
        ManagerStatic.uiManager.recipesTotalQty = _recipesTotalQty;
        ManagerStatic.uiManager.knifeTarget = _knifeTarget;
        ManagerStatic.uiManager.knifeAnim = _knifeAnim;
    }
}
