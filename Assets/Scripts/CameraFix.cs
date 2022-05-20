using UnityEngine;

public class CameraFix : MonoBehaviour
{

    public GameObject player;

    public float leftBorder;
    public float rightBorder;

    void Update() { 
        if (player.transform.position.x < leftBorder) transform.position = new Vector3(leftBorder, -0.4553309f, -10f);
        else if (player.transform.position.x > rightBorder) transform.position = new Vector3(rightBorder, -0.4553309f, -10f);
        else transform.position = new Vector3(player.transform.position.x, -0.4553309f, -10f);
    }
}