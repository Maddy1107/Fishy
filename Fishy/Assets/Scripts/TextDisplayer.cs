using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text gameOverscoreText;
    float speed = 2f;
    float distance;

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameplay)
        {
            distance += speed * Time.deltaTime;
            scoreText.text = " " + (int)distance;
        }
        else
            gameOverscoreText.text = " " + (int)distance;
    }
}
