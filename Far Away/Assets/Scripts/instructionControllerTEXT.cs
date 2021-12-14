using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class instructionControllerTEXT : MonoBehaviour
{
    private Text instruction;
    DoorController door; 
    void Start()
    {
        door = gameObject.transform.parent.gameObject.transform.parent.GetComponent<DoorController>();
        instruction = GetComponent<Text>();
        instruction.text = door.locked? "EXAMINAR": "ENTRAR";
        //Debug.Log("locked door: " + door.locked);
    }

    public void changeText(){
        instruction.text = door.locked? "EXAMINAR": "ENTRAR";
    }



}
