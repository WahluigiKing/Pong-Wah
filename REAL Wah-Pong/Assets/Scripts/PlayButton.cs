using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
   public void PlayGame()
    {
        Debug.Log("Start was pressed");

        // Moves us to the Game scene.
        SceneManager.LoadScene("Game");
    }
   
}
