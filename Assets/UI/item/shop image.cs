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
    public string[] upgrades;
    int number = 0;
    public Image[] images;  // 이미지들을 참조할 배열
    public Sprite[] sprites;  // 적용할 스프라이트들
    public GameManager gameManager;

    public shopText shopTexts;
    public shopText shopTextnumber;

    public EquipmentSystem equipmentSystem;
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
        if (GameManager.instance.moeny >= price[number] && shopTexts.texts[shopTexts.ints+1] != null)
        {
            GameManager.instance.moeny -= price[number];
            
            
            //price[number] += 1;
            Debug.Log(number);
            shopTexts.ints += 1;
            shopTextnumber.ints += 1;
            equipmentSystem.upgrade(upgrades[number]); //아오
            number++;
            //upgrade[number] += 1 ;
            
        }
    }
}