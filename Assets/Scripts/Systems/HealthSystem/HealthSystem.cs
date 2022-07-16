using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class HealthSystem : MonoBehaviour
{
    [SerializeField] 
    protected float maxHP = 100;

    protected Animator animator;
    protected virtual float HP { get; set; }
    protected virtual void Start()
    {
        HP = maxHP;
        animator = GetComponent<Animator>();
    }
    public virtual void TakeDamage(float dmgValue)
    {
        Debug.Log(gameObject.name);
        HP -= dmgValue;
        Debug.Log(HP);
        if (HP <= 0)
        {
           Die();
        }
    }
    public virtual void Heal(float healValue)
    {
        HP += healValue;
        if (HP > maxHP) HP = maxHP;
        Debug.Log(HP);
        
    }
    protected abstract void Die();
}
