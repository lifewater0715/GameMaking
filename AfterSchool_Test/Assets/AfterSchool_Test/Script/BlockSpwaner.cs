using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpwaner : MonoBehaviour
{
    public float Timer=5;
    public float timer=5;
    public GameObject BuleBlock;
    public GameObject RedBlock;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer<0)
        {
            Timer = timer;
            var num = Random.Range(1, 3);
            for(float i=0; i<num; i++)
            {
                var Randx = Random.Range(5, -5);
                var Randz = Random.Range(5, -5);
                var RedOrBule = Random.Range(0, 2);
                if(RedOrBule==1)
                {
                    GameObject BLOCK = GameObject.Instantiate(RedBlock);
                    BLOCK.transform.position = new Vector3(Randx, 12, Randz);
                }
                else
                {
                    GameObject BLOCK = GameObject.Instantiate(BuleBlock);
                    BLOCK.transform.position = new Vector3(Randx, 12, Randz);
                }
            }
        }
    }
}
