using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sind_Winder_J : MonoBehaviour
{
    public float Mis_Speed =10;
    public float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Destroy(gameObject);
        }

        transform.position += transform.up * Time.deltaTime * Mis_Speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
