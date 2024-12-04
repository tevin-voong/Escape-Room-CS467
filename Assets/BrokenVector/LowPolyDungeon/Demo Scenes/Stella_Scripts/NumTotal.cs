using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumTotal : MonoBehaviour
{

    public TextMeshProUGUI numCounter;
    public int numVal = 00;
    private bool stillCounting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numCounter.text = "FALL 20__";
    }

    public void IncTotal()
    {
        if (!stillCounting)
        {
            // Trying co-routine to start keeping track of num value
            StartCoroutine(NumTally());
        }
    }

    IEnumerator NumTally()
    {
        // Set flag to true to start counting
        stillCounting = true;

        int targetNum = 24;

        while (numVal < targetNum)
        {
            // Increment user input
            numVal++;

            // Update display number
            if (numVal < 10)
            {
                numCounter.text = "FALL 200" + numVal;
            }
            else
            {
                numCounter.text = "FALL 20" + numVal;
            }

            yield return new WaitForSeconds(0.01f);

        }

        // Set flag to false assuming counting is done
        stillCounting = false;

    }


}



