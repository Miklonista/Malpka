using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : HealthSystem
{
    [SerializeField]
    private Image hpBarImage;
    
    private float hp;
    protected override float HP 
    { 
        get => hp;
        set 
        { 
            hp = value;
            hpBarImage.fillAmount = (hp / maxHP);
        }
    }
    
    protected override void Die()
    {
        Debug.Log("�mier�");
        GameManager.Instance.EnableDeathScreen();
    }
}
