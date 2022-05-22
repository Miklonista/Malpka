using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData",menuName = "Enemies/NewEnemyData", order = 1)]
public class EnemyStatsSO : ScriptableObject
{
    public float movementSpeed;
    public float attackRange;
    public float damagePoints;
}
