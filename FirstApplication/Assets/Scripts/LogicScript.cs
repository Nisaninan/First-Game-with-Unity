using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore;
    }
}
