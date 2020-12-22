using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishObsMove:MonoBehaviour
{
    float speed = 3f;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        if(transform.position.x < player.transform.position.x)
        {
            Destroy(gameObject, 1);
        }
    }
}
