using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float Speed = 1.5f;
    Vector2 BgPos;
    void MoveBg()
    {
        BgPos = new Vector2(Time.time * Speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = BgPos;
    }
}
