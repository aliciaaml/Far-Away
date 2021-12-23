using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDialogos : MonoBehaviour
{
    public Textos textos;
    [SerializeField] ControlDeDialogo control;

    private void OnMouseDown()
    {
        if(EsconderTexto.boton_no){
            if(gameObject.transform.name=="Interruptor"){
                foreach (Item item in Inventory.inst.items)
                {
                    if (item.name == "Nota")
                    {
                        control.ActivarCuadro(textos);
                    }
                }
            }

            else if(!MinigameEnter.circularDisable){
                control.ActivarCuadro(textos);
            }

        }

        
        
      
    }
}
