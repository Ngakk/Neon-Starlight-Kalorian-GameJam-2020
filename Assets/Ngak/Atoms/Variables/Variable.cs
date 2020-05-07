using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void VariableEvent();

public class Variable : ScriptableObject
{
    public VariableEvent onSet;

    public virtual object GetValue() { return 0; }
    public virtual void ValueChanged()
    {
        onSet?.Invoke();
    }
}
