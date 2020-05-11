using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHP : MonoBehaviour
{
    public GameObject hpPanel;
    public Health charHP;

    private void Start()
    {
        ManagerStatic.uiManager.lifePanel = hpPanel;
        ManagerStatic.uiManager.charHP = charHP;
    }
}
