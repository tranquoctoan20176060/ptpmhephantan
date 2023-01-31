using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject healthPotion;
    public GameObject damePotion;
    public Transform[] spawnPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RandomSpawn();
    }
    public void RandomSpawn()
    {
        var random = Random.Range(0, 4000);
        if(random == 68)
        {
           int potion = Random.Range(0,2);
           
           if(potion == 1 )
            {
                var number = spawnPosition.Length;
                var spawnPostion_random = Random.Range(0, number);
                Instantiate(healthPotion, spawnPosition[spawnPostion_random].position, Quaternion.identity);
            }
           if(potion == 0 )
            {
                var number = spawnPosition.Length;
                var spawnPostion_random = Random.Range(0, number);
                Instantiate(damePotion, spawnPosition[spawnPostion_random].position, Quaternion.identity);
            }
        }
    }
}
