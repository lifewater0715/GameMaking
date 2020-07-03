using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 s_speed;
    public Vector3 V;
    public float speed = 15;
    public float timer = 5;
    void Start()
    {
    }
    
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = s_speed * speed;
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Destroy(gameObject);
        }

        V = rigidbody.velocity;        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null && other.attachedRigidbody.tag == "Player")
        {
            var player = other.attachedRigidbody.GetComponent<player_move>();
            player.Die();
        }
    }
}
