using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    [SerializeField] int hp = 100;

    public void TakeDamage(int attack)
    {
        hp -= attack;
        if (hp < 0)
        {
            Destroy(gameObject);
        }
    }

    
}
