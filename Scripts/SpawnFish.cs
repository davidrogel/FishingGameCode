using UnityEngine;
using System.Collections;

public class SpawnFish : MonoBehaviour {
    
    public float leftLimit = -4, rightLimit = 4;
    public float timeBetweenSpawnFish = 2.2f;
    public float minTimeBetweenOneFishAndOther = 0.5f;

    float decrement = 0.0035f;
    int goldFishProbability = 10;

    public GameObject fish;
    public GameObject goldFish;

    Transform myTransform;

	void Start () {
        myTransform = transform;
        Invoke("Spawn", timeBetweenSpawnFish);
	}

    void Update()
    {   
        if (timeBetweenSpawnFish > minTimeBetweenOneFishAndOther)
        {
            timeBetweenSpawnFish -= decrement;
        }
    }

    void Spawn()
    {
        Vector3 newSpawnPoint = new Vector3(Random.Range(leftLimit, rightLimit), 
            myTransform.position.y, myTransform.position.z);        
        
        Instantiate(fish, newSpawnPoint, fish.transform.rotation);
        
        if(GetRandomNumber() <= goldFishProbability)
        {
            Instantiate(goldFish, newSpawnPoint, goldFish.transform.rotation);
        }
        
        if (!GameManager.Instance.GetEndGame())
            Invoke("Spawn", timeBetweenSpawnFish);
    }

    int GetRandomNumber()
    {
        return Random.Range(1, 100);
    }
}
