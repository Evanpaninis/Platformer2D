using System;
using UnityEngine;

public class damageSystem : MonoBehaviour
{
    public int damage;
    private Vector3 direction;

    public int knockback;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            direction = this.transform.position - other.transform.position;
            
            other.gameObject.GetComponent<Player>().onDamage(damage, direction, knockback);
            
            
        }
        
    }
}
