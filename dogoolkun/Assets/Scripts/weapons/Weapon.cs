using UnityEngine;

// Base class for weapon. every weapons will inherit this
public class Weapon : MonoBehaviour
{
    public float attackDelay;
    public Vector2 attackPosition;
    public Vector2 attackRange;
    public int damage;
}
