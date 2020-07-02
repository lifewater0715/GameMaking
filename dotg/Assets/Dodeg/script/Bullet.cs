using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 15;

    // Update is called once per frame
    public float timer = 5;
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.forward * speed);
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            bullet_die();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.tag == "Player")
        {
            var player = other.attachedRigidbody.GetComponent<player_move>();
            player.Die();
        }
    }

    public void bullet_die()
    {
        gameObject.SetActive(false);
    }
}
