using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts;

public class Game : MonoBehaviour
{
    public Text scoreText;
    public Text loginText;
    int score = 0;
    public GameObject shopPanel;

    public GameObject startPanel;
    public InputField inputName;

    public void Start()
    {
        startPanel.SetActive(true);
    }

    public void SetName()
    {
        Player player = new Player(inputName.text);
        loginText.text = inputName.text;
        startPanel.SetActive(false);
    }

    public void ShopPanel()
    {
        shopPanel.SetActive(!shopPanel.activeSelf);
    }

    public void OnClick()
    {        
        score++;
        scoreText.text = "Score: " + score;
    }
} 
