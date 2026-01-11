using UnityEngine;

public class enemyLife : MonoBehaviour
{
    public int enemyHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void onEnemyDamage(int playerDamage)
    {
        
        enemyHP = enemyHP - playerDamage;
        
        
    }
}
