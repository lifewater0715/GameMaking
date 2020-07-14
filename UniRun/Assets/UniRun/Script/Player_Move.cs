using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Animator m_ainmator;
    public Rigidbody2D m_rigidbody2D;

    public bool is_grownd = true;
    public bool is_die = false;

    public float m_jump = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_ainmator.SetBool("Is_grownd", is_grownd);

        if(Input.GetKeyDown(KeyCode.Space)&&m_jump<2)
        {
            m_rigidbody2D.AddForce(Vector2.up * 400);
            m_jump++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Grownd")
        {
            is_grownd = true;
            m_jump = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.otherCollider.tag == "Grownd")
        {
            is_grownd = false;
        }
    }
}
