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
    public Image[] images;  // �̹������� ������ �迭
    public Sprite[] sprites;  // ������ ��������Ʈ��
    public GameManager gameManager;

    public shopText shopTexts;
    public shopText shopTextnumber;

    public EquipmentSystem equipmentSystem;
    void Start()
    {
        //if (Image != null)
        //{
        //    // �̹����� Ŭ���Ǿ��� �� ȣ��� �޼��带 ����
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
            equipmentSystem.upgrade(upgrades[number]); //�ƿ�
            number++;
            //upgrade[number] += 1 ;
            
        }
    }
}