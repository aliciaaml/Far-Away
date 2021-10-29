using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosRaton : MonoBehaviour
{

    public GameObject comenzar, comenzar_iluminado;

    // Start is called before the first frame update
    void Start()
    {
        comenzar.gameObject.SetActive(true);
        comenzar_iluminado.gameObject.SetActive(false);
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
        comenzar.gameObject.SetActive(false);
        comenzar_iluminado.gameObject.SetActive(true);


    }

    void OnMouseExit()
    {
        print("ya no estas encima");
        comenzar.gameObject.SetActive(true);

    }
}
