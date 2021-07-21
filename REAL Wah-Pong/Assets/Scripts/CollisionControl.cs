using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    public BallFunction ballFunction;
    public ScoreController scoreController;


    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Racket Wahluigi")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        this.ballFunction.IncreaseHitCounter();
        this.ballFunction.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.name == "Racket Wahluigi" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(collision);
        } 
        else if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Wario gains +1 point.");
            this.scoreController.GoalWario();
            StartCoroutine(this.ballFunction.StartBall(true));

        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Wahluigi gains +1 point.");
            this.scoreController.GoalWahluigi();
            StartCoroutine(this.ballFunction.StartBall(false));
        }
    }
       
}
