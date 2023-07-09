using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    GameObject[] kanvasinvo;

    public void TutupInfo()
    {
        GameObject[] kanvasinfo = GameObject.FindGameObjectsWithTag("Canvasinfo");

        foreach (GameObject ObyekYgDitemukan in kanvasinfo)
        {
            if (ObyekYgDitemukan.GetComponent<Canvas>().enabled)
            {
                ObyekYgDitemukan.GetComponent<Canvas>().enabled = false;
            }
        }

    }
}
