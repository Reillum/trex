using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public CharacterController2D control;

    public float runSpeed = 40f;

    float horizontalMove = 450f;
    bool jump = false;

    void Update(){

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    void FixedUpdate ()
    {
        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}