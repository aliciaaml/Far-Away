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




    private void Awake(){

        //Vector3 pos = new Vector3(POS_PUERTAS.inst.posAux.x, gameObject.transform.position.y,gameObject.transform.position.z);

        gameObject.transform.position = new Vector2(Position.posAux.x, -1.3f);
     
        
        //Debug.Log(Position.inst.posAux);
    }

    // Start is called before the first frame update
    void Start()
    {

        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        horizontal = Input.GetAxis("Horizontal");
    

        if (Input.GetKeyDown(KeyCode.UpArrow))    //al pulsar arriba comprueba si esta en puerta
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
                    if (item.name == "Llave2")
                    {
                        Inventory.inst.Remove(item);
                        puerta.isLocked = false;
                    }
                }
            }

            
            if (collision.gameObject.transform.parent.name == "iglesia")
            {
                foreach (Item item in Inventory.inst.items)
                {
                    if (item.name == "Llave2")
                    {
                        Inventory.inst.Remove(item);
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
