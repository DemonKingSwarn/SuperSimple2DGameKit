using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health playerHealth;
    public float damage = 1;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Player") 
        {
            playerHealth.DamagePlayer(damage);
        }
    }

}
