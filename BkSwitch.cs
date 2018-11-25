using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkSwitch : MonoBehaviour {

    Bk2 bkk2;
    //Rigidbody2D rb;
    public GameObject go;
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRenderer;
    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        spriteRenderer = go.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Aicii is");
            spriteRenderer.sprite = sprite2;
            //bkk2.schimba();
            // StartCoroutine(Teleport());
        }
    }

    //IEnumerator Teleport()
    //{
        //yield return new WaitForSeconds(seconds);
        //Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    //}
}
