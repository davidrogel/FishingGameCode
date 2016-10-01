using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

    public GameObject playButton;
	
    void ActivarBoton()
    {
        playButton.SetActive(true);
    }

    void DesactivarBoton()
    {
        playButton.SetActive(false);
    }
}
