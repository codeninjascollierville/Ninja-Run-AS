using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text door;
    public ParticleSystem Pickup;
    public GameObject door1;
    void Start()
    {
       Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {

    
    if(other.gameObject.CompareTag("coin")){
        score++;
        Debug.Log("coin");
        scoreText.text = score.ToString();
       
       
        //Debug.Log(score);
       
       Destroy(door1);
        Destroy(other.gameObject);

   //Destroy(other.gameObject);
    Pickup.Play();
    Destroy(other.gameObject);
    
     Debug.Log("Trigger Enter");
   
    //if(touching(coin)){
      //   coin.collect;
    //}
    
    //{
      //door;
    //}
    //door.setActive(true);

     //{
    //door;
   //}
   }
    // Debug.Log("Trigger Enter");
    }
}
