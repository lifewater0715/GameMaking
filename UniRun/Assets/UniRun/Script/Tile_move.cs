﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_move : MonoBehaviour
{
    public float m_speed;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * m_speed;
    }
}
