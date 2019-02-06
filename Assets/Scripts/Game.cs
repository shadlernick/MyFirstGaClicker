using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ScoreText;
    int score = 0;
    public GameObject ShopPanel;

    public void _ShopPanel()
    {
        ShopPanel.SetActive(!ShopPanel.activeSelf);
    }

    public void OnClick()
    {        
        score++;
        ScoreText.text = "Score: " + score;
    }
} 
