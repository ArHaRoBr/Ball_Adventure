using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushAnimation : MonoBehaviour
{
    public GameObject mushroom;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            mushroom.GetComponent<Animation>().Play("Mushroom");
        }
    }
}
