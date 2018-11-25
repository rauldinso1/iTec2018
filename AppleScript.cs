using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleScript : MonoBehaviour {

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();	
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
            rb.isKinematic = false;
    }
    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject.name.Equals("Player"))
            Debug.Log("A cazut marul");
		
	}
}
