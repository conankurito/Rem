using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : Interactable
{
    public float health = 50;
    //public float getData;
    public WeaponManager data;
    public HealtherBar healtherBar;


    private void Start()
    {
    }
    // Start is called before the first frame update
    protected override void Interact()
    {
        takeDamage(data.equippedWeapon.damage);
    }

    public void takeDamage(float damage)
    {
        health -= damage;
        healtherBar.SetHealth(health);
        if (health <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject, 3);
    }
}
