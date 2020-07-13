using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    public float B_Speed;
    public Vector3 s_speed;
    public float Timer=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0)
        {
            Destroy(gameObject);
        }
        //Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //rigidbody.velocity = s_speed * B_Speed;

        transform.position += B_Speed * s_speed * Time.deltaTime;
    }
}
