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

    public static bool puerProta_bloq;
    public static bool puertaIglesia_bloq;
    public static bool puertaAyuntamiento_bloq;
    public static bool  puertaComun_bloq;

    public GameObject dialogoPuertaProta;
    public GameObject dialogoIglesia;
     public GameObject dialogoSalaComun;

    public DialogoPuerProta reloj;
    public DialogoIglesia reloj2;
    public DialogoSalaComun reloj3;

    public static bool desbloq_purtaCura=false;
    public static bool desbloq_puertaCasa4=false;
    public static bool no_puertaCura=false;
    public static bool no_casa4=false;
    public static bool colion_ayuntamiento=false;

    

    public static DoorController puerta;
    public static bool dialog=false;

    public static bool desbloq_ayuntamiento=false;








    private void Awake(){

        if(GuardarPos.pulsado==false && GuardarPos_N2.pulsado==false && GuardarPos_N3.pulsado==false)
            gameObject.transform.position = new Vector2 (Position.posAux,-1.3f);
        
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
        puerProta_bloq=false;
        puertaIglesia_bloq=false;
        guardar_pos.x=-4.08f;

        puertaAyuntamiento_bloq=false;
        puertaComun_bloq=false;

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
                SceneManager.LoadScene(nextScene);
                
            }
            if(puerProta_bloq){
                dialogoPuertaProta.SetActive(true);
                StartCoroutine(reloj.Reloj());
        

            }

            if(puertaIglesia_bloq){
                dialogoIglesia.SetActive(true);
                StartCoroutine(reloj2.Reloj());
                desbloq_purtaCura=true;   

            }
            if(puertaComun_bloq){
                dialogoSalaComun.SetActive(true);
                StartCoroutine(reloj3.Reloj());
                desbloq_ayuntamiento=true;

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

            puerta = collision.gameObject.GetComponent<DoorController>();


            if (collision.gameObject.transform.parent.name == "casaProta")
            {
                if(puerta.isLocked)    
                    puerProta_bloq=true;

                else
                    puerProta_bloq=false;
          
           
            }

            
            if (collision.gameObject.transform.parent.name == "iglesia")
            {
                if(puerta.isLocked){
                    puertaIglesia_bloq=true;

                }    
                    
                else
                    puertaIglesia_bloq=false;

                foreach (Item item in Inventory.inst.items)
                {
                    if (item.name == "LlaveIglesia")
                    {
                        //Inventory.inst.Remove(item);
                        puerta.isLocked = false;
                    }
                }
            }

            if (collision.gameObject.transform.parent.name == "torreCom")
            {
                if(puerta.isLocked){
                    puertaComun_bloq=true;

                }    
                    
                else
                    puertaComun_bloq=false;

                foreach (Item item in Inventory.inst.items)
                {
                    if (item.name == "Llave2")
                    {
                        //Inventory.inst.Remove(item);
                        puerta.isLocked = false;
                    }
                }
            }





            if (collision.gameObject.transform.parent.name == "ayuntamiento")
                colion_ayuntamiento=true;

            if (collision.gameObject.transform.parent.name == "ayuntamiento" && desbloq_ayuntamiento)
            {
                puerta.isLocked = false;
            }

          

            if (collision.gameObject.transform.parent.name == "casaIglesia2" && !desbloq_purtaCura){
                no_puertaCura=true;
            }
            if (collision.gameObject.transform.parent.name == "casaIglesia2" && desbloq_purtaCura){

                desbloq_puertaCasa4=true;
                dialog=true;
            }
                

            if (collision.gameObject.transform.parent.name == "casaIglesia1" && !desbloq_puertaCasa4)
                no_casa4=true;
                    

            if (collision.gameObject.transform.parent.name == "casaIglesia1" &&  desbloq_puertaCasa4)
                puerta.isLocked=false;
                
            
            

            nextScene = puerta.sceneName;
            puerta.displayInstructions();
            if(!puerta.isLocked){
                goNext1 = true;
            }   

               
      
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puerta")
         {
            puerta = collision.gameObject.GetComponent<DoorController>();
            puerta.hideInstructions();
            goNext1 = false;
            puerProta_bloq=false;
            puertaIglesia_bloq=false;
            puertaComun_bloq=false;
            no_puertaCura=false;
            no_casa4=false;
            colion_ayuntamiento=false;
            
        }
    }


        


  
}
