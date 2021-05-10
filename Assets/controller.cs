using System;
using UnityEngine;


public class Controller : MonoBehaviour {

    
    private Rigidbody2D rigidbody2d;

    private void Awake() {
  
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;

        }
        
    }
}
