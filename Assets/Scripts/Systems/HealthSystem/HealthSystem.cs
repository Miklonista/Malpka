using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class HealthSystem : MonoBehaviour
{
    [SerializeField] 
    protected float maxHP = 100;
    protected virtual float HP { get; set; }
    protected virtual void Start()
    {
        HP = maxHP;
    }
    public virtual void TakeDamage(float dmgValue)
    {
        HP -= dmgValue;
        if (HP <= 0)
        {
           Die();
        }
    }
    public virtual void Heal(float healValue)
    {
        HP += healValue;
        if (HP > maxHP) HP = maxHP;
    }
    protected abstract void Die();
}
