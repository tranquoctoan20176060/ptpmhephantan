using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IpManager : MonoBehaviour
{
    public NakamaConnection nakama;

    public InputField inputId;

    //public Text Log;

    public MainMenu mainMenu;

    public GameManager gameManager;

    string nakamaNewHost;
    // Start is called before the first frame update
    public async void SetHostIP()
    {
        nakamaNewHost = inputId.text;
        //gameManager.ConnectSerVer();

       // await nakama.ReConnect(nakamaNewHost);

        nakama.Host = nakamaNewHost;
        gameManager.Connect();

        //mainMenu.EnableFindMatchButton();
        //Log.text = nakama.Client.Host;
    }
}
