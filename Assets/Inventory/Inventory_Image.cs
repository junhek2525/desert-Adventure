using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Image : MonoBehaviour
{

    public Image image;
    //public Image[] images;
    public Sprite[] sprites;

    public int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (image != null)
            image.sprite = sprites[number];
        else
            image.sprite = null;

    }
}
