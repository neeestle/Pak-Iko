using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TMP_Text texttimer;
    public float targettime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targettime -= Time.deltaTime;
        int t;
        t= System.Convert.ToInt32(targettime);
        texttimer.text  = t.ToString();
        
     if (targettime==0.0f){ }
    }
}
