using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;


    Rigidbody2D rigidbody2d;
    float horizontal;
    bool goNext1 = false;
    private string nextScene;

    Animator animator;

    public static Vector2 guardar_pos;

    public static string escena;




    private void Awake(){

        if(GuardarPos.pulsado==false && GuardarPos_N2.pulsado==false && GuardarPos_N3.pulsado==false)
            gameObject.transform.position = new Vector2 (Position.posAux,gameObject.transform.position.y);
        
        else{
            if(GuardarPos.pulsado==true){
                gameObject.transform.position = GuardarPos.pos;
                GuardarPos.pulsado=false;
            }
            if(GuardarPos_N2.pulsado==true){
                gameObject.transform.position = GuardarPos_N2.pos;
                GuardarPos_N2.pulsado=false;
            }
            if(GuardarPos_N3.pulsado==true){
                gameObject.transform.position = GuardarPos_N3.pos;
                GuardarPos_N3.pulsado=false;
            }
                
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        escena= SceneManager.GetActiveScene().name;
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if(EsconderTexto.boton_no){

            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

            horizontal = Input.GetAxis("Horizontal");
            guardar_pos=gameObject.transform.position;
        }
        
    

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w"))&& EsconderTexto.boton_no)    //al pulsar arriba comprueba si esta en puerta
        {
            
            if (goNext1)     //repetir para cada puerta con su respectivo bool y escena
            {
                guardar_pos=gameObject.transform.position;
                //Debug.Log("POS PROTA   "+ gameObject.transform.position);
                SceneManager.LoadScene(nextScene);
                
            }
        }
    }

    void FixedUpdate(){

        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        rigidbody2d.MovePosition(position);

       

    }


    private void OnTriggerEnter2D(Collider2D collision)   //inicio de interaccion con puertas (Repetir para cada puerta con otro tag y bool ambos void)
    {
        if (collision.gameObject.tag == "Puerta")
        {

            DoorController puerta = collision.gameObject.GetComponent<DoorController>();

            if (collision.gameObject.transform.parent.name == "casaProta")
            {
                foreach (Item item in Inventory.inst.items)
                {
                    if (item.name == "Llave")
                    {
                        //Inventory.inst.Remove(item);
                        puerta.isLocked = false;
                    }
                }
            }

            
            if (collision.gameObject.transform.parent.name == "iglesia")
            {
                foreach (Item item in Inventory.inst.items)
                {
                    if (item.name == "LlaveIglesia")
                    {
                        //Inventory.inst.Remove(item);
                        puerta.isLocked = false;
                    }
                }
            }
            

            nextScene = puerta.sceneName;
            //Debug.Log("entrar");
            //Debug.Log(puerta.sceneName);
            puerta.displayInstructions();
            if(!puerta.locked){
                goNext1 = true;
            } else {
                Debug.Log("Puerta bloqueada");
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puerta")
         {
            DoorController puerta = collision.gameObject.GetComponent<DoorController>();
            puerta.hideInstructions();
            goNext1 = false;
            
        }
    }

  
}
