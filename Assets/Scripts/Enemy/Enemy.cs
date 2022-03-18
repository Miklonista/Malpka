using UnityEngine;

    public class Enemy : HealthSystem
    {
        [SerializeField] 
        private float stunCooldown = 2f;
        
        protected override void Die()
        {
            Destroy(gameObject);
            //zamiast usuwać to ogłuszyć
        }
    }
