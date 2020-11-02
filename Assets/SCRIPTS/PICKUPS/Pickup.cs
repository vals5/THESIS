using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private static Fox player = null;
    public int points;
    
    void Awake()
    {
        if(null == player)
        {
            player = FindObjectOfType<Fox>();
        }
    }
    void Update()
    {
        if (player.isMagnet)
        {
            var directionToPlayer = (player.transform.position - transform.position).normalized;
            transform.Translate(directionToPlayer * Time.deltaTime * player.magnetSpeed);
        }
    }
}
