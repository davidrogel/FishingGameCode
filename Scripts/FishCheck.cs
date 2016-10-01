using UnityEngine;
using System.Collections;

public class FishCheck : MonoBehaviour {

    public float radius = 0.3f, limit = -5;

    public Transform fishHead;

    public LayerMask playerLayerMask;        
	
	void Update () {
        if (!GameManager.Instance.GetEndGame())
            Check();
    }

    void Check()
    {
        if (transform.position.z < limit)
            Fish();

        bool hit = Physics.CheckSphere(fishHead.position, radius, playerLayerMask);
        if (hit)
        {
            Fish();
            GameManager.Instance.AddPoint();
        }
    }

    void Fish()
    {
        Destroy(gameObject);
    }
}
