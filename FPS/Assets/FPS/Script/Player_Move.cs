using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float P_Speed = 1;
    public float ATS = 1;
    public float Timer = 1;

    public float Rebound = 10;

    public GameObject Bullet;
    public Transform A;

    // Start is called before the first frame update
    void Start()
    {
        Timer = ATS;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        float r = Random.Range(Rebound, -Rebound);
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = ATS;
            if (Input.GetMouseButton(0))
            {
                Debug.Log("발사");
                GameObject bullet = GameObject.Instantiate(Bullet);
                bullet.transform.position = transform.position;
                bullet.transform.right = transform.up + new Vector3(0, r, 0);
                var b = bullet.GetComponent<Player_Bullet>();
                b.s_speed = transform.right + new Vector3(r, 0 , 0);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * P_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * P_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * P_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * P_Speed * Time.deltaTime;
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
