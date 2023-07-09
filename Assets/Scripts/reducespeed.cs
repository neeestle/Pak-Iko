using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reducespeed : MonoBehaviour
{
    public float speedMultiplier = 0.5f; // Faktor pengurangan kecepatan, misalnya 0.5 akan mengurangi kecepatan menjadi setengah

    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity *= speedMultiplier;
        }
    }
}
