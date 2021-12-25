using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoPasar2 : MonoBehaviour
{

    public NoPasar2Dialog reloj;
    public GameObject dialogoCasa5;
    public GameObject dialogoCasa5Entrar;

    public string scene;

    public static bool salido=false;

    //public PlayerController personaje;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")){

            if(PlayerController.no_puertaCura){  //Si no he pasado por la iglesia y estoy en colisión con la puerta 2
                dialogoCasa5.SetActive(true);
                StartCoroutine(reloj.Reloj());
                
      
            }

            if(PlayerController.dialog){
                
                salido=true;
                if(DestroyDialoN2.no_rep2){
                    dialogoCasa5Entrar.SetActive(true);
                    Debug.Log(scene);  
                    StartCoroutine(Espera());
                }
                PlayerController.dialog=false;
              
       
            }

        }
   
    }

    IEnumerator Espera ()
    {
        yield return new WaitForSeconds(9);
        PlayerController.puerta.isLocked=false;
        SceneManager.LoadScene(scene);

        

    }
    
    
}
