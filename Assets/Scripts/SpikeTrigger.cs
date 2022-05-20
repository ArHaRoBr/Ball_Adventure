using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrigger : MonoBehaviour
{

    public GameObject[] player;

    void OnTriggerEnter2D(Collider2D obj)
    {

        if (obj.tag == "Player")
        {
            for (int i = 0; i < player.Length; i++)
            {
                if (player[i].activeSelf) player[i].GetComponent<PlayerMoving>().Health -= 10f; //check what object is active and then kill it =)
            }
        }

    }
}
