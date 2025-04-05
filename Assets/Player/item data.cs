using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdata : MonoBehaviour
{

    public enum Item
    {
        apple,
        Oxygen_cylinders,
        map,
        speeder_small,
        speeder_big,
        Dumple,
        treasure_copper,
        treasure_silver,
        treasure_gold,
        treasure_diamond




    }
   public Item Items ;
    private Inventory Inventory;
    private stat stat;
    //List<int> numbers = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        //Inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("´Ú00");
        if (other.CompareTag("Player"))
        {
            Debug.Log(Inventory.Inventory_nut[Inventory.Inventory_nut.Count - 1]);
            if(Inventory.Inventory_nut[Inventory.Inventory_nut.Count - 1] == "")
            {
                if (Inventory.Maxweight > Inventory.weight)
                {
                    //Debug.Log("µüÁ¶Å¸");
                    itemget();
                    Destroy(gameObject);
                }
            }
            
        }
    }
    void itemget()
    {
        switch (Items)
        {
            case Item.apple:
                Inventory.item("apple");
                break;
            case Item.Oxygen_cylinders:
                Inventory.item("Oxygen_cylinders");
                break;
            case Item.map:
                Inventory.item("map");
                break;
            case Item.speeder_small:
                Inventory.item("speeder_small");
                break;
            case Item.speeder_big:
                Inventory.item("speeder_big");
                break;
            case Item.Dumple:
                Inventory.item("Dumple");
                break;
            case Item.treasure_copper:
                Inventory.item("treasure_copper");
                break;
            case Item.treasure_silver:
                Inventory.item("treasure_silver");
                break;
            case Item.treasure_gold:
                Inventory.item("treasure_gold");
                break;
            case Item.treasure_diamond:
                Inventory.item("treasure_diamond");
                break;
            default:
                break;

        }

    }
    }
        

