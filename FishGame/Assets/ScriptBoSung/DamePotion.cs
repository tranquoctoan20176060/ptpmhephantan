using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamePotion : MonoBehaviour
{

   
    public PlayerHealthController healController;
    // Start is called before the first frame update


    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.tag == "Player")
        {
            

          
        }
    }
}