using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float Health;

    public float maxhealth = 100f;

    public float damage;

    public Image HealthBar;

    //EnemyAI agent;


    // Start is called before the first frame update
    void Start()
    {
        Health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(Health/maxhealth, 0, 1);
    }

    //void PlayerHP()
    //{
    //    Health = 100f;
    //}
}
