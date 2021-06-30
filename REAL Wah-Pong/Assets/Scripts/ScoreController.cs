using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    private int scoreWahluigi = 0;
    private int scoreWario = 0;

    public GameObject scoreTextWahluigi;
    public GameObject scoreTextWario;
    
    public int goalToWin;
    private void Update()
    {
        if(this.scoreWahluigi >= this.goalToWin || this.scoreWario >= this.goalToWin)
        {
            Debug.Log("Game won!");
        }
    }

    private void FixedUpdate()
    {
        Text uiScoreWahluigi = this.scoreTextWahluigi.GetComponent<Text>();
        uiScoreWahluigi.text = this.scoreWahluigi.ToString();

        Text uiScoreWario = this.scoreTextWario.GetComponent<Text>();
        uiScoreWario.text = this.scoreWario.ToString();
    }
    public void GoalWahluigi()
    {
        this.scoreWahluigi++;
    }
    public void GoalWario()
    {
        this.scoreWario++;
    }
}
