using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float movementSpeed;
    private Vector2 startPoint;
    public Vector2 endPoint;

    private Vector3 currentPosition;
    [SerializeField] private bool shouldMoveLeft = true;
    private float currentSpeed;

    void Start()
    {
        startPoint = transform.position;
        currentPosition = transform.position;

    }
    void FixedUpdate()
    {
        if (shouldMoveLeft)
        {
            currentSpeed = -startPoint.x * movementSpeed * Time.deltaTime;
            currentPosition.x += currentSpeed;
            this.gameObject.transform.position = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);
            if (currentPosition.x <= endPoint.x) shouldMoveLeft = false;

        }
        else
        {
            currentSpeed = startPoint.x * movementSpeed * Time.deltaTime;
            currentPosition.x += endPoint.x * movementSpeed * Time.deltaTime;
            this.gameObject.transform.position = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);
            if (currentPosition.x >= startPoint.x) shouldMoveLeft = true;
        }


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.transform.parent.position = new Vector2(this.transform.position.x, collision.transform.position.y);
    }
}
