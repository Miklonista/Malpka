using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : HealthSystem
{
    [SerializeField]
    private Image hpBarImage;
    
    protected override float HP 
    { 
        get => base.HP;
        set 
        { 
            base.HP = value;
            hpBarImage.fillAmount = (HP / maxHP);
        }

    }
    private void Start()
    {
        HP = maxHP;
    }
    protected override void Die()
    {
        Debug.Log("œmieræ");
        GameManager.Instance.EnableDeathScreen();
    }
}
