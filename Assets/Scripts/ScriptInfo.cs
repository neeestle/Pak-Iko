using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptInfo : MonoBehaviour
{
    public Canvas Canvasinfo;
    // Start is called before the first frame update
    void Start()
    {
        Canvasinfo.GetComponent<Canvas>().enabled = false;
       
    }

    // Update is called once per frame
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag=="Player"&& !Canvasinfo.GetComponent<Canvas>().enabled)
        {
            Canvasinfo.GetComponent<Canvas>().enabled = true;
        }
    }
   
}
