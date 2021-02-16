using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbarUI : MonoBehaviour
{
    public Transform Hpbarholder;

    public Text currentHpText;
    public Text maxHpText;

    public float hpPercentage = 1;

    void Update()
    {
        hpPercentage = (float)PlayerController.instance.currentHP / (float)PlayerController.instance.maxHP;
        Hpbarholder.localScale = new Vector3(hpPercentage, 1, 1);

        currentHpText.text = PlayerController.instance.currentHP.ToString();
        maxHpText.text = PlayerController.instance.maxHP.ToString();
    }

}
