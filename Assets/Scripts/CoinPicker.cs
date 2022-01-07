using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{

    AudioSource coinPickSound;

    float coinPoints = 5f;
    ScoreManager scoreManager;



    // Start is called before the first frame update
    void Start()
    {
        coinPickSound = GameObject.Find("CoinPickSound").GetComponent<AudioSource>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gameObject.SetActive(false);
            if (coinPickSound.isPlaying)
            {
                coinPickSound.Stop();

            }
            coinPickSound.Play();
            scoreManager.score += coinPoints;
        }
    }

}
