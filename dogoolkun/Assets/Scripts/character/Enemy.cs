using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public bool isDead = false;

    public void OnAttack(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        isDead = true;
        transform.Rotate(new Vector3(0, 90, 0), Space.Self); 
    }
}
