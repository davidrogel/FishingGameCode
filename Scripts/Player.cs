using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float movSpeed = 5;
    public float leftLimit = -4, rightLimit = 4;
    
    Vector2 velocity;

    Transform myTransform;

	void Start () {
        
        myTransform = transform;
	}	
	
	void Update () {

        if (!GameManager.Instance.GetEndGame())
            Mov();                           
	}

    void Mov()
    {
        float horInput = Input.GetAxisRaw("Horizontal");
        velocity.x = horInput * movSpeed;

        if (myTransform.position.x < leftLimit && horInput < 0)
        {
            velocity = Vector2.zero;
        }
        else if (myTransform.position.x > rightLimit && horInput > 0)
        {
            velocity = Vector2.zero;
        }

        myTransform.Translate(velocity * Time.deltaTime, Space.World);
    }    
}
