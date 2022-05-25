using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpawner : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    private float xPos;
    private float yPos;
    private float currentSpeed;
    // Update is called once per frame
    private void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
    }
    void Update()
    {
        xPos += xSpeed * Time.deltaTime;
        this.gameObject.transform.position = new Vector3(xPos, 10.1595602f, 0.0720190331f);
        Debug.Log(gameObject.transform.position);
    }
}
