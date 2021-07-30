using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int health = 10;
    public bool isDead = false;

    void OnAttack(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            // something dead...
            isDead = true;
            transform.Rotate(new Vector3(0, 90, 0), Space.Self); 
        }
    }
}
