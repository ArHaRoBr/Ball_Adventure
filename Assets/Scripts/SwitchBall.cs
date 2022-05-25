using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBall : MonoBehaviour { 
    public GameObject ball, rockBall, beachBall;


    int whichBallIsOn = 1;

    public void SwitchPlayer(){
        switch (whichBallIsOn) {
            case 1:
                ball.SetActive(false);
                rockBall.SetActive(true);
                rockBall.transform.position = ball.transform.position;
                whichBallIsOn = 2;
                rockBall.GetComponent<Rigidbody2D>().velocity = new Vector2(ball.GetComponent<PlayerMoving>().currentSpeed, ball.GetComponent<Rigidbody2D>().velocity.y);

                this.GetComponentInChildren<CameraFix>().player = rockBall;
                break;
            case 2:
                rockBall.SetActive(false);
                ball.SetActive(true);
                ball.transform.position = rockBall.transform.position;
                whichBallIsOn = 1;
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(rockBall.GetComponent<PlayerMoving>().currentSpeed, rockBall.GetComponent<Rigidbody2D>().velocity.y);

                this.GetComponentInChildren<CameraFix>().player = ball;
                break;
        }
    }
}
