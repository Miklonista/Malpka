using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    public static HPManager Instance;
    
    [SerializeField] 
    private int maxHp = 100;
    
    private int hp = 0;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        hp = maxHp;
    }

    public void TakeDamage(int dmgValue)
    {
        hp -= dmgValue;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }


}
