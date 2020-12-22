using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] Text scoreText;
    float speed = 2f;
    float distance;

    // Update is called once per frame
    void Update()
    {
        distance += speed * Time.deltaTime;
        scoreText.text = " " + (int)distance;
    }
}
