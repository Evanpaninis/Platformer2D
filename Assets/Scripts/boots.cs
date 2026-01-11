using UnityEngine;

public class boots : MonoBehaviour
{
    public int bootDamage;

    public enemyLife EnemyLife;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            EnemyLife = collision.gameObject.GetComponent<enemyLife>();
            EnemyLife.onEnemyDamage(bootDamage);
        }
        
    }
}
