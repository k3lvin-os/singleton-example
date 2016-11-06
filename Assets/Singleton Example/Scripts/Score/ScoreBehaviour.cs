using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour
{

    private Text ScoreText;
    private float _score;

    /// <summary>
    ///  Main component of Singleton Pattern
    /// </summary>
    public static ScoreBehaviour Instance { get; set; }

    void Start()
    {
        ////////////////////////////////////////// SINGLETON PATTERN /////////////////////////////
        if (Instance == null)
        {
            Instance = this;
        }
        ////////////////////////////////////////// SINGLETON PATTERN /////////////////////////////


        ScoreText = GameObject.Find("_Root").transform.Find("Canvas").transform.Find("Score").Find("Value").GetComponent<Text>();
    }

    public void UpdateScore()
    {
        _score++;
        ScoreText.text = _score.ToString();
    }
}
