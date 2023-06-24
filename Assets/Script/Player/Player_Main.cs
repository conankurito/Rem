﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Main : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    protected float GetHp;
    private Image HP_low;

    public Transform PlayerTransform;

    public HealtherBar healtherBar;
    // Start is called before the first frame update
    void Start()
    {
        HP_low = GameObject.Find("LowHP").GetComponent<Image>();
        currentHealth = maxHealth;
        healtherBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(20);
        //}

        if(currentHealth <= 10f)
        {
            HP_low.color = new Color32(255, 255, 255, 255);
        }

        else
        {
            HP_low.color = new Color32(255, 255, 255, 0);
        }
        
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healtherBar.SetHealth(currentHealth);
    }


}
