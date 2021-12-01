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



/*
    private void Awake(){
        gameObject.transform.position= pos.posicionAUX;

        Debug.Log(pos.posicionAUX);
    }
*/
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
            nextScene = puerta.sceneName;
            Debug.Log("entrar");
            Debug.Log(puerta.sceneName);
            goNext1 = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Puerta")
         {
            goNext1 = false;
            
        }
    }

  
}
