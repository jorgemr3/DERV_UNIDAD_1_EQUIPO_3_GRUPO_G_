using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class conversacion : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo{
        public string name;
        public string texto;
        public Sprite imagen;
    }

    public List<Dialogo> charla;
    [SerializeField] TextMeshProUGUI txt_msj;
     [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image foto_personaje ;

    [SerializeField] private GameObject obj;  
    [SerializeField] private float increaseSpeed; 

    int contador;
    void Start()
    {
        contador=0;
        mostrardialogo();
        StartCoroutine(AumentarTamano());
    }

    void mostrardialogo(){
        txt_msj.text = charla[contador].texto;
        txt_nombre.text= charla[contador].name;
        foto_personaje.sprite=charla[contador].imagen;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            contador++;
            contador= contador % charla.Count;
            mostrardialogo();
        }
    }
     IEnumerator AumentarTamano(){
        while (true){ 
        obj.transform.localScale += new Vector3(increaseSpeed, increaseSpeed, increaseSpeed)*contador;
        yield return new WaitForSeconds(0.01f); 
        }
    }
}
