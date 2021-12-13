using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabling : MonoBehaviour
{

    public GameObject texto;
    public GameObject cuadro_dialogo;
    public GameObject flecha_dialogo;
    public GameObject fondo;
    public GameObject boton_x;
    public GameObject base_c;
    public GameObject piñon;
    public GameObject piñon1;
    public GameObject piñon2;
    public GameObject piñon3;
    public GameObject piñon4;
    public GameObject flechas_piñones;


    public void whenCerraduraClicked(){
        if (fondo.activeInHierarchy==false)
            texto.SetActive(false);
            flechas_piñones.SetActive(true);
            cuadro_dialogo.SetActive(false);
            flecha_dialogo.SetActive(false);
            fondo.SetActive(true);

        if (boton_x.activeInHierarchy==false)
            boton_x.SetActive(true);
        
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

     public void whenBoton_XClicked(){
        if (fondo.activeInHierarchy==true)
            fondo.SetActive(false);
            flechas_piñones.SetActive(false);

        if (boton_x.activeInHierarchy==true)
            boton_x.SetActive(false);
        
        if (base_c.activeInHierarchy==true)
            base_c.SetActive(false);

        if (piñon.activeInHierarchy==true)
            piñon.SetActive(false);

        if (piñon1.activeInHierarchy==true)
            piñon1.SetActive(false);

        if (piñon2.activeInHierarchy==true)
            piñon2.SetActive(false);

        if (piñon3.activeInHierarchy==true)
            piñon3.SetActive(false);

        if (piñon4.activeInHierarchy==true)
            piñon4.SetActive(false);

    }
}
