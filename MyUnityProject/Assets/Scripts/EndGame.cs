using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {


    public GameObject Win;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Dot") == null)
        {
            Win.gameObject.SetActive(true);
        }
    }
}
