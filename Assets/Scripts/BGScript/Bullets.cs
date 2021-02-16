using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Bullets
{
    //public static Bullets instance;
    public int bulletsID;
    public string bulletsName;
    public int maxBullets;
    public int currentBullets;
    public int damagePower;
    public string description;
    public Sprite sprite;
    public GameObject bulletPrefab;

    public Bullets(int newBulletsID, string newBulletsName, int newMaxBullets, int newDamagePower, string newDescription, Sprite newSprite, GameObject newBulletPrefab)
    {
        bulletsID = newBulletsID;
        bulletsName = newBulletsName;
        maxBullets = newMaxBullets;
        currentBullets = newMaxBullets;
        damagePower = newDamagePower;
        description = newDescription;
        sprite = newSprite;
        bulletPrefab = newBulletPrefab;
    }
}
