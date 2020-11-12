using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public JoyStick joyStick;
    public float PlayerSpeed;

    private Vector3 MoveVecter;
    private Transform PlayerTransfrom;
    void Start()
    {
        PlayerTransfrom = transform;
        MoveVecter = Vector3.zero;
    }
    void FixedUpdate()
    {
        MoveVecter = GetJoystick();
        PlayerTransfrom.Translate(MoveVecter * PlayerSpeed * Time.deltaTime);
    }
    public Vector3 GetJoystick()
    {
        float X = joyStick.GetKoystickX();
        float Y = joyStick.GetKoystickY();
        MoveVecter = new Vector3(X, Y, 0);
        return MoveVecter;
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

