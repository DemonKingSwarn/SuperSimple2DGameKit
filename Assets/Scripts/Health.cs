using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [Header("Health Stuff")]
    public float startHealth = 20f;
    private float health;
    public Image healthBar;

    public GameObject player;

    public bool isDead = false;

    private void Start() 
    {
        health = startHealth;
    }

    private void Update()
    {


        if (transform.position.y <= -5.03f)
        {
            DamagePlayer(20f);
        }

    }

    public void DamagePlayer(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / startHealth;
        if (health <= 0)
        {
            player.SetActive(false);
            isDead = true;
        }
    }

}
