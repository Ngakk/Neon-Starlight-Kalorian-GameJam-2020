using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHP : MonoBehaviour
{
    public GameObject hpPanel;
    public Health charHP;
    public Hurtbox hurtBox;

    private void Start()
    {
        ManagerStatic.uiManager.lifePanel = hpPanel;
        ManagerStatic.uiManager.charHP = charHP;
        ManagerStatic.uiManager.UpateCharHP();
    }

    public void OnEnable()
    {
        hurtBox.onHurt += OnHurt;
    }

    public void OnDisable()
    {
        hurtBox.onHurt -= OnHurt;
    }

    public void OnHurt(HitData data)
    {
        ManagerStatic.uiManager.UpateCharHP();
    }
}
