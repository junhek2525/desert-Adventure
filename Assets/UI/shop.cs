using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{

    public Button_Shop Button_Shop;
    public GameObject GameObject_shop;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Button_Shop.store == true)
        {
            GameObject_shop.SetActive(true);
        }
        else
        {
            GameObject_shop.SetActive(false);
        }



    }
}
