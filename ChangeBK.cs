using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBK : MonoBehaviour {

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here
    public GameObject go;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }



    



    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Aicii");
            if (spriteRenderer.sprite == sprite1) 
            {
                spriteRenderer.sprite = sprite2;
            }
            else
            {
                spriteRenderer.sprite = sprite1; 
            }
        }
    }

    void ChangeTheDamnSprite()
    {
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
