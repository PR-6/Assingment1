﻿using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text userName;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        userName.text = Menu.userName();
    }
}
