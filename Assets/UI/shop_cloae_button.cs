using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class shop_cloae_button : MonoBehaviour
{

    public UnityEngine.UI.Button button_close_shop;
    public Button_Shop button_shop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick()
    {
        // isTrue ���� ������Ŵ
        button_shop.store = false;

        // ����� �� Ȯ��
        //Debug.Log("isTrue: " + isTrue);
    }
}
