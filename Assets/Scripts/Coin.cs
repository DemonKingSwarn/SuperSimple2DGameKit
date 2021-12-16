using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score;
    //private int scoreIncrement = 1;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.tag == "coin") 
        {
            Destroy(col.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }
    }
}
