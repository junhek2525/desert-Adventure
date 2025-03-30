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
        textchange.text = texts[ints];
        

    }
}
