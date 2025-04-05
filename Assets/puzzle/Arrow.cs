using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 1f;

    void Start()
    {
        // ȭ���� �߻�� �� ���� �ð� �� �ڵ����� ����
        Destroy(gameObject, 3f); // 3�� �� ȭ�� ����
    }

    void Update()
    {
        Vector2 direction = transform.position;
        // ȭ���� �������� ��� �̵��ϵ���
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ��ü�� �����̵��� �浹 �� ȭ�� ����
        Destroy(gameObject);
    }
}
