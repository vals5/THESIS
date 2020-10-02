using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFalling : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pc2d = GetComponent<PolygonCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            rb2d.isKinematic = false;
            pc2d.isTrigger = true;
        }
    }
}
