using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverAntenas : MonoBehaviour, IDragHandler
{

    public float smooth;
    float tiltAngle = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    
    public void OnDrag(PointerEventData data){


        //transform.position=data.position;

        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

    
    }
}
