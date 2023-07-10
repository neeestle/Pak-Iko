using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Delivery : MonoBehaviour
{

    
    public int score = 0;
    public GameObject CanvaWin;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;
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

            score += 1;
            CheckWinCondition(); // Call the check function after each score increment
            Debug.Log("Delivered! Score: " + score);// Show a message in the console
            scoreText.text = "Score: " + score;
            scoreText2.text = " " + score;
            //Increase the score in the scoring script.


        }

    }

    private void CheckWinCondition()
    {
        if (score == 5)
        {
            YouWin();
        }
    }

    // Function to be called when the player wins the game
    private void YouWin()
    {
        CanvaWin.SetActive(true); // Set the You Win canvas to active
        Time.timeScale = 0f;

        // Stop the game or perform any other necessary actions
        // ...
    }
}