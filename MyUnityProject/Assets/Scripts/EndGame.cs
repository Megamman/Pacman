using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public GameObject WinText;
    public GameObject Pacdots;
    public GameObject Bigdots;

    public void Win()
    {

        if (Pacdots && Bigdots == null)
        {

            // Display win Message
            WinText.SetActive(true);

            // Slow down time
            Time.timeScale = 0;

        }

    }
}
