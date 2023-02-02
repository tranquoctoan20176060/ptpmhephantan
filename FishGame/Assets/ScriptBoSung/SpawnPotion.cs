using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotion : MonoBehaviour
{
    public static SpawnPotion instance;
    // Start is called before the first frame update
    public GameManager Manager;
    public GameObject healthPotion;
    public GameObject damePotion;
    //public Transform spawnPosition1;
    //public Transform spawnPosition2;
    public int spawnCount;
    public Transform map;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        spawnCount = 300;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void RandomSpawn(Vector3 pos)
    {
        StartCoroutine(Spawnagain(pos));
    }
    IEnumerator Spawnagain(Vector3 position)
    {
        yield return new WaitForSeconds(5);

        int potion = Random.Range(0, 1);

        if (potion == 1)
        {
            //GameObject obj;
            Instantiate(damePotion, position, Quaternion.identity);
            //obj.transform.parent = map;
        }
        if (potion == 0)
        {
            //GameObject obj;
            Instantiate(damePotion, position, Quaternion.identity);
            //obj.transform.parent = map;
        }
        //Instantiate(healthPotion, spawnPosition1.position, Quaternion.identity);

        /*
        if (random == 68)
        {
           int potion = Random.Range(0,2);
           
           if(potion == 1 )
            {
             
                var spawnPostion_random = Random.Range(0, number);
                GameObject obj;
                
                obj.transform.parent = map;
            }
           if(potion == 0 )
            {
                var number = spawnPosition.Length;
                var spawnPostion_random = Random.Range(0, number);
                GameObject obj;
                obj = Instantiate(damePotion, spawnPosition[spawnPostion_random].position, Quaternion.identity);
                obj.transform.parent = map;
            }
        }*/
    }
}
