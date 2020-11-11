using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownLaser : MonoBehaviour
{
    public Animator Laser1ainmator;
    private float Timer1=0.5f;
    private float timer1;
    void Start()
    {
        Laser1ainmator.SetBool("Laser1AniStart", true);
    }
    void Update()
    {
        Timer1 -= Time.smoothDeltaTime;
        if (Timer1 <= 0)
        {
            Laser1ainmator.SetBool("Laser1AniStart", false);
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
