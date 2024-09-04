using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_Contador : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer rend;
    Color col;
    [SerializeField]


    void Start()
    {   col = Color.red;
        rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //rend.material.color = Color.white;
        rend.material.color = col;
    }
}
