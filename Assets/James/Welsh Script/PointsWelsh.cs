using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointsWelsh : MonoBehaviour //This is a script to present the points the player has collected on the users hud
{
    public float playerScore;
    public float honey;



    public TMP_Text scoreText;
    public TMP_Text honeyText;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        honey = 0;

        scoreText.text = "Paill wedi ei gasglu " + playerScore.ToString();
        honeyText.text = "Mêl wedi'i wneud " + honey.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore < 3)
        {
            scoreText.text = "Paill wedi ei gasglu " + playerScore.ToString();
        }
        else if (playerScore >= 3)
        {
            scoreText.text = "Paill wedi ei gasglu " + playerScore.ToString() + " Dychwela i'r cwch gwenyn";
        }
        honeyText.text = "Glania fyny fan hyn " + honey.ToString();


        }
    }
