using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pla : MonoBehaviour
{

    public bool IJ;

    // Start is called before the first frame update
    void Start()
    {
        IJ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IJ==false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            IJ = true;
        }
    }
     void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Finish")
        {
            IJ = false; 
        }

        if (Coll.gameObject.tag == "Respawn")
        {
            Application.LoadLevel("Dinogame");
        }
    }

}
