using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float gameTime = 30;

    public TextMesh textTime, textScore;
    float timeForText = 29;

    int score;
    bool endGame;

    public RiverController riverControllerScript;
    public GameObject poster;
    Animator scoreAnim;

    #region GameManager Singleton
    static GameManager instance;

    public static GameManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }
    #endregion

    void Start()
    {
        scoreAnim = poster.GetComponent<Animator>();
        endGame = false;        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Time.timeSinceLevelLoad > gameTime)
        {
            endGame = true;
        }

        if(timeForText > 0)
        {
            timeForText -= 0.016f;
        }

        textTime.text = "Tiempo Restante: " + Mathf.RoundToInt(timeForText).ToString();

        if(riverControllerScript.GetVelocity() <= 1)
        {
            textScore.text = "Puntuación: " + "\n" + score.ToString();
            scoreAnim.SetBool("in", true);
            scoreAnim.SetBool("out", false);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("main");
    }

    public void AddPoint()
    {
        score++;
    }

    public void AddGoldPoint()
    {
        score += 3;
    }

    public bool GetEndGame()
    {
        return endGame;
    }
}
