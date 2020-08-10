using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Effect;
    void Update()
    {
        RaycastHit hit;
        Ray ray= new Ray();
        ray.origin = Vector3.zero;
        ray.direction = Vector3.forward;
        if (Physics.Raycast(ray, out hit ,10f ,LayerMask.GetMask("8","9"), QueryTriggerInteraction.Ignore))
        {
            Debug.Log(hit.collider.name);

            GameObject gobj = GameObject.Instantiate(Effect, hit.point, Quaternion.identity);
            gobj.transform.localScale = 0.05f * Vector3.one;
        }

        //Physics.Raycast();

        Debug.DrawLine(Vector3.zero, Vector3.zero + Vector3.forward * 100f, Color.red);
    }
}
