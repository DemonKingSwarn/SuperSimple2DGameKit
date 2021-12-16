using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YOUWON : MonoBehaviour
{
    public GameObject youWonObj;
    public Coin scoreBadhaSale;

    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.tag == "Player") 
        {
            scoreBadhaSale.score += 200;
            youWonObj.SetActive(true);
        }
    }
}
