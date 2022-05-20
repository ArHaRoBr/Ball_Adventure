using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GetEgg : MonoBehaviour
{
    public TMP_Text textComponent;
    public int egg;
    public AudioSource audio;
    public AudioClip pickUpSound;
    void OnTriggerEnter2D(Collider2D other) {
        //check, if gameobject has tag Coin
        if (other.tag == "Egg") {
            audio.PlayOneShot(pickUpSound);
            egg = egg + 1;
            textComponent.text = egg.ToString();
            Destroy(other.gameObject);
            
        }
    }
}
