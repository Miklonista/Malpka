using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : HealthSystem
{
    public Image cooldown;
    
    protected override float HP 
    { 
        get => base.HP;
        set 
        { 
            base.HP = value;
            cooldown.fillAmount = (HP / maxHP);
           /* Debug.Log(HP);
            Debug.Log(cooldown.fillAmount);
            Debug.Log(maxHP);*/
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
