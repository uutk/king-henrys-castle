﻿using UnityEngine;

public class StaticStaminaBar : MonoBehaviour
{
    public Transform player;
    private Vector3 position;

    // Update is called once per frame
    void Update()
    {
        position = Camera.main.WorldToScreenPoint(player.position);
        position.y += 110;
        transform.position = position;
    }
}
