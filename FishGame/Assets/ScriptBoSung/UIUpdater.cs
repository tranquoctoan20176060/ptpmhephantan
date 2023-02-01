using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public Image healthIcon;
    public Image damageIcon;
    public Text healthText;
    public Text damageText;
    public PlayerHealthController playerHealthControls;
    public PlayerMovementController playerMove;
    public GameObject networklocal;

    private GameManager gameManager;
  

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
       
      
        if (gameManager.localPlayer != null && networklocal.tag == "LocalPlayer" )
        {
           
            // update the health icon and text
            string health_string = playerHealthControls.health.ToString();
            healthText.text = health_string;

            // update the damage icon and texth
            string sp_string = playerMove.GetComponent<PlayerMovementController>().MovementSpeed.ToString();
            damageText.text = sp_string;
            Debug.Log(sp_string);
            Debug.Log(damageText.text);
        }
        else
        {
            // hide the UI elements if the player is not a local player
            healthIcon.enabled = false;
            damageIcon.enabled = false;
            healthText.enabled = false;
            damageText.enabled = false;
        }
    }
}