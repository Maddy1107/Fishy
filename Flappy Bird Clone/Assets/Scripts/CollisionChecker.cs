using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionChecker : MonoBehaviour
{
    public UnityEvent collider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collider.Invoke();
        GameController.instance.gameplay = false;
    }
}
