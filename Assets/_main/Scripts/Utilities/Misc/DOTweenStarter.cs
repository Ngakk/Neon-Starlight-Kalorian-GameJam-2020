using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DOTweenStarter : MonoBehaviour
{
    public bool recycleAllByDefault, useSafeMode;
    public LogBehaviour logBehaviour;

    void Start()
    {
        DOTween.Init(recycleAllByDefault, useSafeMode, logBehaviour);
    }
}
