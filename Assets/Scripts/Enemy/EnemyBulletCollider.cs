using System;
using UnityEngine;

    public class EnemyBulletCollider : Interactable
    {
        [SerializeField] private float damage;

        private void Start()
        {
            damage = 20;
        }

        protected override void OnTriggerEnter(Collider other)
        {
            base.OnTriggerEnter(other);
            other.GetComponent<HealthSystem>().TakeDamage(damage);
        }
    }
