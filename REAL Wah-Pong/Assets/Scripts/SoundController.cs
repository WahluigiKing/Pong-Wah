using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource LowPongSound;
    public AudioSource NormalPongSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket Wahluigi" || collision.gameObject.name == "Racket Wario")
        {
            this.NormalPongSound.Play();
        }
        else
        {
            this.LowPongSound.Play();
        }
    }
}

