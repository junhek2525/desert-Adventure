using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // ȭ���� �߻�� �� ���� �ð� �� �ڵ����� ����
        Destroy(gameObject, 5f); // 5�� �� ȭ�� ����
    }

    void Update()
    {
        //Vector2 direction = 
        // ȭ���� �������� ��� �̵��ϵ���
        //transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ��ü�� �����̵��� �浹 �� ȭ�� ����
        Destroy(gameObject);
    }
}
