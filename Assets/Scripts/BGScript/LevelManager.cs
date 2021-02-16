using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    private float waitToRespawn = 2; 

    private void Awake()
    {
        instance = this;
    }
  
    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCo());
    }

    private IEnumerator RespawnCo()
    {
        PlayerController.instance.gameObject.SetActive(false);
        
        yield return new WaitForSeconds(waitToRespawn);

        PlayerController.instance.gameObject.SetActive(true);
        PlayerController.instance.currentHP = 50;
        PlayerController.instance.transform.position = CheckPointController.instance.spawnPoint;
    }

}
