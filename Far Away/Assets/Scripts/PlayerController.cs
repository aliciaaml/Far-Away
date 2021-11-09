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
    bool looksRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if(!Mathf.Approximately(horizontal, 0.0f)){
            if(horizontal > 0) looksRight = true;
            else if(horizontal < 0) looksRight = false;
            
        }

        animator.SetBool("LookRight", looksRight);
        animator.SetFloat("Speed", horizontal);
        Debug.Log("speed: " + horizontal);

        if (Input.GetKeyDown(KeyCode.UpArrow))    //al pulsar arriba comprueba si esta en puerta
        {
            if (goNext1)     //repetir para cada puerta con su respectivo bool y escena
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }

    void FixedUpdate(){
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
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
