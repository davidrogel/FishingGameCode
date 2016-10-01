using UnityEngine;
using System.Collections;

public class RiverController : MonoBehaviour {

    public float riverSpeed = 3;

    float decrement = 0.01f;
    float downLimit = -12;
    float startPosition = 24.77f;

    Transform myTransform;
	
	void Start () {
        myTransform = transform;
	}
	
	
	void Update () {
        
        myTransform.Translate(Vector3.left * riverSpeed * Time.deltaTime);

        if (myTransform.position.z < downLimit)
        {
            myTransform.transform.position = new Vector3(myTransform.position.x, myTransform.position.y, startPosition);
        }

        if (GameManager.Instance.GetEndGame())
        {
            DecrementVelocity();
        }
    }

    void DecrementVelocity()
    {
        if(riverSpeed > 0)
        {
            riverSpeed -= decrement;
        }
    }

    public float GetVelocity()
    {
        return riverSpeed;
    }
}
