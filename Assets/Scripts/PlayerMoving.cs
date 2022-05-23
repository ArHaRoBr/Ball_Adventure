using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [Header("Ball health")]
    public float Health = 5;
    [Header("Movement settings")]
    public float speed = 5f; //�������� ��������
    public float jumpForce = 7000f; //���� ������
    public float currentSpeed;
    [Header("Statement checks")]
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isGrounded = false;
    [Header("Other")]
    public Transform spawnPoint;
    public Rigidbody2D rb; //� ������� Rigidbody 2D ����� �������������� ���������� ��������
    public GameObject ball;
    public GameObject rockBall;
    public GameObject beachBall;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(rb.position, checkRadius, whatIsGround);

        if (Health > 0) //���������� �������� ����� ��������, ���� �������� ���� ����
        {
            HandleMovement();

        }
        else Respawn();
        HandleOtherBalls();
    }


    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal"); //��������� ����������� ��������
        currentSpeed = moveX * speed;
        rb.velocity = new Vector2(currentSpeed, rb.velocity.y);
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector2.up * jumpForce); //���������� ���� ������
    }
    private void HandleOtherBalls()
    {
        if (ball.activeSelf == true)
        {
            rockBall.transform.position = ball.transform.position;
            beachBall.transform.position = ball.transform.position;
        }
        if (rockBall.activeSelf == true)
        {
            ball.transform.position = rockBall.transform.position;
            beachBall.transform.position = rockBall.transform.position;
        }
        if (beachBall.activeSelf == true)
        {
            ball.transform.position = beachBall.transform.position;
            rockBall.transform.position = beachBall.transform.position;
        }
    }
    public void Respawn() {

        
        this.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0);
        Health = 5;

    }
}
