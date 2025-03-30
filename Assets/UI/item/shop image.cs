using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class shopimage : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;

    public int[] price;
    int number =0;
    public TextMeshProUGUI[] textFields;
    public GameManager gameManager;

    public shopText shopTexts;
    public shopText shopTextnumber;
    void Start()
    {
        //if (Image != null)
        //{
        //    // 이미지가 클릭되었을 때 호출될 메서드를 설정
        //    Button button = Image.GetComponent<Button>();
        //    button.onClick.AddListener(OnImageClick);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnbuttonClick()
    {
        if (GameManager.instance.moeny >= price[number])
        {
            //GameManager.instance.moeny -= price[number];
            price[number] += 1;
            shopTexts.ints += 1;
            shopTextnumber.ints += 1;
        }
    }
}