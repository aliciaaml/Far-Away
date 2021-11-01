using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosRaton : MonoBehaviour
{

    public GameObject botonNormal, botonIluminado;

    // Start is called before the first frame update
    void Start()
    {
        botonNormal.gameObject.SetActive(true);
        botonIluminado.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        print("me estas apretando ");
    }


    void OnMouseEnter()
    {
        print("estas encima del boton");
        botonNormal.gameObject.SetActive(false);
        botonIluminado.gameObject.SetActive(true);


    }

    void OnMouseExit()
    {
        print("ya no estas encima");
        botonNormal.gameObject.SetActive(true);

    }
}
