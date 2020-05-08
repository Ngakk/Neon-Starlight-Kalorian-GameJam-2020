using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public CustomEvent customEvent;
    public UnityEvent callbacks;

    private void OnEnable()
    {
        customEvent.Subscribe(this);
    }

    private void OnDisable()
    {
        customEvent.Unsubscribe(this);
    }

    public void OnRise()
    {
        callbacks?.Invoke();
    }
}
