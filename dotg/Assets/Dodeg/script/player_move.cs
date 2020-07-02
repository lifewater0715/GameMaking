using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float speed=25;

    // Update is called once per frame
    void Update()
    { 
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward*speed);
            Debug.Log("W");
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back * speed);
            Debug.Log("S");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.left * speed);
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * speed);
            Debug.Log("D");
        }

       if (Input.GetKey(KeyCode.X))
        {
            Die();
            gameObject.SetActive(false);
        }
        float fireAxis = Input.GetAxis("Fire1");

       if(fireAxis>=1)
        {
            Die();
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}