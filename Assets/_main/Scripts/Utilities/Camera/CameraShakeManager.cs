using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraShakeManager : MonoBehaviour
{
    void Start()
    {
        CameraShake(1f);
    }

    public void CameraShake(float duration)
    {
        Camera.main.DOShakeRotation(duration, 10, 40, 90, true);
    }
}
