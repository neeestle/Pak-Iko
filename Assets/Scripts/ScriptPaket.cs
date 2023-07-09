using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPaket : MonoBehaviour
{
    GameObject mobil;
    // Start is called before the first frame update
    void Start()
    {
        mobil = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()

    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            mobil.GetComponent<Delivery>().hasPackage=true;
            mobil.GetComponent<Delivery>().spriteRenderer.color =Color.magenta;
            Destroy(this.gameObject, 0.5f);
        }
    }
}
