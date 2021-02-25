using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float yOffset = 20.0f;
    public GameObject player;
    private Vector2 playerPos;
    private const float Z_OFFSET = 10;

    void FixedUpdate()
    {
        playerPos = player.transform.position;
        gameObject.transform.position = new Vector3(playerPos.x, playerPos.y + yOffset, -Z_OFFSET);
    }
}
