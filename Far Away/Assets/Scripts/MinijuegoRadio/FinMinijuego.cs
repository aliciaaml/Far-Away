using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinMinijuego : MonoBehaviour
{

    public GameObject completado;
    public GameObject button;

    public MoverAntena1 antena1;
    public MoverAntena2 antena2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((antena2.angulo2<300 && antena2.angulo2>30) && (antena1.angulo1<300 && antena1.angulo1>45)){

            completado.SetActive(true);
            button.SetActive(true);
        }
    }
}
