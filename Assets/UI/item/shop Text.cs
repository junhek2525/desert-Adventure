using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class shopText : MonoBehaviour
{
    public TextMeshProUGUI textchange;
    public string[] texts;
    
    //public Text text;

    public int ints = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ints < texts.Length - 1 && texts[ints +1] != null)
        {
            textchange.text = texts[ints];
        }
        else
        {
            textchange.text = "MAX";
        }
        
        

    }
}
