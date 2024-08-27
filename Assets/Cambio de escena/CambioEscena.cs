using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    private void Update(){
        int escena_actual = SceneManager.GetActiveScene().buildIndex;
        if(Input.GetKeyDown(KeyCode.P)){
            if(escena_actual ==0){
                CambioDeEscena(1);
            }else if(escena_actual ==1){
                CambioDeEscena(2);
            }else{
                CambioDeEscena(0);
            }
        }
    }
    public void CambioDeEscena(int index_escena_nueva){
        SceneManager.LoadScene(index_escena_nueva);
    }
}
