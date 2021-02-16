using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int typeid = 3;

    [SerializeField]
    private int EnemyHP = 3;
    private int scoreReward = 100;

    public GameObject itemDrop;
    
    
    
    public void damageEnemy(int dmg)
    {
        EnemyHP -= dmg;

        if (EnemyHP <= 0)
        {
            Destroy(gameObject);

            FindObjectOfType<scoreManager>().addScore(scoreReward);

            int rand = Random.Range(1,100);

            if (rand <= 50)
            {
                Instantiate(itemDrop, transform.position, itemDrop.transform.rotation);
            }
        }
    }

}
