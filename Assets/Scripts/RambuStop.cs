using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RambuStop : MonoBehaviour
{
    // Tulisan yang ingin ditampilkan
    public string message = "Berhenti";
    
    // Metode yang dipanggil ketika ada GameObject lain yang masuk ke dalam trigger area
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Cek apakah GameObject yang masuk adalah Player
        if (other.CompareTag("Player"))
        {
            // Tampilkan tulisan
            Debug.Log(message);
        }
    }
}