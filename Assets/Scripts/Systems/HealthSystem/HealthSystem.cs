using System;
using UnityEngine;
using UnityEngine.UI;

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
        Debug.Log(gameObject.name);
        HP -= dmgValue;
        Debug.Log(HP);
        if (HP <= 0)
        {
           Die();
        }
    }
    public virtual void Heal(int healValue)
    {
        HP += healValue;
        if (HP > maxHP) HP = maxHP;
        Debug.Log(HP);
        
    }
    protected abstract void Die();
}
