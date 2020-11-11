using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //좌
        {
            transform.position += Vector3.left * PlayerSpeed * Time.smoothDeltaTime;
        }
        if (Input.GetKey(KeyCode.D)) //우
        {
            transform.position += Vector3.right * PlayerSpeed * Time.smoothDeltaTime;
        }
        if (Input.GetKey(KeyCode.W)) //상
        {
            transform.position += Vector3.up * PlayerSpeed * Time.smoothDeltaTime;
        }
        if (Input.GetKey(KeyCode.S)) //하
        {
            transform.position += Vector3.down * PlayerSpeed * Time.smoothDeltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Laser")
        {
            Debug.Log("Player Die");
            Destroy(gameObject);
        }
    }
}

