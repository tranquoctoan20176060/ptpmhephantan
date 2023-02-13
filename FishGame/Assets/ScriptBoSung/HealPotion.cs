using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : MonoBehaviour
{

    public AudioSource sfx;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.transform.parent.tag == "LocalPlayer")
        {
            sfx.Play();
        }
    }
}
