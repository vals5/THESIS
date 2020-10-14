using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Sprite[] hearts;
    public Image heartUI;

    private Fox player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Fox>();
    }
    void Update()
    {
        heartUI.sprite = hearts[player.currHealth];
    }
}
