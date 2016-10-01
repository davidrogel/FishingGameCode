using UnityEngine;
using System.Collections;

public class FishManager : MonoBehaviour {

    public float movSpeed = 3, increment = 0.0035f;
    public float maxSpeed = 15;


    void Update()
    {
        IncrementVelocity();
    }

    void IncrementVelocity()
    {
        if (movSpeed <= maxSpeed)
        {
            movSpeed += increment;
        }
    }

    public float GetMovSpeed()
    {
        return movSpeed;
    }
}
