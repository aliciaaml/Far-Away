using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverAntena2 : MonoBehaviour,IDragHandler
{
   public float speed;

   public float angulo2;

    
    public void OnDrag(PointerEventData data){

        angulo2=transform.eulerAngles.z;

        if ( Input.GetAxis( "Mouse X" ) > 0 )        //derecha
        {
           if((angulo2>=0 && angulo2<90) || (angulo2>=312)){

                transform.Rotate(Vector3.forward,-speed*Time.deltaTime);
    
           }
                
        }
        
        if ( Input.GetAxis( "Mouse X" ) < 0)        //izquierda
        {
            if((angulo2>310 && angulo2<360) || (angulo2<30)){

                transform.Rotate(Vector3.forward,speed*Time.deltaTime);
            }
           
                
        }

    }
}
