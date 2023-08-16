﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public ParticleSystem Pickup;

    void Start()
    {
       Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("coin")){
        score++;
        scoreText.text = score.ToString();
       
       
        Debug.Log(score);
       
       
        Destroy(other.gameObject);
    Pickup.Play();
   
    }
    // Debug.Log("Trigger Enter");
    }
}
