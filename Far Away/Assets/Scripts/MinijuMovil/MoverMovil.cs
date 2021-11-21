using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverMovil : MonoBehaviour, IDragHandler
{

     Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData data){

        //transform.position=data.position;

        Vector2 position = rigidbody2d.position;
        
        position=data.position;

        rigidbody2d.MovePosition(position);
    }
}
