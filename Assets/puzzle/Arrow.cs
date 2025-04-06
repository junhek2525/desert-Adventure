using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 1f;

    void Start()
    {
        // 화살이 발사된 후 일정 시간 뒤 자동으로 삭제
        Destroy(gameObject, 3f); // 3초 후 화살 삭제
        
    }

    void Update()
    {
        Vector2 direction = transform.position;
        transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime; 
        // 화살이 전방으로 계속 이동하도록
        //transform.Translate(direction * speed * Time.deltaTime);
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //if (rb != null)
        //{
        //    rb.velocity = direction * speed;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 물체가 무엇이든지 충돌 시 화살 삭제
        Destroy(gameObject);
    }
}
