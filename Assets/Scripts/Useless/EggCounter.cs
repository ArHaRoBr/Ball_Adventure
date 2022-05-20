/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EggCounter : MonoBehaviour
{
    TMP_Text counterText;
    GameObject eggCounter;

    void Start()
    {
        counterText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != GetEgg.totalEggs.ToString())
        {
            counterText.text = GetEgg.totalEggs.ToString();
        }
    }
}
*/