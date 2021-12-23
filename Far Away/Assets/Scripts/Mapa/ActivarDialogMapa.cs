using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDialogMapa : MonoBehaviour
{

    public GameObject dialogo2;
    public GameObject dialogo3;

    public MapaDialogoNivel2 reloj2;
    public MapaDialogoNivel3 reloj3;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CargarEscenasBoton.nivel2_bloq && !EsconderTexto.boton_no){

            dialogo3.SetActive(false);
            StartCoroutine(reloj2.Reloj());
            dialogo2.SetActive(true);      
            CargarEscenasBoton.nivel2_bloq=false;
        }
            


        if(CargarEscenasBoton.nivel3_bloq  && !EsconderTexto.boton_no){

            dialogo2.SetActive(false);
            StartCoroutine(reloj3.Reloj());
            dialogo3.SetActive(true);
            CargarEscenasBoton.nivel3_bloq=false;
        }
            
    }
}
