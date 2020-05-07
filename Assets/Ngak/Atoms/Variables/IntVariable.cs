using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Int Variable", menuName = "Variables/Int Variable")]
public class IntVariable : Variable
{
    [SerializeField] private int value;

    public int Value
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
