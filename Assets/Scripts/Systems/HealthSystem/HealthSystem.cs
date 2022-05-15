using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class HealthSystem : MonoBehaviour
{
    [SerializeField] 
    protected float maxHP = 100;

    [SerializeField]
    private Image hpBarImage;

    private float hp;
    protected virtual float HP 
    { 
        get => hp;
        set 
        { 
            hp = value;
            hpBarImage.fillAmount = (hp / maxHP);
        }
    }
    
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
    public virtual void Heal(int HealValue)
    {
        HP += HealValue;
        if (HP > maxHP) HP = maxHP;
        Debug.Log(HP);
        
    }
    protected abstract void Die();
}
