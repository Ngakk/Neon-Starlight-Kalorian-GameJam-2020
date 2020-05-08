using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VariableEventListener : MonoBehaviour
{
    [SerializeField] private Variable variable = null;
    [SerializeField] private UnityEvent events = null;

    private void OnEnable()
    {
        if (variable)
        {
            variable.onSet += OnChange;
        }
    }

    private void OnDisable()
    {
        if (variable)
            variable.onSet -= OnChange;
    }

    private void OnValidate()
    {
        
    }

    void OnChange()
    {
        events?.Invoke();
    }
}
