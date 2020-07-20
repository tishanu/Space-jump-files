using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    public GameOverText gameovertext;
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            gameovertext.enabled = true;
            FindObjectOfType<Gameover>().GameEnd();
        }
    }
}
