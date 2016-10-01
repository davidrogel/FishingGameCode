using UnityEngine;
using System.Collections;

public class GoldFish : MonoBehaviour {

    public float movSpeed;

    Vector3 velocity;
    	
	void Update () {

        velocity.z = movSpeed;
        
        transform.Translate(-velocity * Time.deltaTime, Space.World);
    }
}
