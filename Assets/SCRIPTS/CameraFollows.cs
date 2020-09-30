using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public GameObject follow;
    //public Vector2 minCamPos;

    void FixedUpdate()
    {
        float posX = follow.transform.position.x;
        float posY = follow.transform.position.y;

        transform.position = new Vector3(posX,posY,transform.position.z);
           
    }
}