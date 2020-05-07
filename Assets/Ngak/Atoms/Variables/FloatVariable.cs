using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float Variable", menuName = "Variables/Float Variable")]
public class FloatVariable : Variable
{
    [SerializeField] private float value;

    [System.NonSerialized] private float lastValue;

    public float Value
    {
        get { return value; }
        set
        {
            this.value = value;
            ValueChanged();
        }
    }

    public override object GetValue()
    {
        return value;
    }
}
