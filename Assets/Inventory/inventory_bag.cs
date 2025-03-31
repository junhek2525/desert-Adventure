using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory_bag : MonoBehaviour
{
    public Image Image;
    // Start is called before the first frame update
    void Start()
    {
        SetTransparency(0.5f); // 50% ≈ı∏Ìµµ
    }

    void SetTransparency(float alpha)
    {
        Color color = Image.color;
        color.a = Mathf.Clamp01(alpha);
        Image.color = color;
    }
}
