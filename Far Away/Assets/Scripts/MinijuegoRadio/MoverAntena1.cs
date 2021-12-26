using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverAntena1 : MonoBehaviour, IDragHandler
{

    public float speed;
    public float angulo1;

    
    public void OnDrag(PointerEventData data){

        angulo1 = transform.eulerAngles.z;


        if(EsconderTexto.boton_no){

            if ( Input.GetAxis( "Mouse X" ) > 0 )        //derecha
            {
                if((angulo1>=0 && angulo1<90) || (angulo1>=339)){

                    transform.Rotate(Vector3.forward,-speed*Time.deltaTime);

                }
                
            }
            if ( Input.GetAxis( "Mouse X" ) < 0)        //izquierda
            {
                if((angulo1>337 && angulo1<360) || (angulo1<45)){

                    transform.Rotate(Vector3.forward,speed*Time.deltaTime);

                }
            
            }
        }
    
    }
}
