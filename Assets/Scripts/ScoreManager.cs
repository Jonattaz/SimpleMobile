using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    float pointsPerSeconds;

    [SerializeField]
    Text ScoreTxt;

    [SerializeField]
    Text highScoreTxt;

    public float score;
    float highScore;

    public bool isScoreIncreasing;

    // Start is called before the first frame update
    void Start()
    {
        isScoreIncreasing = true;
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highScore = PlayerPrefs.GetFloat("Highscore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isScoreIncreasing)
        score += pointsPerSeconds * Time.deltaTime;

        if (score >= highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("Highscore", highScore);
        }

        ScoreTxt.text = Mathf.Round(score).ToString();

        highScoreTxt.text = Mathf.Round(highScore).ToString();
    }
}















