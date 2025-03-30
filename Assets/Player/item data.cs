using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdata : MonoBehaviour
{

    public enum Item
    {
        apple,
        Oxygen_cylinders,




    }
   public Item Items ;
    public stat stat;
    //List<int> numbers = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            item();
            Destroy(gameObject);
        }
    }
    void item()
    {
        switch (Items)
        {
            case Item.apple:
                stat.Health += 50; 
                break;
                
            case Item.Oxygen_cylinders:
                stat.oxygen += 25;
                break;

            default:
                break;
        }

    }
    }
        

