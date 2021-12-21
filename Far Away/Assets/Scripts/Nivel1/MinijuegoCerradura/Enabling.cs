using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabling : MonoBehaviour
{

    //public GameObject flecha_dialogo;
    public GameObject fondo;
    public GameObject base_c;
    public GameObject piñon;
    public GameObject piñon1;
    public GameObject piñon2;
    public GameObject piñon3;
    public GameObject piñon4;
    public GameObject flechas_piñones;
    public GameObject cerradura;


    public void whenCerraduraClicked(){

        if(!EsconderTexto.run){
            if (fondo.activeInHierarchy==false){
                flechas_piñones.SetActive(true);
                //flecha_dialogo.SetActive(false);
                fondo.SetActive(true);
                cerradura.SetActive(false);
            }
                
            if (base_c.activeInHierarchy==false)
                base_c.SetActive(true);

            if (piñon.activeInHierarchy==false)
                piñon.SetActive(true);

            if (piñon1.activeInHierarchy==false)
                piñon1.SetActive(true);

            if (piñon2.activeInHierarchy==false)
                piñon2.SetActive(true);

            if (piñon3.activeInHierarchy==false)
                piñon3.SetActive(true);

            if (piñon4.activeInHierarchy==false)
                piñon4.SetActive(true);

        }
        

    }


}
