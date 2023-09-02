using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;
   //public Text door;
    public ParticleSystem Pickup;
    public GameObject coin;
    public GameObject door1;
    public GameObject door;
    void Start()
    {
       Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {

    
    if(other.gameObject.CompareTag("coin")){
      score++;
      Debug.Log("coin");
      //scoreText.text = score.ToString();
      
      Destroy(door1);
      Destroy(other.gameObject);

      Pickup.Play();
   }
    // Debug.Log("Trigger Enter");
    }
}
