using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddlePlatform : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RiddleObj"))
        {
            door.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RiddleObj"))
        {
            door.SetActive(false);
        }
    }
}
