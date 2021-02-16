using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectBullet : MonoBehaviour
{
    public int scoreToAdd = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<scoreManager>().addScore(scoreToAdd);
            Destroy(gameObject);
        }
    }
}
