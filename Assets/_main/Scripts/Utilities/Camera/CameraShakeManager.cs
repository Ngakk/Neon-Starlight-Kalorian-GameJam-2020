using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraShakeManager : MonoBehaviour
{
    void Start()
    {
        //CameraShake(1f);
    }

    public void CameraShake()
    {
        Camera.main.DOShakeRotation(1f, 5, 40, 90, true);
    }
}
