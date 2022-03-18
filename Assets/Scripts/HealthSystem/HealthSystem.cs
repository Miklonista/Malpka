using System;
using UnityEngine;

public abstract class HealthSystem : MonoBehaviour
{
    [SerializeField] 
    private int maxHP = 100;

    private int hp = 0;

    private void Start()
    {
        maxHP = hp;
    }

    protected virtual void TakeDamage(int dmgValue)
    {
        hp -= dmgValue;
        Debug.Log(hp);
        if (hp <= 0)
        {
           Die();
        }
    }

    protected abstract void Die();
}
