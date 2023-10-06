using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Renderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<Renderer>();

        mr.material.color = new Color(1f, 0f, 0.8f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
