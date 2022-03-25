using System;
using UnityEngine;

public abstract class HealthSystem : MonoBehaviour
{
    [SerializeField] 
    protected float maxHP = 100;

    protected virtual float HP { get; set; }
       
    private void Start()
    {
        HP = maxHP;
    }

    public virtual void TakeDamage(int dmgValue)
    {
        HP -= dmgValue;
        Debug.Log(HP);
        if (HP <= 0)
        {
           Die();
        }
    }

    public virtual void Heal(int HealValue)
    {
        HP += HealValue;
        if (HP > maxHP) HP = maxHP;
        Debug.Log(HP);
        
    }
    protected abstract void Die();
}
