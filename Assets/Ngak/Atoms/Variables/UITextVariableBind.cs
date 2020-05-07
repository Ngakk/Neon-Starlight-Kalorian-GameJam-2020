using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextVariableBind : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text = null;
    [SerializeField] private Variable variable = null;

    private void OnEnable()
    {
        if(variable)
        {
            variable.onSet += OnChange;
        }
    }

    private void OnDisable()
    {
        if (variable)
            variable.onSet -= OnChange;
    }

    private void Start()
    {
        OnChange();
    }

    void OnChange()
    {
        text.text = variable.GetValue().ToString();
    }
}
