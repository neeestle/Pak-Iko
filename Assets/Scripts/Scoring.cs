using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int score; // Declaration of the static integer variable "score"
    public TextMeshProUGUI scoreText;
 
    

    public GameObject CanvaWin; // Reference to the Canvas object for displaying the "You win" message

    // Other code and methods for the scoring script
    void Start()
    {
        // Any code you want to run when the script starts can be placed here
    }

    // Update is called once per frame
    void Update()
    {
        // Any code you want to run continuously can be placed here
    }

    // Check if the player reached 10 points and call the YouWin function
    private void CheckWinCondition()
    {
        if (score == 10)
        {
            YouWin();
        }
    }

    // Function to be called when the player wins the game
    private void YouWin()
    {
        CanvaWin.SetActive(true); // Set the You Win canvas to active

        // Stop the game or perform any other necessary actions
        // ...
    }

    // Example of a method where the score might be incremented
    public void IncrementScore()
    {
        score += 1;
        CheckWinCondition(); // Call the check function after each score increment
        scoreText.text = score.ToString();

        Debug.Log("Item picked up! Score: " + score); // Show a message in the console
    }
}