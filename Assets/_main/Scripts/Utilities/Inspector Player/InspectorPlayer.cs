using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InspectorPlayer : MonoBehaviour
{
    public UnityEvent unityEvent;
    public KeyCode keyCodeToPlay;

    public void PlayEvent()
    {
        unityEvent?.Invoke();
    }

    private void Update()
    {
        if(Input.GetKeyDown(keyCodeToPlay))
        {
            PlayEvent();
        }
    }
}
