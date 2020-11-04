﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider HealthBar;
    public float Health = 100f;

    private float _currentHealth;
    private Interface inter;

    void Start (){
        inter = GameObject.FindObjectOfType<Interface>();
        HealthBar = inter.HealthBar;
        _currentHealth = Health;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        HealthBar.value = _currentHealth;
    }

    public void Recover(float healthPoints)
    {
        if (_currentHealth + healthPoints <= 100){
            _currentHealth += healthPoints;
        }
        HealthBar.value = _currentHealth;
    }
}