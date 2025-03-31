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
    public Inventory Inventory;
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
        Debug.Log("´Ú00");
        if (other.CompareTag("Player") && Inventory.Inventory_Maxnut >= Inventory.Inventory_nut.Count && Inventory.Maxweight >= Inventory.weight)
        {
            Debug.Log("µüÁ¶Å¸");
            itemget();
            Destroy(gameObject);
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

            default:
                break;
        }

    }
    }
        

