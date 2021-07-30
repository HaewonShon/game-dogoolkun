using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // should get weapon object later
    public Weapon weapon;

    [SerializeField] LayerMask enemyLayer;

    private float attackTimer;

    private void Start()
    {
        weapon = GetComponentInChildren<Weapon>();
        attackTimer = 0f;
    }
    
    void Update()
    {
        if(attackTimer > 0f)
        {
            attackTimer -= Time.deltaTime;
        }
        else
        {
            // attack
            if(Input.GetKey(KeyCode.P) == true)    
            {
                attackTimer = weapon.attackDelay;
                Collider2D[] enemiesToAttack = Physics2D.OverlapBoxAll(new Vector2(transform.localPosition.x, transform.localPosition.y) + weapon.attackPosition, weapon.attackRange, 0, enemyLayer);
                for(int i = 0; i < enemiesToAttack.Length; ++i)
                {
                    Debug.Log("ATTACK!!!" + enemiesToAttack[i].gameObject.name);
                    enemiesToAttack[i].GetComponent<Enemy>().OnAttack(weapon.damage);
                }
            }
        }        
    }

    // change to newWeapon
    void ChangeWeapon(Weapon newWeapon)
    {
        Destroy(weapon);
        weapon = newWeapon;

        
    }
    
    private void OnDrawGizmosSelected() // attack range
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(new Vector2(transform.localPosition.x, transform.localPosition.y) + weapon.attackPosition, weapon.attackRange);
    }
}
