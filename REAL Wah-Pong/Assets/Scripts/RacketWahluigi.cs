using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketWahluigi : MonoBehaviour
{
    public float movementSpeed;

    public void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
    }
}
