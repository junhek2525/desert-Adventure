using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat : MonoBehaviour
{
    public float Health;
    public float MaxHealth = 100;
    public float oxygen ;
    public float Maxoxygen = 100;
    
    public float Invincibility;
    public float MaxInvincibility = 1f;
    public float Oxygen_consumptiondown = 1;

    public float Damager = 10;
    public float attack_speed = 0.5f;
    public int stage = 0;

    public float[] range = {1f,1f,1f };

    

    //public int money = 0 ;




    float time;

    public HpUl HpUl;
    public oxygenUI oxygenUI;

    // Start is called before the first frame update
    void Start()
    {
        oxygen = Maxoxygen;
        Health = MaxHealth;
        HpUl.MaxHealth(MaxHealth);
        oxygenUI.Maxoxygen(Maxoxygen);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(time);
        time += Time.deltaTime;
        HpUl.SetHealth(Health);
        oxygenUI.Setoxygen(oxygen);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Damage(10);
        //}
        if(time >= 1 )
        {
            Oxygen_consumption(Oxygen_consumptiondown);
            time = 0;
            
        }
        
        if(Invincibility>0)
        {
            Invincibility -= Time.deltaTime;
        }
        
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("enemy"))
    //    {
    //        Damage(10);

    //    }
    //}
    public void Damage(float Damage)
        {
            //throw new NotImplementedException();
            Health -= Damage;
        }
    void Oxygen_consumption(float consuming)
        {
            oxygen -= consuming;
        }
}
