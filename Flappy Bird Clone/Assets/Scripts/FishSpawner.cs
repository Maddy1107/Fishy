using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] fishes;
    [SerializeField] GameObject player;
    float randy;
    int randIndex;
    float time_to_spawn = 3f;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        time_to_spawn -= Time.deltaTime;
        if(time_to_spawn < 0)
        {
            time_to_spawn = 3f;
            Newpos();
            randIndex = Random.Range(0, fishes.Length);
            Instantiate(fishes[randIndex], new Vector2(5f, randy), Quaternion.identity);
        }
    }

    void Newpos()
    {
        randy = Random.Range(-2.5f, 3.5f);
    }
}
