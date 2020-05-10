using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Setup")]
    public Hurtbox hurtbox;
    public CustomEvent onDied;
    [Header("Settings")]
    public float maxHealth;

    public float currentHealth;

    private void OnEnable()
    {
        hurtbox.onHurt += OnHurt;
    }

    private void OnDisable()
    {
        hurtbox.onHurt -= OnHurt;
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    void OnHurt(HitData _hitData)
    {
        currentHealth -= _hitData.damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            onDied?.Rise();
        }
    }
}
