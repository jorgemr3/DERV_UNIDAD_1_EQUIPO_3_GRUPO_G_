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

    [SerializeField] private GameObject obj2;     
    [SerializeField] private float increaseSpeed; 

    int contador;
    void Start()
    {
        contador=0;
        mostrardialogo();
        StartCoroutine(AumentarTamano());
        StartCoroutine(AumentarTamano2());
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
        obj.transform.localScale += new Vector3(increaseSpeed, increaseSpeed, increaseSpeed);
        yield return new WaitForSeconds(0.01f); 
        }
    }

    IEnumerator AumentarTamano2(){
        while (true){ 
        obj2.transform.localScale += new Vector3(increaseSpeed, increaseSpeed, increaseSpeed);
        yield return new WaitForSeconds(0.01f); 
        }
    }

   
    // se crea una metodo iterable que aumenta cada cierto tiempo que este retorna 
    // y se inicializa en el startCoroutine mandandolo a llamar en el start, funge la misma funcion que un metodo init aunque no se parece 
}
