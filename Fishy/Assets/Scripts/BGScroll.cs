using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float speed = 0.05f;
    Renderer rend;

    private void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
}
