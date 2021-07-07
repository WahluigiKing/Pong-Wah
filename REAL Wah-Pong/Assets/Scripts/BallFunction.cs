using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFunction : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(this.StartBall()); 
    }
    public IEnumerator StartBall(bool isStartingWahluigi = true)
    {
        this.PositionBall(isStartingWahluigi);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingWahluigi)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    public void IncreaseHitCounter()
    {
        if (this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
        {
            this.hitCounter++;
        }
    }

    public void MoveBall (Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = dir * speed;
    
    }

    void PositionBall(bool isStartingWahluigi)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isStartingWahluigi)
        {
            this.gameObject.transform.localPosition = new Vector3(-190, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(190, 0, 0);
        }
    }

}


