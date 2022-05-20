using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
   //public float maxHealth = 100; //�������� ������
    public float Health = 5;
    public Rigidbody2D rb; //� ������� Rigidbody 2D ����� �������������� ���������� ��������
    public float jumpForce = 7000f; //���� ������
    public float speed = 5f; //�������� ��������

    public Transform spawnPoint;

    [SerializeField] private bool isGrounded = false;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Transform ObjectPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(rb.position, checkRadius, whatIsGround);

        if (Health > 0) //���������� �������� ����� ��������, ���� �������� ���� ����
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Space))
            {
                speed = 10f; 
            }
        
            float moveX = Input.GetAxis("Horizontal"); //��������� ����������� ��������
            rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
            // rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime); //��������� �������
            /*            if (Input.GetKeyDown(KeyCode.Space)) 
                        {
            */
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce); //���������� ���� ������
            }


        }
        else
        {
            //Destroy(gameObject);
            Respawn();
        }

    }
    public void Respawn() {

        speed = 0;
        this.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0);
        Health = 5;

    }

   /* public float ChangeHealth()
    {
       return Health = Health - 10;
    }*/

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        isGrounded = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        isGrounded = false;
    //    }
    //}
}
