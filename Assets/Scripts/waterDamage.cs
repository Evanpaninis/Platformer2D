using System;
using System.Collections;
using UnityEngine;

public class waterDamage : MonoBehaviour
{
    private bool poison = true;
    private Player player;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            if (poison)
            {
                player = other.gameObject.GetComponent<Player>();
                StartCoroutine(PoisonWater());
                poison = false;
            }
        }
    }

    private IEnumerator PoisonWater()
    {
        player.onDamage(1, Vector3.zero, 0);
        yield return new WaitForSeconds(1f);
        poison = true;
    }
    
    
}
