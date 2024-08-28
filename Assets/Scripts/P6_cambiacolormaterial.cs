using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class P6_cambiacolormaterial : MonoBehaviour
{
    Renderer rend;
    [SerializeField]Material color1;
    [SerializeField]Material color2;
    

    int estado;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        estado = 0;
        //colorcito = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            if (estado == 0){
                estado = 1;
                rend.material = color1;
            }else{
                estado = 0;
                rend.material = color2;
            }
        }
    }
}
