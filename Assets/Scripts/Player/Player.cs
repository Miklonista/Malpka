using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] 
    private int maxHP = 100;

    private int hp = 0;

    private void Start()
    {
        maxHP = hp;
    }
    
    protected void TakeDamage(int dmgValue)
    {
        hp -= dmgValue;
        Debug.Log(hp);
    }
    protected void Die()
    {
        //wywolaj ekran koncowy i zatrzymaj gre
        //np. GameManager.Instance.ShowDeathScreen();
    }
}
