using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delivery : MonoBehaviour
{

    public GameObject PaketDiambil;

    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    public bool hasPackage;

    public SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Brug!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Pelanggan" && hasPackage)
        {
            Debug.Log("Paket Sampai");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
       
    }

}