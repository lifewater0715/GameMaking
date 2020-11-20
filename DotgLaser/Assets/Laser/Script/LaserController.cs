using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public GameObject Laser1;
    public GameObject Laser1Instantiate;
    public GameObject Laser2;
    public GameObject Laser2Instantiate;

    public bool updown;
    public bool Laser1work = false;
    public bool RightLaft;
    public bool Laser2work = false;

    public float Timer1;
    private float _Timer1;
    public float Timer2;
    private float _Timer2;
    // Start is called before the first frame update
    void Start()
    {
        Laser1work = true;
        Laser2work = true;

        _Timer1 = Timer1;
        _Timer2 = Timer2;
    }
    // Update is called once per frame
    void Update()
    {
        Laser1Awake();

        Laser2Awake();
    }
    public void Laser1Awake()
    {
        Timer1 -= Time.smoothDeltaTime;
        if (Timer1 <= 0)
        {
            Timer1 = _Timer1;
            var Randupdown = Random.Range(-1, 2);
            if (Randupdown == 0) updown = true;
            else updown = false;
            var XRandpont = Random.Range(8f, -8f);
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
    public void Laser2Awake()
    {
        Timer2 -= Time.smoothDeltaTime;
        if (Timer2 <= 0)
        {
            Timer2 = _Timer2;

            var RandRightLaft = Random.Range(-1, 2);
            if (RandRightLaft == 0) RightLaft = true;
            else RightLaft = false;
            var YRandpont = Random.Range(4f, -4f);
            LasreType2(RightLaft, YRandpont);
        }
    }
    public void LasreType2(bool RightLaft, float Ypoint)
    {
        Laser2Instantiate = GameObject.Instantiate(Laser2);
        if (RightLaft == true)
        {
            Laser2Instantiate.transform.localPosition = new Vector2(10,Ypoint);
        }
        else
        {
            Laser2Instantiate.transform.localPosition = new Vector2(-10,Ypoint);
        }

    }
}