using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverAntena2 : MonoBehaviour,IDragHandler
{
   public float speed;

    
    public void OnDrag(PointerEventData data){


        //transform.rotation=data.rotation;

        if ( Input.GetAxis( "Mouse X" ) > 0 )        //derecha
        {
           if((transform.eulerAngles.z>=0 && transform.eulerAngles.z<90) || (transform.eulerAngles.z>=312)){

                transform.Rotate(Vector3.forward,-speed*Time.deltaTime);

                Debug.Log("Derecha");
           }
                
        }
        if ( Input.GetAxis( "Mouse X" ) < 0)        //izquierda
        {
            if((transform.eulerAngles.z>310 && transform.eulerAngles.z<360) || (transform.eulerAngles.z<30)){

                transform.Rotate(Vector3.forward,speed*Time.deltaTime);

                Debug.Log("Izquierda");
            }
            
            
           
                
        }

        Debug.Log(transform.eulerAngles.z);
    }
}
