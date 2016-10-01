using UnityEngine;
using System.Collections;

public class PlayerAnim : MonoBehaviour {

    Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
    }	
	
	void Update () {
        if (!GameManager.Instance.GetEndGame())
            Anims();

        if (GameManager.Instance.GetEndGame())
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
        }
    }

    void Anims()
    {
        if (Input.GetKey(KeyCode.Space))
        {            
            anim.SetBool("down", true);
            anim.SetBool("up", false);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {            
            anim.SetBool("down", false);
            anim.SetBool("up", true);
        }
    }
}
