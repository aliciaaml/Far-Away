using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    private void OnMouseDown()
    {
        
        if(!MinigameEnter.circularDisable && EsconderTexto.boton_no)
            Destroy(gameObject);
    }
}
