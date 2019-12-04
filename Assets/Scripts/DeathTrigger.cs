using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public Movement player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.isDead = true;
            Time.timeScale = 0;
            Debug.Log("You died!");
        }
    }
}
