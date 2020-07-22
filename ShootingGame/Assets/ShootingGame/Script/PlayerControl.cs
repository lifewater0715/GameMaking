using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float PlayerSpeed;
    public float FierTimer;
    public float fierTimer;

    public Transform m_MisPoint;

    public GameObject Mis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var X = gameObject.transform.position.x;
        var Y = gameObject.transform.position.y;
        //--Move
        if (Input.GetKey(KeyCode.W) && Y <= 5.5)
        {
            transform.position += Vector3.up * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && Y >= -5.5)
        {
            transform.position += Vector3.down * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && X >= -10.5)
        {
            transform.position += Vector3.left * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && X <= 10.5)
        {
            transform.position += Vector3.right * PlayerSpeed * Time.deltaTime;
        }
        //--Shoot
        FierTimer -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && FierTimer <= 0)
        {
            Shoot();
            FierTimer = fierTimer;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }
    }

    void Shoot()
    {
        Debug.Log("발사");
        GameObject bullet = GameObject.Instantiate(Mis);
        bullet.transform.position = m_MisPoint.position;
    }   
}