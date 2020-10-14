using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Fox player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Fox>(); 
    }
    void Update()
    {
        if(transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(1);
        }
    }
}
