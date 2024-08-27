using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_cambiacolorinspector : MonoBehaviour
{
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color= Color.blue;
    }
}
