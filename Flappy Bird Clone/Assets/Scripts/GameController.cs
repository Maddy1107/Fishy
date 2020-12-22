using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool gameplay { get; set; }
    public static GameController instance;
    [SerializeField] GameObject gameover;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameplay = true;
    }

    private void Update()
    {
        
    }
}
