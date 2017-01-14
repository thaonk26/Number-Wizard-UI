using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;
    public int maxGuessesAlowed = 6;
    public Text text;

    void Start()
    {
        StartGame();

    }


    // Use this for initialization
    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();

    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        maxGuessesAlowed -= 1;
        if(maxGuessesAlowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }

}
