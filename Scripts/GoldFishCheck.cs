using UnityEngine;
using System.Collections;

public class GoldFishCheck : MonoBehaviour {

    float radius = 0.5f, limit = -6;

    public Transform fishHead;

    public LayerMask playerLayerMask;

    Transform myTransform;

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
            GameManager.Instance.AddGoldPoint();
        }
    }

    void Fish()
    {
        Destroy(gameObject);
    }
}
