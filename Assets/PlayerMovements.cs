using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    private float moveinput;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input .GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }
}
