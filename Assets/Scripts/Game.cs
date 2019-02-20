using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts;

public class Game : MonoBehaviour
{
    public Text scoreText;
    public Text loginText;
    public GameObject shopPanel;
    Player player = new Player();
    public GameObject startPanel;
    public InputField inputName;
    public Text speedText;
    public Text moneyText;
    public Text materialsText;
    public GameObject Background;
    public Animator animator;
    

    private Vector3 startPosition;

    public void Start()
    {
        animator = Background.GetComponent<Animator>();
        animator.speed = player.Speed / 10;
        //startPanel.SetActive(true);
        StartCoroutine(ScorePerSec());
    }

    public void Update()
    {
        animator.speed = player.Speed / 10;
        scoreText.text = "Score: " + player.Score;
        speedText.text = "Speed: " + player.Speed;
        moneyText.text = "Money: " + player.Money;
        materialsText.text = "Materials: " + player.Materials;
        MoveBack();
    }

    public void MoveBack()
    {
        
    }

    IEnumerator ScorePerSec()
    {
        int tempScore = 0;
        while (true)
        {
            player.PlusScore();
            player.Score += player.Speed / 10;
            if (player.Score - tempScore >= 5)
            {
                player.Money += (player.Score - tempScore) / 5;
                tempScore = player.Score;
            }
            player.SpeedDown();
            //sky.transform.position = new Vector3(-1, sky.transform.position.y, sky.transform.position.z);
            yield return new WaitForSeconds(1);
        }
    }

    public void SetName()
    {
        player.Name = inputName.text;
        loginText.text = inputName.text;
        startPanel.SetActive(false);
    }

    public void ShopPanel()
    {
        shopPanel.SetActive(!shopPanel.activeSelf);
    }

    public void OnClick()
    {
        player.PlusSpeed();        
    }

    public void UpgradeEngine()
    {
        player.UpgradeEngine(player);
    }

    public void UpgradeBorer()
    {
        player.UpgradeBorer(player);
    }
} 
