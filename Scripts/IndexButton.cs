﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IndexButton : MonoBehaviour {

	public void Play()
    {
        SceneManager.LoadScene("main");
    }
}
