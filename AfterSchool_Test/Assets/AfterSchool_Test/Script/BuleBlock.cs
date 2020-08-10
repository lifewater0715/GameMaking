using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleBlock : MonoBehaviour
{  
    private void OnMouseDown()
    {
        GameManager.Instance.Life -= 10;
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Plane")
        {
            GameManager.Instance.Score += 10;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}