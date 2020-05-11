using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraShakeManager : MonoBehaviour
{
    public Camera cam;

    void Start()
    {
        //CameraShake(1f);
    }

    public void CameraShake()
    {
        cam.DOShakeRotation(1f, 5, 40, 90, true);
    }
}
