using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource NormalRacketSound;
    public AudioSource LowPongSound;
    
    private void OnCollisionEnter2D(
        Collision2D collision){
       if(collision.gameObject.name =="RacketWahluigi" || collision.gameObject.name == "RacketWario")
        {
            this.LowPongSound.Play();
        }
        else
        {
            this.NormalRacketSound.Play();
        }
    }








}



 

    



