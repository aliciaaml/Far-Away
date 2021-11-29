using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverAntena1 : MonoBehaviour, IDragHandler
{

    public float speed;

    
    public void OnDrag(PointerEventData data){


        //transform.rotation=data.rotation;

        if ( Input.GetAxis( "Mouse X" ) > 0 )        //derecha
        {
           if((transform.eulerAngles.z>=0 && transform.eulerAngles.z<90) || (transform.eulerAngles.z>=339)){

                transform.Rotate(Vector3.forward,-speed*Time.deltaTime);

                Debug.Log("Derecha");
           }
                
        }
        if ( Input.GetAxis( "Mouse X" ) < 0)        //izquierda
        {
            if((transform.eulerAngles.z>337 && transform.eulerAngles.z<360) || (transform.eulerAngles.z<45)){

                transform.Rotate(Vector3.forward,speed*Time.deltaTime);

                Debug.Log("Izquierda");
            }
            
            
           
                
        }

        Debug.Log(transform.eulerAngles.z);




/*
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

        Debug.Log(tiltAngle);
*/
    
    }
}
