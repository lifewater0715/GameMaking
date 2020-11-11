using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public GameObject Laser1;
    public GameObject Laser1Instantiate;
    public bool updown;

    public float Timer1;
    private float timer1;
    // Start is called before the first frame update
    void Start()
    {
        timer1 = Timer1;
    }

    // Update is called once per frame
    void Update()
    {
        Timer1 -= Time.smoothDeltaTime;
        if(Timer1 <= 0)
        {
            Timer1 = timer1;
            
            var Randupdown = Random.Range(-1,2);
            if (Randupdown == 0) updown = true;
            else updown = false;
            var XRandpont = Random.Range(8f,-8f);
            LasreType1(updown, XRandpont);
        }
    }
    public void LasreType1(bool updown, float Xpoint)
    {
        Laser1Instantiate = GameObject.Instantiate(Laser1);
        if(updown==true)
        {
            Laser1Instantiate.transform.localPosition = new Vector2(Xpoint, 5);
        }
        else
        {
            Laser1Instantiate.transform.localPosition = new Vector2(Xpoint, -5);
        }
        
    }
}