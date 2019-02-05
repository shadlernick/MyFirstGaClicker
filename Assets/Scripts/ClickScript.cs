using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    public Text ScoreText;
    int score = 0;

    public void OnClick()
    {        
        score++;
        ScoreText.text = "Score: " + score;
    }
} 
