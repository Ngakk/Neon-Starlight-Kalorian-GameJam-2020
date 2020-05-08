using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class CustomEvent : ScriptableObject
{
    [System.NonSerialized] private List<EventListener> listeners = new List<EventListener>();

    public void Rise()
    {
        Debug.Log(name + " was rised");
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnRise();
        }
    }

    public void Subscribe(EventListener _el)
    {
        listeners.Add(_el);
        Debug.Log(_el.gameObject.name + " subscribed", _el.gameObject);
    }

    public void Unsubscribe(EventListener _el)
    {
        listeners.Remove(_el);
        Debug.Log(_el.gameObject.name + " unsubscribed", _el.gameObject);
    }
}
