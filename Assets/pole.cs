using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pole : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.Win ();
    }





}
