using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bk2 : MonoBehaviour {

    //Rigidbody2D rb;
    //public GameObject go;
    private SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    public void schimba()
    {
        Debug.Log("Schimba");
        if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
        }
    }



    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Aicii");
            if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
            {
                spriteRenderer.sprite = sprite2;
            }
            else
            {
                spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
            }
        }
    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.name.Equals("Player"))
        // Debug.Log("A cazut marul");

    }
}
