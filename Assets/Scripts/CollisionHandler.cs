using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Player");
        MovePlayer movePlayer = player.GetComponent<MovePlayer>();
        GameObject.Destroy(gameObject);

        if(gameObject.Equals(GameObject.Find("MoveLeftEnabler")))
        {
            movePlayer.canMoveLeft = true;
        }

        if (gameObject.Equals(GameObject.Find("JumpEnabler")))
        {
            movePlayer.collectedJumpEnabler = true;
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.Find("Player");
        MovePlayer movePlayer = player.GetComponent<MovePlayer>();

        if (gameObject.name == "Tilemap_Base")
        {
            movePlayer.canJump = true;
        }
    }*/
}
