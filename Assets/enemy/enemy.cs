using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float Health = 50;
    public float damager = 10;

    public stat stat;

    public Transform Player;  // �÷��̾��� Transform�� ����
    public float moveSpeed = 3f;  // ���� �̵� �ӵ�
    public float chaseRange = 10f;  // �߰� ����
    public float ContactRange = 0.8f;
    

    private Rigidbody2D rb;  // Rigidbody2D ������Ʈ
    private Vector2 moveDirection;  // �̵� ����

    

    // Start is called before the first frame update

    float distanceToPlayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        distanceToPlayer = Vector2.Distance(transform.position, Player.position);  // �÷��̾�� �� ���� �Ÿ� ���
        //Debug.Log(distanceToPlayer);
        if (distanceToPlayer <= chaseRange)
            {
                Vector2 direction = (Player.position - transform.position).normalized;
                transform.position = Vector2.MoveTowards(transform.position, Player.position, moveSpeed * Time.deltaTime);
                //Debug.Log("chase");
            }
    }
    private void OnTriggerStay2D(Collider2D other)
    {


        //Debug.Log(Health);
        
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && stat.Invincibility <= 0)
        {
            Debug.Log("1");
            stat.Damage(10);
                stat.Invincibility = stat.MaxInvincibility;
                Debug.Log("attack");
            
            
        }
    }
    //private void OnTriggerEnter2D(BoxCollider2D other)
    //{

    //}
    public void TakeDamage(float damage)
    {
        Health -= damage;
    }


}
