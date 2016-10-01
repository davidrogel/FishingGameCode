using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
    
    float movSpeed;

    Vector3 velocity;

    FishManager fishManagerScript;

    void Start () {
        fishManagerScript = GameObject.Find("FishManager").GetComponent<FishManager>();    
    }	
	
	void Update () {
        movSpeed = fishManagerScript.GetMovSpeed();
        velocity.z = movSpeed;
                
        transform.Translate(-velocity * Time.deltaTime, Space.World);
    }    
}
