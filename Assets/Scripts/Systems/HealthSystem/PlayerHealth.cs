using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : HealthSystem
{
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
    protected override void Die()
    {
        Debug.Log("œmieræ");
        GameManager.Instance.EnableDeathScreen();
    }
}
