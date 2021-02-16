using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerController.instance.dealDamage(99999);
        }
    }
}
